using System;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using PdfFont = iTextSharp.text.Font;
using MyDatabase;

namespace BD_1_2
{
    public partial class Report : Form
    {
        private SQLiteConnection sc;
        private SQLiteDataAdapter a;
        private DataSet tmp;
        private DataTable dt = new DataTable();
        private string query;
        private Form1 mainform;

        private int selectedId;
        private string selectedText;
        private string reportType;
        private DateTime startDate;
        private DateTime endDate;

        private string GetSafeString(DataRow row, string columnName)
        {
            return row.IsNull(columnName) ? "0" : row[columnName].ToString();
        }

        private decimal GetSafeDecimal(DataRow row, string columnName)
        {
            return row.IsNull(columnName) ? 0 : Convert.ToDecimal(row[columnName]);
        }

        private int GetSafeInt(DataRow row, string columnName)
        {
            return row.IsNull(columnName) ? 0 : Convert.ToInt32(row[columnName]);
        }

        public Report(int rep, SQLiteConnection connection, Form1 mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            if (connection == null || connection.State != ConnectionState.Open)
            {
                MessageBox.Show("Нет подключения к базе данных!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            this.sc = connection;
            tmp = new DataSet();
            reportType = rep.ToString();
            ConfigureDatePickers();

            if (rep == 1)
            {
                Tag = 1;
                report_label.Text = "Выберите период:";
                Description.Text = "Получить информацию по сеансам за период: цена, количество проданных билетов, выручка, заполняемость";

                report_combobox.Visible = false;
                StartDatePicker.Visible = true;
                EndDatePicker.Visible = true;
                StartDatePicker.Value = DateTime.Today.AddDays(-7);
                EndDatePicker.Value = DateTime.Today;
            }
            else if (rep == 2)
            {
                Tag = 2;
                report_label.Text = "Выберите фильм: ";
                Description.Text = "Получить информацию по выбранному фильму: количество сеансов, кол-во проданных билетов, общая выручка и средняя заполняемость зала";

                StartDatePicker.Visible = false;
                EndDatePicker.Visible = false;
                report_combobox.Visible = true;

                tmp.Tables.Add(new DataTable("Movies"));
                a = new SQLiteDataAdapter("SELECT id_movie, name FROM Movies ORDER BY name", sc);
                a.Fill(tmp.Tables["Movies"]);
                report_combobox.DisplayMember = "name";
                report_combobox.ValueMember = "id_movie";
                report_combobox.DataSource = tmp.Tables["Movies"];
            }
            else if (rep == 3)
            {
                Tag = 3;
                report_label.Text = "Выберите жанр: ";
                Description.Text = "Получить информацию по выбранному жанру: кол-во фильмов в жанре, кол-во сеансов, проданных билетов, средний рейтинг и общая выручка";

                StartDatePicker.Visible = false;
                EndDatePicker.Visible = false;
                report_combobox.Visible = true;

                tmp.Tables.Add(new DataTable("Genres"));
                a = new SQLiteDataAdapter("SELECT id_genre, genre FROM Genres ORDER BY genre", sc);
                a.Fill(tmp.Tables["Genres"]);
                report_combobox.DisplayMember = "genre";
                report_combobox.ValueMember = "id_genre";
                report_combobox.DataSource = tmp.Tables["Genres"];
            }
        }

        private void ConfigureDatePickers()
        {
            StartDatePicker.Format = DateTimePickerFormat.Short;
            EndDatePicker.Format = DateTimePickerFormat.Short;

            StartDatePicker.ValueChanged += StartDatePicker_ValueChanged;
            EndDatePicker.ValueChanged += EndDatePicker_ValueChanged;

            StartDatePicker.Visible = false;
            EndDatePicker.Visible = false;
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (StartDatePicker.Value > EndDatePicker.Value)
            {
                EndDatePicker.Value = StartDatePicker.Value;
            }
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (EndDatePicker.Value < StartDatePicker.Value)
            {
                StartDatePicker.Value = EndDatePicker.Value;
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
        }

        private async void Make_report_Click(object sender, EventArgs e)
        {
            if (reportType == "1")
            {
                startDate = StartDatePicker.Value.Date;
                endDate = EndDatePicker.Value.Date.AddDays(1).AddSeconds(-1); 


                if (startDate > endDate)
                {
                    MessageBox.Show("Начальная дата не может быть больше конечной!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else 
            {
                if (report_combobox.Visible && report_combobox.SelectedValue != null)
                {
                    selectedId = int.Parse(report_combobox.SelectedValue.ToString());
                    selectedText = report_combobox.Text;
                }
            }

            Make_report.Enabled = false;
            Exit.Enabled = false;

            if (report_combobox.Visible)
                report_combobox.Enabled = false;
            if (StartDatePicker.Visible)
                StartDatePicker.Enabled = false;
            if (EndDatePicker.Visible)
                EndDatePicker.Enabled = false;

            mainform.StatusText = "Формирование отчета";

            await GenerateReportAsync();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task GenerateReportAsync()
        {
            try
            {
                await Task.Run(() => ProcessReportData());

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Нет данных для формирования отчета!");
                    EnableControls();
                    return;
                }

                string filepath = ShowSaveDialogInternal("Отчёт", GetFileExtension());
                if (string.IsNullOrEmpty(filepath) || filepath == "CANCEL")
                {
                    EnableControls();
                    return;
                }

                mainform.StatusText = "Создание файла отчета...";
                await Task.Run(() => CreateReportFile(filepath));

                MessageBox.Show("Отчет успешно сохранен!");
                mainform.StatusText = "Отчет сформирован";
                EnableControls();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка формирования отчета: {ex.Message}", "Ошибка");
                EnableControls();
            }
        }

        private void ProcessReportData()
        {
            if (reportType == "1")
            {
                query = $@"SELECT 
                    Movies.name AS 'Название фильма',
                    Sessions.date_session AS 'Дата сеанса',
                    Sessions.start_time AS 'Время начала',
                    Cinema_Halls.id_cinema_hall AS 'Зал',
                    Sessions.price AS 'Цена билета',
                    COUNT(Tickets.id_ticket) AS 'Проданных билетов',
                    COUNT(Tickets.id_ticket) * Sessions.price AS 'Выручка',
                    (SELECT COUNT(*) FROM Seats WHERE Seats.fk_id_cinema_hall = Sessions.fk_id_cinema_hall) AS 'Всего мест',
                    ROUND(COUNT(Tickets.id_ticket) * 100.0 / 
                    (SELECT COUNT(*) FROM Seats WHERE Seats.fk_id_cinema_hall = Sessions.fk_id_cinema_hall), 2) AS 'Заполняемость (%)'
                FROM Sessions
                JOIN Movies ON Sessions.fk_id_movie = Movies.id_movie
                LEFT JOIN Cinema_Halls ON Sessions.fk_id_cinema_hall = Cinema_Halls.id_cinema_hall
                LEFT JOIN Tickets ON Sessions.id_session = Tickets.fk_id_session AND Tickets.status = 1
                WHERE Sessions.date_session BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
                GROUP BY Sessions.id_session
                ORDER BY Sessions.date_session, Sessions.start_time";
            }
            else if (reportType == "2")
            {
                query = $@"SELECT 
                    Movies.name AS 'Название фильма',
                    Age_ratings.age_rating AS 'Возрастной рейтинг',
                    Movies.duration AS 'Длительность (мин)',
                    Movies.rating AS 'Рейтинг',
                    Movies.release_year AS 'Год выхода',
                    COUNT(DISTINCT Sessions.id_session) AS 'Количество сеансов',
                    COUNT(Tickets.id_ticket) AS 'Всего продано билетов',
                    SUM(Sessions.price * (SELECT COUNT(*) FROM Tickets t WHERE t.fk_id_session = Sessions.id_session AND t.status = 1)) AS 'Общая выручка',
                    ROUND(
                        AVG(
                            (SELECT COUNT(*) FROM Tickets t2 WHERE t2.fk_id_session = Sessions.id_session AND t2.status = 1) * 100.0 /
                            (SELECT COUNT(*) FROM Seats WHERE Seats.fk_id_cinema_hall = Sessions.fk_id_cinema_hall)
                        ), 2
                    ) AS 'Средняя заполняемость (%)'
                FROM Movies
                JOIN Age_ratings ON Movies.fk_id_age_rating = Age_ratings.id_age_rating
                LEFT JOIN Sessions ON Movies.id_movie = Sessions.fk_id_movie
                LEFT JOIN Tickets ON Sessions.id_session = Tickets.fk_id_session AND Tickets.status = 1
                WHERE Movies.id_movie = {selectedId}
                GROUP BY Movies.id_movie, Movies.name, Age_ratings.age_rating, Movies.duration, Movies.rating, Movies.release_year";
            }
            else if (reportType == "3")
            {
                query = $@"SELECT 
                    Genres.genre as 'Жанр',
                    COUNT(DISTINCT Movie_Genre.id_movie) as 'Фильмов в жанре',
                    COUNT(DISTINCT Sessions.id_session) as 'Сеансов',
                    COUNT(Tickets.id_ticket) as 'Продано билетов',
                    ROUND(AVG(Movies.rating), 2) as 'Средний рейтинг',
                    SUM(Sessions.price) as 'Общая выручка'
                FROM Genres
                LEFT JOIN Movie_Genre ON Genres.id_genre = Movie_Genre.id_genre
                LEFT JOIN Movies ON Movie_Genre.id_movie = Movies.id_movie
                LEFT JOIN Sessions ON Movies.id_movie = Sessions.fk_id_movie
                LEFT JOIN Tickets ON Sessions.id_session = Tickets.fk_id_session AND Tickets.status = 1
                WHERE Genres.id_genre = {selectedId}
                GROUP BY Genres.id_genre, Genres.genre";
            }

            a = new SQLiteDataAdapter(query, sc);
            dt.Clear();
            a.Fill(dt);
        }

        private void CreateReportFile(string filepath)
        {
            if (reportType == "1")
            {
                Word.Application wrdApp = new Word.Application();
                Word.Document wrdDoc = wrdApp.Documents.Add();
                wrdDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                Word.Range range = wrdDoc.Range();

                range.InsertAfter($"Отчет по сеансам за период с {startDate:dd.MM.yyyy} по {endDate:dd.MM.yyyy}");
                range.InsertParagraphAfter();
                range.InsertAfter($"Всего сеансов: {dt.Rows.Count}");
                range.InsertParagraphAfter();
                range = wrdDoc.Range();

                Word.Table wordTable = wrdDoc.Tables.Add(range, dt.Rows.Count + 1, dt.Columns.Count);
                wordTable.Borders.Enable = 1;
                wordTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow);
                for (int column = 0; column < dt.Columns.Count; column++)
                {
                    wordTable.Cell(1, column + 1).Range.InsertAfter(dt.Columns[column].ColumnName);
                    wordTable.Cell(1, column + 1).Range.Font.Bold = 1;
                }

                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dataRow = dt.Rows[row];
                    for (int column = 0; column < dt.Columns.Count; column++)
                    {
                        string cellValue = dataRow[column].ToString();

                        if (dt.Columns[column].ColumnName == "Цена билета" ||
                            dt.Columns[column].ColumnName == "Выручка")
                        {
                            cellValue += " руб.";
                        }
                        else if (dt.Columns[column].ColumnName == "Заполняемость (%)")
                        {
                            cellValue += "%";
                        }

                        wordTable.Cell(row + 2, column + 1).Range.InsertAfter(cellValue);
                    }
                }

                wrdDoc.SaveAs(filepath);
                wrdDoc.Close();
                wrdApp.Quit();
            }
            else if (reportType == "2")
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = excelWorkbook.Sheets[1];

                excelWorksheet.Cells[1, 1] = "ОТЧЕТ ПО ФИЛЬМУ";
                excelWorksheet.Range["A1:C1"].Merge();
                excelWorksheet.Range["A1"].Font.Bold = true;
                excelWorksheet.Range["A1"].Font.Size = 14;
                excelWorksheet.Range["A1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                DataRow dataRow = dt.Rows[0];
                int currentRow = 3;

                excelWorksheet.Cells[currentRow, 1] = "Название фильма:";
                excelWorksheet.Cells[currentRow, 2] = dataRow["Название фильма"].ToString();
                currentRow++;

                excelWorksheet.Cells[currentRow, 1] = "Возрастной рейтинг:";
                excelWorksheet.Cells[currentRow, 2] = dataRow["Возрастной рейтинг"].ToString();
                currentRow++;

                excelWorksheet.Cells[currentRow, 1] = "Длительность:";
                excelWorksheet.Cells[currentRow, 2] = dataRow["Длительность (мин)"].ToString() + " мин.";
                currentRow++;

                excelWorksheet.Cells[currentRow, 1] = "Рейтинг:";
                excelWorksheet.Cells[currentRow, 2] = GetSafeDecimal(dataRow, "Рейтинг").ToString("N1") + "/10";
                currentRow++;

                excelWorksheet.Cells[currentRow, 1] = "Год выхода:";
                excelWorksheet.Cells[currentRow, 2] = GetSafeInt(dataRow, "Год выхода").ToString();
                currentRow++;

                currentRow++;

                excelWorksheet.Cells[currentRow, 1] = "Количество сеансов:";
                excelWorksheet.Cells[currentRow, 2] = dataRow["Количество сеансов"].ToString();
                currentRow++;

                excelWorksheet.Cells[currentRow, 1] = "Всего продано билетов:";
                excelWorksheet.Cells[currentRow, 2] = dataRow["Всего продано билетов"].ToString();
                currentRow++;

                excelWorksheet.Cells[currentRow, 1] = "Общая выручка:";
                excelWorksheet.Cells[currentRow, 2] = GetSafeDecimal(dataRow, "Общая выручка").ToString("N2") + " руб.";
                currentRow++;

                excelWorksheet.Cells[currentRow, 1] = "Средняя заполняемость:";
                excelWorksheet.Cells[currentRow, 2] = GetSafeDecimal(dataRow, "Средняя заполняемость (%)").ToString("N2") + "%";
                currentRow++;

                excelWorksheet.Columns[1].ColumnWidth = 25;
                excelWorksheet.Columns[2].ColumnWidth = 20;

                excelWorkbook.SaveAs(filepath);
                excelWorkbook.Close();
                excelApp.Quit();
            }
            else if (reportType == "3")
            {
                Document document = new Document(PageSize.A4.Rotate(), 20, 20, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filepath, FileMode.Create));

                document.Open();

                BaseFont baseFont = BaseFont.CreateFont(
                    @"C:\Windows\Fonts\arial.ttf",
                    BaseFont.IDENTITY_H,
                    BaseFont.EMBEDDED
                );

                PdfFont titleFont = new PdfFont(baseFont, 16, PdfFont.BOLD);
                PdfFont headerFont = new PdfFont(baseFont, 12, PdfFont.BOLD);
                PdfFont normalFont = new PdfFont(baseFont, 11, PdfFont.NORMAL);

                Paragraph title = new Paragraph($"ОТЧЕТ ПО ЖАНРУ: {selectedText}", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 25f;
                document.Add(title);

                DataRow dataRow = dt.Rows[0];

                Paragraph genreInfo = new Paragraph();
                genreInfo.Add(new Chunk("Основная информация:\n", headerFont));
                genreInfo.Add(new Chunk($"Жанр: {dataRow["Жанр"]}\n", normalFont));
                genreInfo.Add(new Chunk($"Количество фильмов: {dataRow["Фильмов в жанре"]}\n", normalFont));
                genreInfo.Add(new Chunk($"Количество сеансов: {dataRow["Сеансов"]}\n", normalFont));
                genreInfo.Add(new Chunk($"Продано билетов: {dataRow["Продано билетов"]}\n", normalFont));
                genreInfo.Add(new Chunk($"Средний рейтинг фильмов: {GetSafeDecimal(dataRow, "Средний рейтинг"):N2}/10\n", normalFont));
                genreInfo.Add(new Chunk($"Общая выручка: {GetSafeDecimal(dataRow, "Общая выручка"):N2} руб.\n", normalFont));
                genreInfo.SpacingAfter = 20f;
                document.Add(genreInfo);

                string moviesQuery = $@"SELECT 
                    Movies.name as 'Название фильма',
                    Movies.rating as 'Рейтинг',
                    Movies.release_year as 'Год выхода',
                    COUNT(DISTINCT Sessions.id_session) as 'Количество сеансов'
                FROM Movies
                JOIN Movie_Genre ON Movies.id_movie = Movie_Genre.id_movie
                LEFT JOIN Sessions ON Movies.id_movie = Sessions.fk_id_movie
                WHERE Movie_Genre.id_genre = {selectedId}
                GROUP BY Movies.id_movie
                ORDER BY Movies.rating DESC";

                DataTable moviesDt = new DataTable();
                using (SQLiteDataAdapter moviesAdapter = new SQLiteDataAdapter(moviesQuery, sc))
                {
                    moviesAdapter.Fill(moviesDt);
                }

                if (moviesDt.Rows.Count > 0)
                {
                    Paragraph moviesTitle = new Paragraph("Фильмы в данном жанре:", headerFont);
                    moviesTitle.SpacingAfter = 10f;
                    document.Add(moviesTitle);

                    PdfPTable moviesTable = new PdfPTable(4);
                    moviesTable.WidthPercentage = 100;
                    moviesTable.SpacingBefore = 10f;
                    moviesTable.SpacingAfter = 15f;

                    float[] moviesColumnWidths = new float[] { 3f, 1.5f, 1.5f, 2f };
                    moviesTable.SetWidths(moviesColumnWidths);

                    string[] movieHeaders = { "Название фильма", "Рейтинг", "Год", "Сеансов" };
                    foreach (string header in movieHeaders)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(header, headerFont));
                        cell.BackgroundColor = new BaseColor(200, 200, 200);
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.Padding = 5;
                        moviesTable.AddCell(cell);
                    }

                    foreach (DataRow movieRow in moviesDt.Rows)
                    {
                        moviesTable.AddCell(new Phrase(movieRow["Название фильма"].ToString(), normalFont));
                        moviesTable.AddCell(new Phrase(GetSafeDecimal(movieRow, "Рейтинг").ToString("N1"), normalFont));
                        moviesTable.AddCell(new Phrase(GetSafeInt(movieRow, "Год выхода").ToString(), normalFont));
                        moviesTable.AddCell(new Phrase(movieRow["Количество сеансов"].ToString(), normalFont));
                    }

                    document.Add(moviesTable);
                }

                document.Close();
                writer.Close();
            }
        }

        private string GetFileExtension()
        {
            switch (reportType)
            {
                case "1":
                    return "docx";
                case "2":
                    return "xlsx";
                case "3":
                    return "pdf";
                default:
                    return "docx";
            }
        }

        private string ShowSaveDialogInternal(string defaultFileName, string extension)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = defaultFileName;
            saveFileDialog.DefaultExt = extension;

            if (extension == "docx")
            {
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
            }
            else if (extension == "xlsx")
            {
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            }
            else if (extension == "pdf")
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            }

            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            return "CANCEL";
        }

        private void EnableControls()
        {
            Make_report.Enabled = true;
            Exit.Enabled = true;
            report_combobox.Enabled = true;
            if (StartDatePicker.Visible)
                StartDatePicker.Enabled = true;
            if (EndDatePicker.Visible)
                EndDatePicker.Enabled = true;
        }

        private async void Preview_Click(object sender, EventArgs e)
        {
            if (reportType == "1")
            {
                startDate = StartDatePicker.Value.Date;
                endDate = EndDatePicker.Value.Date.AddDays(1).AddSeconds(-1);


                if (startDate > endDate)
                {
                    MessageBox.Show("Начальная дата не может быть больше конечной!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (report_combobox.Visible && report_combobox.SelectedValue != null)
                {
                    selectedId = int.Parse(report_combobox.SelectedValue.ToString());
                    selectedText = report_combobox.Text;
                }
            }

            Preview.Enabled = false;
            await Task.Run(() => ProcessReportData());
            dataGridView1.DataSource = dt.Copy();
            Preview.Enabled = true;
        }
    }
}