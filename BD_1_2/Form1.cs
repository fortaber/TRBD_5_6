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
        private string connString;

        public Form1()
        {
            InitializeComponent();
            connString = $"Data Source={fullPath};Version=3;";
            sqliteConn = new SQLiteConnection(connString);
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

        private void OpenTable_Click(object sender, EventArgs e)
        {
            string table = (sender as ToolStripMenuItem).Text;

            // проверка что это окно таблицы уже не открыто
            bool alreadyOpened = false;
            foreach(TableForm form in this.MdiChildren)
            {
                if (form.Name == table)
                {
                    alreadyOpened = true;
                    break;
                }
            }

            if (!alreadyOpened) 
            {            
                TableForm tableForm = new TableForm(connString, table);
                tableForm.MdiParent = this;
                tableForm.Show();
                WriteStatus("Открыта таблица " + table);
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

        private void WinsHorisontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void WinsVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
