using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Runtime.CompilerServices;


namespace MyDatabase
{
    public partial class Form1 : Form
    {
        const string relativePath = "Cinema.db"; // Отн. путь до БД
        string fullPath = Path.Combine(Directory.GetCurrentDirectory(), relativePath);
        public SQLiteConnection sqliteConn;

        public Form1()
        {
            InitializeComponent();
            sqliteConn = new SQLiteConnection($"Data Source={fullPath};Version=3;");
        }

        // метод для установки статуса внизу формы
        private void WriteStatus(string status)
        {
            statusBarField1.Text = status;
        }


        // подключаться только при запросе/изменении БД, не держать соед. открытым
        private void ConnectToDB_Click(object sender, EventArgs e)
        {
            try
            {
                sqliteConn.Open();
                WriteStatus("Подключение к БД выполнено успешно");
            }
            catch (Exception ex)
            {
                WriteStatus("Не удалось выполнить подключение к БД");
                File.AppendAllText("!t.txt", "\nERROR: " + ex + "\n");
            }
            finally { 
                sqliteConn.Close(); 
            }
        }

        /*public void DBSendQuery(string query) {
            try
            {
                sqliteConn.Open();
                SQLiteCommand sqlComm = sqliteConn.CreateCommand();
                sqlComm.CommandText = "SELECT * FROM Tickets";
                SQLiteDataReader reader = sqlComm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var d1 = reader.GetInt32(0);
                        var d2 = reader.GetInt32(1);
                        var d3 = reader.GetInt32(2);
                        var d4 = reader.GetInt32(3);
                        var d5 = reader.GetInt32(4);
                        var d6 = reader.GetString(5);
                        File.AppendAllText("!t.txt", d1+" "+d2+" "+d3+" "+d4+" "+d5+" "+d6 + "\n");
                    }
                }
            }
            catch (SQLiteException ex)
            {
                File.AppendAllText("!t.txt", "\nERROR: " + ex +"\n");
            }
            finally
            {
                sqliteConn.Close();
            }
        }*/

        private void OpenTableTickets_Click(object sender, EventArgs e)
        {
            // проверка что это окно таблицы уже не открыто
            bool alreadyOpened = false;
            foreach(TableForm form in this.MdiChildren)
            {
                if (form.id == 0)
                {
                    alreadyOpened = true;
                    break;
                }
            }

            if (!alreadyOpened) 
            {            
                TableForm tableForm = new TableForm(this, 0);
                tableForm.MdiParent = this;
                tableForm.Text += " Билеты";
                tableForm.Show();
                WriteStatus("Открыта таблица Билеты");
            }
        }

        private void WinsCloseAll_Click(object sender, EventArgs e)
        {
            foreach(Form form in MdiChildren)
            {
                WriteStatus("Все окна закрыты");
                form.Close();
            }
        }


        private void WinsCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
