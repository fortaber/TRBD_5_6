using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDatabase
{
    public partial class TableForm : Form
    {
        // у каждой таблицы свой id для запрета открытия одинаковых таблиц
        // задается в конструторе
        // "билет" = 0, "Сеанс" = 1, ...
        public int id;
        Form1 parentForm;

        public TableForm(Form1 form, int id)
        {
            InitializeComponent();
            this.parentForm = form;
            this.id = id;
            addColumns(id);
        }

        void addColumns(int id)
        {
            string[] colNames;
            string query;
            switch (id)
            {
                case 0:
                    colNames = new string[] { "ID", "Номер сеанса", "Номер места", "Номер покупателя", "Куплен", "Дата покупки"};
                    query = "SELECT * from Tickets";
                    break;
                default:
                    this.Close();
                    return;
            }

            // авто заполнение таблицы
            var dataAdapter = new SQLiteDataAdapter(query, parentForm.sqliteConn);
            BindingSource bindingSource1 = new BindingSource();
            dataGridView1.DataSource = bindingSource1;
            {
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            dataGridView1.Columns[0].Visible = false; // скрыть 1й столбец с ID
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].HeaderText = colNames[i];
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
