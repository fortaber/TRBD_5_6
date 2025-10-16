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
    public partial class Edit_doctor : Form
    {
        UInt32 editId;
        private DataSet1 dataset1;
        public UInt32 NewId;
        bool newDoctor;
        bool saveD = false;
        public Edit_doctor(DataSet1 dataset1, bool newDoctor, UInt32 editId = 0)
        {
            InitializeComponent();
            this.editId = editId;
            this.dataset1 = dataset1;
            this.newDoctor = newDoctor;
            if (!newDoctor)
            {
                this.Text = "Редактирование доктора";
                DataView dataview = dataset1.Doctor.AsDataView();
                dataview.RowFilter = $"id_doctor = {editId}";
                if (dataview.Count > 0)
                {
                    DataRowView row = dataview[0];
                    doctor_full_name.Text = row["doctor_full_name"].ToString();
                    if (DateTime.TryParse(row["date_of_birth"].ToString(), out DateTime birthDate))
                        date_of_birth.Value = birthDate;
                    id_department.SelectedItem = row["id_department"].ToString();
                    id_position.SelectedItem = row["id_position"].ToString();
                    string genderValue = row["gender"].ToString().ToLower();
                    if (genderValue == "м" || genderValue == "муж" || genderValue == "мужской")
                        gender.SelectedItem = "Мужской";
                    else if (genderValue == "ж" || genderValue == "жен" || genderValue == "женский")
                        gender.SelectedItem = "Женский";
                    else
                        gender.SelectedIndex = 0;
                }
            }
        }
        private void SaveDoctor()
        {
            if (newDoctor)
            {
                DataRow newRow = dataset1.Doctor.NewRow();
                newRow["id_doctor"] = GetNewDoctorId();
                newRow["doctor_full_name"] = doctor_full_name.Text;
                newRow["date_of_birth"] = date_of_birth.Value.ToString("dd-MM-yyyy");
                newRow["id_department"] = id_department.SelectedItem.ToString();
                newRow["id_position"] = id_position.SelectedItem.ToString();
                newRow["gender"] = gender.SelectedItem.ToString();
                dataset1.Doctor.Rows.Add(newRow);
                dataset1.Doctor.AcceptChanges();
                NewId = Convert.ToUInt32(newRow["id_doctor"].ToString());

            }
            else
            {
                DataRow[] rows = dataset1.Doctor.Select($"id_doctor = {editId}");
                if (rows.Length > 0)
                {
                    rows[0]["doctor_full_name"] = doctor_full_name.Text;
                    rows[0]["date_of_birth"] = date_of_birth.Value.ToString("dd-MM-yyyy");
                    rows[0]["id_department"] = id_department.SelectedItem.ToString();
                    rows[0]["id_position"] = id_position.SelectedItem.ToString();
                    rows[0]["gender"] = gender.SelectedItem.ToString();
                    rows[0]["gender"] = gender.Text;
                    dataset1.Doctor.AcceptChanges();
                    NewId = editId;
                }
            }
        }

        private UInt32 GetNewDoctorId()
        {
            if (dataset1.Doctor.Rows.Count == 0)
                return 1;
            return Convert.ToUInt32(dataset1.Doctor.AsEnumerable()
                .Max(row => row.Field<UInt32>("id_doctor"))) + 1;
        }
        private void DoctorValidating()
        {
            saveD = false;
            string FillingErrors = "";

            if (doctor_full_name.Text == "") FillingErrors = "ФИО доктора не заполнено.\n";
            else if (doctor_full_name.Text.Trim().Split(' ').Length < 2) FillingErrors += "ФИО доктора должно содержать как минимум фамилию и имя.\n";
            else if (doctor_full_name.Text.Length > 60) FillingErrors += "ФИО доктора не может быть длиннее 60 символов";
            else
            {
                foreach (char c in doctor_full_name.Text)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        FillingErrors = FillingErrors + "ФИО доктора заполнено неправильно.\n";
                        break;
                    }
                }
            }

            if (date_of_birth.Value > DateTime.Now)
                FillingErrors += "Дата рождения не может быть больше текущей даты.\n";
            else if (date_of_birth.Value > DateTime.Now.AddYears(-18))
                FillingErrors += "Доктор не может быть младше 18 лет.\n";
            else if (date_of_birth.Value < DateTime.Now.AddYears(-101))
                    {
                FillingErrors += "Доктор не может быть старше 100 лет.\n";
            }
            if (id_department.SelectedItem == null)
                FillingErrors = FillingErrors + "Подразделение не выбрано.\n";

            if (id_position.SelectedItem == null)
                FillingErrors = FillingErrors + "Должность не выбрана.\n";



            if (gender.SelectedItem == null)
                FillingErrors = FillingErrors + "Пол не выбран.\n";


            if (FillingErrors != "")
            {
                MessageBox.Show(FillingErrors, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                saveD = true;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            saveD = false;
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DoctorValidating();
            if (!saveD)
            {
                SaveDoctor();
                this.Close();
            }
        }

        private void Edit_doctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = saveD;
        }

        private void Edit_doctor_Load(object sender, EventArgs e)
        {
        }



    }
}
