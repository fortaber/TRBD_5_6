using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using BD_1_2;

namespace MyDatabase
{
    public partial class Form1 : Form
    {
        const string relativePath = "Cinema.db";
        string fullPath = Path.Combine(Directory.GetCurrentDirectory(), relativePath);
        public SQLiteConnection sqliteConn;
        private string connString;
        private bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
            connString = $"Data Source={fullPath};Version=3;";
            sqliteConn = new SQLiteConnection(connString);
            UpdateConnectionStatus();
            OpenMoviesTable.Click += OpenTable_Click;
            OpenSessionsTable.Click += OpenTable_Click;
            OpenTicketsTable.Click += OpenTable_Click;
            OpenClientsTable.Click += OpenTable_Click;
            OpenCinemaHallsTable.Click += OpenTable_Click;
            OpenSeatsTable.Click += OpenTable_Click;
            OpenAgeRatingsTable.Click += OpenTable_Click;
            OpenHallTypesTable.Click += OpenTable_Click;
            OpenGenresTable.Click += OpenTable_Click;
            OpenMovieGenreTable.Click += OpenTable_Click;
        }
        public string StatusText
        {
            get => statusBarField1.Text;
            set => statusBarField1.Text = value;
        }
        public void WriteStatus(string status)
        {
            statusBarField1.Text = status;
        }

        public SQLiteConnection GetConnection()
        {
            return sqliteConn;
        }

        private void UpdateConnectionStatus()
        {
            OpenMoviesTable.Enabled = isConnected;
            OpenSessionsTable.Enabled = isConnected;
            OpenTicketsTable.Enabled = isConnected;
            OpenClientsTable.Enabled = isConnected;
            OpenCinemaHallsTable.Enabled = isConnected;
            OpenSeatsTable.Enabled = isConnected;
            OpenAgeRatingsTable.Enabled = isConnected;
            OpenHallTypesTable.Enabled = isConnected;
            OpenGenresTable.Enabled = isConnected;
            OpenMovieGenreTable.Enabled = isConnected;
            ReportWord.Enabled = isConnected;
            ReportExcel.Enabled = isConnected;
            ReportPDF.Enabled = isConnected;
            ConnectToDB.Enabled = !isConnected;
            CloseConnection.Enabled = isConnected;
        }

        private void ConnectToDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqliteConn.State != ConnectionState.Open)
                {
                    sqliteConn.Open();
                }
                isConnected = true;
                WriteStatus("Подключение к БД выполнено успешно");
                UpdateConnectionStatus();
            }
            catch (Exception ex)
            {
                isConnected = false;
                WriteStatus("Не удалось выполнить подключение к БД");
                MessageBox.Show($"Ошибка подключения к БД: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenTable_Click(object sender, EventArgs e)
        {

            string table = (sender as ToolStripMenuItem).Text;

            bool alreadyOpened = false;
            foreach (TableForm form in this.MdiChildren)
            {
                if (form.Name == table)
                {
                    alreadyOpened = true;
                    break;
                }
            }

            if (!alreadyOpened)
            {
                TableForm tableForm = new TableForm(sqliteConn, table);
                tableForm.MdiParent = this;
                tableForm.Show();
                WriteStatus("Открыта таблица " + table);
            }
        }

        private void WinsCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
            WriteStatus("Все окна закрыты");
        }

        private void WinsCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (sqliteConn.State == ConnectionState.Open)
            {
                sqliteConn.Close();
            }
            this.Close();
        }

        private void WinsHorisontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void WinsVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void ReportWord_Click(object sender, EventArgs e)
        {

            Report rep = new Report(1, sqliteConn, this);
            rep.Text = "Сеансы";
            rep.Show();
        }

        private void ReportExcel_Click(object sender, EventArgs e)
        {

            Report rep = new Report(2, sqliteConn, this);
            rep.Text = "Фильмы";
            rep.Show();
        }

        private void ReportPDF_Click(object sender, EventArgs e)
        {
            Report rep = new Report(3, sqliteConn, this);
            rep.Text = "Жанры";
            rep.Show();


        }

        private void CloseConnection_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in MdiChildren)
                {
                    form.Close();
                }

                if (sqliteConn.State == ConnectionState.Open)
                {
                    sqliteConn.Close();
                }

                isConnected = false;
                WriteStatus("Отключение от БД выполнено успешно");
                UpdateConnectionStatus();
            }
            catch (Exception ex)
            {
                WriteStatus("Ошибка при отключении от БД");
                MessageBox.Show($"Ошибка отключения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}