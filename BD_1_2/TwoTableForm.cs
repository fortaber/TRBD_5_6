using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using BD_1_2;

namespace MyDatabase
{
    public partial class TwoTableForm : Form
    {
        public string table1NameDB;
        public string table2NameDB;
        private SQLiteConnection sqliteConn;
        private SQLiteCommand command = new SQLiteCommand();
        private DataTable dt1 = new DataTable();
        private DataTable dt2 = new DataTable();
        private DataTable dt1Original = new DataTable();
        private DataTable dt2Original = new DataTable();
        private string query1;
        private string query2;
        int CurrentIndex = 0;

        public TwoTableForm(SQLiteConnection connection, string table1Name, string table2Name)
        {
            InitializeComponent();
            if (connection == null || connection.State != ConnectionState.Open)
            {
                MessageBox.Show("Нет подключения к базе данных!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            using (var cmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", connection))
            {
                cmd.ExecuteNonQuery();
            }
            this.sqliteConn = connection;
            this.Name = table1Name;
            this.Text += table1Name;
            addColumns(table1Name);
        }

        void addColumns(string tableName)
        {
            switch (tableName)
            {
                case "Билеты":
                    query1 = @"SELECT 
                Tickets.id_ticket as 'ID',
                Movies.name as 'Фильм',
                Sessions.date_session as 'Дата сеанса',
                Sessions.start_time as 'Время начала',
                Sessions.id_session as 'Номер сеанса',
                Seats.row as 'Ряд',
                Seats.seat_in_row as 'Место',
                Clients.client_full_name as 'Клиент',
                Tickets.buy_date as 'Дата покупки',
                CASE WHEN Tickets.status = 1 THEN 'Куплен' ELSE 'Не куплен' END as 'Статус'
            FROM Tickets
            LEFT JOIN Sessions ON Tickets.fk_id_session = Sessions.id_session
            LEFT JOIN Movies ON Sessions.fk_id_movie = Movies.id_movie
            LEFT JOIN Seats ON Tickets.fk_id_seat = Seats.id_seat
            LEFT JOIN Clients ON Tickets.fk_id_client = Clients.id_client
            ORDER BY Tickets.id_ticket";

                    query2 = @"SELECT 
                Clients.id_client as 'ID',
                Clients.client_full_name as 'ФИО',
                Clients.client_date_of_birth as 'Дата рождения',
                Clients.phone as 'Телефон',
                Clients.email as 'эл.почта'
            FROM Clients
            ORDER BY Clients.id_client";
                    table1NameDB = "Tickets";
                    table2NameDB = "Clients";
                    break;
                    /*
                case "Кинозалы":
                    query1 = @"SELECT 
                Cinema_Halls.id_cinema_hall as 'Номер зала',
                Hall_types.hall_type as 'Тип зала',
                Cinema_Halls.row_number as 'Кол-во рядов',
                Cinema_Halls.seat_number_in_row as 'Кол-во мест в ряду',
                CASE WHEN Cinema_Halls.available = 1 THEN 'Доступен' ELSE 'Не доступен' END as 'Доступен'
            FROM Cinema_Halls
            INNER JOIN Hall_types ON Cinema_Halls.fk_id_hall_type = Hall_types.id_hall_type
            ORDER BY Cinema_Halls.id_cinema_hall";
                    table1NameDB = "Cinema_Halls";
                    break;

                case "Клиенты":
                    query1 = @"SELECT 
                Clients.id_client as 'ID',
                Clients.client_full_name as 'ФИО',
                Clients.client_date_of_birth as 'Дата рождения',
                Clients.phone as 'Телефон',
                Clients.email as 'эл.почта'
            FROM Clients
            ORDER BY Clients.id_client";
                    table1NameDB = "Clients";
                    break;

                case "Фильмы":
                    query1 = @"SELECT 
                Movies.id_movie as 'ID',
                Movies.name as 'Название фильма',
                Age_ratings.age_rating as 'Возрастной рейтинг',
                Movies.duration as 'Длительность (мин)',
                Movies.release_year as 'Год выхода',
                Movies.rating as 'Рейтинг'
            FROM Movies
            LEFT JOIN Age_ratings ON Movies.fk_id_age_rating = Age_ratings.id_age_rating
            ORDER BY Movies.name";
                    table1NameDB = "Movies";
                    break;

                case "Сеансы":
                    query1 = @"SELECT 
                Sessions.id_session as 'Номер сеанса',
                Movies.name as 'Название фильма',
                Cinema_Halls.id_cinema_hall as 'Номер зала',
                Sessions.date_session as 'Дата сеанса',
                Sessions.start_time as 'Время начала',
                Sessions.price as 'Цена билета',
                Sessions.report as 'Отчет'
            FROM Sessions
            LEFT JOIN Movies ON Sessions.fk_id_movie = Movies.id_movie
            LEFT JOIN Cinema_Halls ON Sessions.fk_id_cinema_hall = Cinema_Halls.id_cinema_hall
            ORDER BY Sessions.date_session, Sessions.start_time";
                    table1NameDB = "Sessions";
                    break;

                case "Места":
                    query1 = @"SELECT 
                Seats.id_seat as 'ID',
                Cinema_Halls.id_cinema_hall as 'Номер зала',
                Seats.row as 'Ряд',
                Seats.seat_in_row as 'Место'
            FROM Seats
            LEFT JOIN Cinema_Halls ON Seats.fk_id_cinema_hall = Cinema_Halls.id_cinema_hall
            ORDER BY Cinema_Halls.id_cinema_hall, Seats.row, Seats.seat_in_row";
                    table1NameDB = "Seats";
                    break;

                case "Возрастные рейтинги":
                    query1 = @"SELECT 
                Age_ratings.id_age_rating as 'ID',
                Age_ratings.age_rating as 'Возрастной рейтинг',
                Age_ratings.min_age as 'Мин. возраст'
            FROM Age_ratings
            ORDER BY Age_ratings.id_age_rating";
                    table1NameDB = "Age_ratings";
                    break;

                case "Типы залов":
                    query1 = @"SELECT 
                Hall_types.id_hall_type as 'ID',
                Hall_types.hall_type as 'Тип зала'
            FROM Hall_types
            ORDER BY Hall_types.id_hall_type";
                    table1NameDB = "Hall_types";
                    break;

                case "Жанры":
                    query1 = @"SELECT 
                Genres.id_genre as 'ID',
                Genres.genre as 'Название жанра'
            FROM Genres
            ORDER BY Genres.genre";
                    table1NameDB = "Genres";
                    break;

                case "Фильмы-Жанры":
                    query1 = @"SELECT 
                Movie_Genre.id_movie as 'ID фильма',
                Movies.name as 'Фильм',
                Movie_Genre.id_genre as 'ID жанра',
                Genres.genre as 'Жанр'
            FROM Movie_Genre
            LEFT JOIN Movies ON Movie_Genre.id_movie = Movies.id_movie
            LEFT JOIN Genres ON Movie_Genre.id_genre = Genres.id_genre
            ORDER BY Movies.name, Genres.genre";
                    table1NameDB = "Movie_Genre";
                    break;*/

                default:
                    this.Close();
                    return;
            }

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dt1.Clear();
                dt2.Clear();
                dt1Original.Clear();
                dt2Original.Clear();

                SQLiteDataAdapter adapter;
                adapter = new SQLiteDataAdapter(query1, sqliteConn);
                adapter.Fill(dt1);
                adapter.Fill(dt1Original);

                adapter = new SQLiteDataAdapter(query2, sqliteConn);
                adapter.Fill(dt2);
                adapter.Fill(dt2Original);

                dataGridView1.DataSource = dt1;
                dataGridView2.DataSource = dt2;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.Name == "ID" ||
                        column.Name == "ID фильма" ||
                        column.Name == "ID жанра" ||
                        column.Name == "Зал")
                    {
                        column.Visible = false;
                    }
                }
                foreach (DataGridViewColumn column in dataGridView2.Columns)
                {
                    if (column.Name == "ID" ||
                        column.Name == "ID фильма" ||
                        column.Name == "ID жанра" ||
                        column.Name == "Зал")
                    {
                        column.Visible = false;
                    }
                }

                InitializeSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void InitializeSearch()
        {
            search_field_combobox1.Items.Clear();
            search_field_combobox2.Items.Clear();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
                if (column.Visible)
                    search_field_combobox1.Items.Add(column.HeaderText);

            foreach (DataGridViewColumn column in dataGridView2.Columns)
                if (column.Visible)
                    search_field_combobox2.Items.Add(column.HeaderText);

            if (search_field_combobox1.Items.Count > 0)
                search_field_combobox1.SelectedIndex = 0;

            if (search_field_combobox2.Items.Count > 0)
                search_field_combobox2.SelectedIndex = 0;
        }

        private void ApplySearchFilter()
        {
            if (dt1Original.Rows.Count == 0) return;

            string searchText = search_textbox1.Text.Trim();
            string selectedField = search_field_combobox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(searchText) || string.IsNullOrEmpty(selectedField))
            {
                ShowAllData();
                MessageBox.Show("Введите текст для поиска", "Поиск",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dt1.Rows.Clear();
            foreach (DataRow row in dt1Original.Rows)
            {
                string cellValue = row[selectedField]?.ToString() ?? "";
                if (cellValue.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    dt1.ImportRow(row);
                }
            }

            if (dt1.Rows.Count == 0)
            {
                MessageBox.Show("Ничего не найдено", "Поиск",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowAllData()
        {
            dt1.Rows.Clear();
            dt2.Rows.Clear();
            foreach (DataRow row in dt1Original.Rows)
                dt1.ImportRow(row);

            foreach (DataRow row in dt2Original.Rows)
                dt2.ImportRow(row);
        }

        private void InsTable_Click(object sender, EventArgs e) // зависит от sender
        {
            string btnName = (sender as ToolStripButton).Name;
            InsEdit editForm = new InsEdit(sqliteConn, btnName == "InsTable1"? table1NameDB : table2NameDB, null, true);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void EditTable_Click(object sender, EventArgs e) // зависит от sender
        {
            string btnName = (sender as ToolStripButton).Name;
            string TableName = btnName == "EditTable1" ? table1NameDB : table2NameDB;
            DataGridView dataGridView = btnName == "EditTable1" ? dataGridView1 : dataGridView1;
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для редактирования");
                return;
            }
            string idColName = "ID";
            if (TableName == "Cinema_Halls")
                idColName = "Номер зала";
            else if (TableName == "Sessions")
                idColName = "Номер сеанса";

            InsEdit editForm;
            int[] id = { 0 };
            id[0] = Convert.ToInt32(dataGridView.CurrentRow.Cells[idColName].Value);
            editForm = new InsEdit(sqliteConn, TableName, id, false);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadData(); 
            }
        }

        private void DelTable_Click(object sender, EventArgs e) // TODO: зависит от sender
        {
            string btnName = (sender as ToolStripButton).Name;
            string tableName = btnName == "DelTable1" ? table1NameDB : table2NameDB;
            DataGridView dataGridView = btnName == "DelTable1" ? dataGridView1 : dataGridView1;
            DataTable dt = btnName == "DelTable1" ? dt1 : dt2;

            if (dataGridView.RowCount == 0)
            {
                MessageBox.Show("Нет данных для удаления"); return;
            }
            if (dataGridView.RowCount != 0 && dataGridView.CurrentRow.Index != 0)
            {
                CurrentIndex = dataGridView.CurrentRow.Index - 1;
            }
            try
            {
                DialogResult result = MessageBox.Show(
                                   "Вы действительно хотите удалить запись?",
                                   "Подтверждение удаления",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dt.Rows[dataGridView.CurrentRow.Index][0]);

                    if (tableName == "Movie_Genre")
                    {
                        int movieId = Convert.ToInt32(dt.Rows[dataGridView.CurrentRow.Index][0]);
                        int genreId = Convert.ToInt32(dt.Rows[dataGridView.CurrentRow.Index][2]);
                        command = new SQLiteCommand(
                            $"DELETE FROM [Movie_Genre] WHERE [id_movie] = {movieId} AND [id_genre] = {genreId}",
                            sqliteConn);
                    }
                    else
                    {
                        string idColumnName = GetIdColumnName(tableName);
                        command = new SQLiteCommand($"DELETE FROM [{tableName}] WHERE [{idColumnName}] = {id}", sqliteConn);

                    }
                    command.ExecuteNonQuery();

                    LoadData();
                }
            }
            catch (SQLiteException ex) when (ex.ErrorCode == (int)SQLiteErrorCode.Constraint)
            {
                MessageBox.Show("Невозможно удалить запись: существуют связанные данные в других таблицах",
    "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            if (dataGridView.RowCount != 0)
            {
                dataGridView.CurrentCell =
                    dataGridView.Rows[CurrentIndex].Cells[dataGridView.ColumnCount - 1];
            }

        }
        private string GetIdColumnName(string tableName)
        {
            switch (tableName)
            {
                case "Tickets": return "id_ticket";
                case "Cinema_Halls": return "id_cinema_hall";
                case "Clients": return "id_client";
                case "Movies": return "id_movie";
                case "Sessions": return "id_session";
                case "Seats": return "id_seat";
                case "Age_ratings": return "id_age_rating";
                case "Hall_types": return "id_hall_type";
                case "Genres": return "id_genre";
                case "Movie_Genre": return "id_movie";
                default: return "id";
            }
        }

        private void CloseTable_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            search_textbox1.Text = "";
            search_textbox2.Text = "";
            LoadData();
            MessageBox.Show("Данные обновлены", "Обновление",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void search_btn_Click_1(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void search_btn2_Click(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}