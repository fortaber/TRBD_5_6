using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_1_2
{
    public partial class Form1 : Form
    {
        DataSet1 dataset1 = new BD_1_2.DataSet1();
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }
  
        private void SaveToXML()
        {
            dataset1.Doctor.AcceptChanges();
            dataset1.Doctor_appointment.AcceptChanges();
            string filePath = "Data.xml";
            dataset1.WriteXml(filePath);
        }
        private void Form1_Load()
        {

            LoadFromXML();
            dataGridView1.DataSource = dataset1.Doctor;
            dataGridView2.DataSource = dataset1.Doctor_appointment;
            dataGridView1.Sort(dataGridView1.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
            
        }

        private void LoadFromXML()
        {
            string filePath = "Data.xml";
            dataset1.Clear();
            if (!System.IO.File.Exists(filePath))
            {
                dataset1.WriteXml(filePath);
            }

            dataset1.Clear();
            dataset1.ReadXml(filePath);
        }

        private void SelectRow(DataGridView dataGrid, int bIndex)
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
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView2.DataSource != null)
            {
                dataGridView2.DataSource = dataset1.Doctor_appointment;
                (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = String.Format("fk_id_doctor = {0}", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            }

        }


        private void AddDoctor_Click(object sender, EventArgs e)
        {
            Edit_doctor Add_D = new Edit_doctor(dataset1, true);
            Add_D.ShowDialog();
            SaveToXML();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataset1.Doctor;
            SelectRowId(dataGridView1, Add_D.NewId);
        }

        private void EditDoctor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                UInt32 editId = Convert.ToUInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Edit_doctor Add_D = new Edit_doctor(dataset1, false, editId);
                Add_D.ShowDialog();
                SaveToXML();
            }
        }
        private void DeleteDoctor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show(
                    "Вы действительно хотите удалить выбранного доктора?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    UInt32 rowId = Convert.ToUInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    DataRow[] rows = dataset1.Doctor_appointment.Select($"fk_id_doctor = {rowId}");
                    if (rows.Length == 0)
                    {
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                        SaveToXML();
                        SelectRow(dataGridView1, 0);
                    }
                    else
                    {
                        MessageBox.Show("Нельзя удалить доктора с приёмами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                    }
                }
            }
        }

        private void AddAppointment_Click(object sender, EventArgs e)
        {
            Edit_appointment Add_a = new Edit_appointment(dataset1, true);
            Add_a.ShowDialog();
            SaveToXML();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = dataset1.Doctor_appointment;
            SelectRowId(dataGridView2, Add_a.NewId);
        }



        private void EditAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                UInt32 editId = Convert.ToUInt32(dataGridView2.CurrentRow.Cells[0].Value);
                Edit_appointment Add_a = new Edit_appointment(dataset1, false, editId);
                Add_a.ShowDialog();
                SaveToXML();
            }
        }

        private void DeleteAppointment_Click(object sender, EventArgs e)
        {

            if (dataGridView2.CurrentRow != null)
            {
                // Подтверждение удаления
                DialogResult result = MessageBox.Show(
                    "Вы действительно хотите удалить выбранный приём?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    UInt32 rowId = Convert.ToUInt32(dataGridView2.CurrentRow.Cells[0].Value);
                    dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                    SaveToXML();
                    SelectRow(dataGridView2, 0);
                }
            }
        }
    }
}
