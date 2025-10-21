using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;


namespace MyDatabase
{
    public partial class TableForm : Form
    {
        public string tableNameDB;
        private SQLiteConnection sqliteConn = new SQLiteConnection();
        private SQLiteDataAdapter adapter;
        private SQLiteCommand command = new SQLiteCommand();
        private DataTable dt = new DataTable();

        int CurrentIndex = 0;

        public TableForm(string connString, string tableName)
        {
            InitializeComponent();
            this.sqliteConn.ConnectionString = connString;
            this.Name = tableName;
            this.Text += tableName;
            addColumns(tableName);
        }

        void addColumns(string tableName)
        {
            string query;
            switch (tableName)
            {
                case "Билеты":
                    //"ID", "Номер сеанса", "Номер места", "Номер покупателя", "Куплен", "Дата покупки";
                    query = "SELECT * from Tickets";
                    // сложный запрос пока легче заняться простыми
                    tableNameDB = "Tickets";
                    break;
                case "Кинозалы":
                    query = "SELECT id_cinema_hall, hall_type AS \"Тип зала\", row_number AS \"Кол-во рядов\", " +
                            "seat_number_in_row AS \"Кол-во мест в ряду\", available AS \"Доступен\"" +
                            "FROM [Cinema Halls] INNER JOIN Hall_types ON id_hall_type == fk_id_hall_type";
                    tableNameDB = "Cinema Halls";
                    break;
                case "Клиенты":
                    query = "SELECT id_client, client_full_name AS \"ФИО\", client_date_of_birth AS \"Дата рождения\"," +
                            "phone AS \"Телефон\", email AS \"эл.почта\" FROM Clients";
                    tableNameDB = "Clients";
                    break;
                default:
                    this.Close();
                    return;
            }

            // автозаполнение таблицы
            var adapter = new SQLiteDataAdapter(query, sqliteConn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            // скрытие столбцов с id
            switch (tableName)
            {
                case "Билеты":
                    dataGridView1.Columns["id_ticket"].Visible = false;
                    break;
                case "Кинозалы":
                    dataGridView1.Columns["id_cinema_hall"].Visible = false;
                    break;
                case "Клиенты":
                    dataGridView1.Columns["id_client"].Visible = false;
                    break;
                default:
                    this.Close();
                    return;
            }
        }

        //private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dataGridView1.CurrentCell != null && dataGridView2.DataSource != null)
        //    {
        //        dataGridView2.DataSource = dataset1.Doctor_appointment;
        //        (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = String.Format("fk_id_doctor = {0}", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
        //    }
        //}


        //private void AddDoctor_Click(object sender, EventArgs e)
        //{
        //    Edit_doctor Add_D = new Edit_doctor(dataset1, true);
        //    Add_D.ShowDialog();
        //    SaveToXML();
        //    dataGridView1.DataSource = null;
        //    dataGridView1.DataSource = dataset1.Doctor;
        //    SelectRowId(dataGridView1, Add_D.NewId);
        //}

        //private void EditDoctor_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.CurrentRow != null)
        //    {
        //        UInt32 editId = Convert.ToUInt32(dataGridView1.CurrentRow.Cells[0].Value);
        //        Edit_doctor Add_D = new Edit_doctor(dataset1, false, editId);
        //        Add_D.ShowDialog();
        //        SaveToXML();
        //    }
        //}


        //private void AddAppointment_Click(object sender, EventArgs e)
        //{
        //    Edit_appointment Add_a = new Edit_appointment(dataset1, true);
        //    Add_a.ShowDialog();
        //    SaveToXML();
        //    dataGridView2.DataSource = null;
        //    dataGridView2.DataSource = dataset1.Doctor_appointment;
        //    SelectRowId(dataGridView2, Add_a.NewId);
        //}



        //private void EditAppointment_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView2.CurrentRow != null)
        //    {
        //        UInt32 editId = Convert.ToUInt32(dataGridView2.CurrentRow.Cells[0].Value);
        //        Edit_appointment Add_a = new Edit_appointment(dataset1, false, editId);
        //        Add_a.ShowDialog();
        //        SaveToXML();
        //    }
        //}

        //private void DeleteAppointment_Click(object sender, EventArgs e)
        //{

        //    if (dataGridView2.CurrentRow != null)
        //    {
        //        // Подтверждение удаления
        //        DialogResult result = MessageBox.Show(
        //            "Вы действительно хотите удалить выбранный приём?",
        //            "Подтверждение удаления",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Question,
        //            MessageBoxDefaultButton.Button2);
        //        if (result == DialogResult.Yes)
        //        {
        //            UInt32 rowId = Convert.ToUInt32(dataGridView2.CurrentRow.Cells[0].Value);
        //            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        //            SaveToXML();
        //            SelectRow(dataGridView2, 0);
        //        }
        //    }
        //}

        /*private void SelectRow(DataGridView dataGrid, int bIndex)
        {
            if (bIndex >= 0 && bIndex < dataGrid.Rows.Count)
            {
                dataGrid.CurrentCell = dataGrid.Rows[bIndex].Cells[2];
                dataGrid.Rows[bIndex].Selected = true;
                dataGrid.FirstDisplayedScrollingRowIndex = bIndex;
            }
        }

        private void SelectRowId(DataGridView dataGrid, UInt32 id)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == id)
                {
                    dataGrid.CurrentCell = row.Cells[2];
                    row.Selected = true;
                    dataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
        }*/

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show(
                    "Вы действительно хотите удалить выбранную запись?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    UInt32 rowId = Convert.ToUInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    //DataRow[] rows = parentForm.sqliteConn.CreateCommand("SELECT что-то там");
                    /*if (rows.Length == 0)
                    {
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                        SaveToXML();
                        SelectRow(dataGridView1, 0);
                    }
                    else
                    {
                        MessageBox.Show("Нельзя удалить доктора с приёмами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                    }*/
                }
            }
        }
    }
}
