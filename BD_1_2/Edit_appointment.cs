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
    public partial class Edit_appointment : Form
    {
        UInt32 editId;
        private DataSet1 dataset1;
        public UInt32 NewId;
        bool newAppoint;
        bool saveA = false;
        public Edit_appointment(DataSet1 dataset1, bool newAppoint, UInt32 editId = 0)
        {
            InitializeComponent();
            this.editId = editId;
            this.dataset1 = dataset1;
            this.newAppoint = newAppoint;
            LoadDoctors();
            if (!newAppoint)
            {
                this.Text = "Редактирование приёма";
                DataView dataview = dataset1.Doctor_appointment.AsDataView();
                dataview.RowFilter = $"id_appointment = {editId}";
                if (dataview.Count > 0)
                {
                    DataRowView row = dataview[0];
                    patient_full_name.Text = row["patient_full_name"].ToString();
                    if (DateTime.TryParse(row["patient_date_of_birth"].ToString(), out DateTime birthDate))
                        patient_date_of_birth.Value = birthDate;
                    string doctorId = row["fk_id_doctor"].ToString();
                    for (int i = 0; i < fk_id_doctor.Items.Count; i++)
                    {
                        string item =fk_id_doctor.Items[i].ToString();
                        if (item.StartsWith(doctorId + " - "))
                        {
                            fk_id_doctor.SelectedIndex = i;
                            break;
                        }
                    }
                    if (DateTime.TryParse(row["appointment_date"].ToString(), out DateTime appointDate))
                        appointment_date.Value = appointDate;
                    if (DateTime.TryParse(row["appointment_time"].ToString(), out DateTime timeValue))
                        appointment_time.Value = DateTime.Today.Add(timeValue.TimeOfDay);
                    appointment_report.Text = row["appointment_report"].ToString();
                }
            }
        }
        private void LoadDoctors()
        {
            fk_id_doctor.Items.Clear();
            foreach (DataRow row in dataset1.Doctor.Rows)
            {
                string id = row["id_doctor"].ToString();
                string name = row["doctor_full_name"].ToString();
                fk_id_doctor.Items.Add($"{id} - {name}");
            }

            if (fk_id_doctor.Items.Count > 0)
                fk_id_doctor.SelectedIndex = 0;
        }
        private void SaveAppoint()
        {
            if (newAppoint)
            {
                DataRow newRow = dataset1.Doctor_appointment.NewRow();
                newRow["id_appointment"] = GetNewAppointmentId();
                newRow["patient_full_name"] = patient_full_name.Text;
                newRow["patient_date_of_birth"] = patient_date_of_birth.Value.ToString("dd-MM-yyyy");
                string selectedDoctor = fk_id_doctor.SelectedItem.ToString();
                string doctorId = selectedDoctor.Split('-')[0].Trim();
                newRow["fk_id_doctor"] = doctorId;
                newRow["appointment_date"] = appointment_date.Value.ToString("dd-MM-yyyy");
                newRow["appointment_report"] = appointment_report.Text;
                newRow["appointment_time"] = appointment_time.Value.ToString("HH:mm");  
                dataset1.Doctor_appointment.Rows.Add(newRow);
                dataset1.Doctor_appointment.AcceptChanges();
                NewId = Convert.ToUInt32(newRow["id_appointment"].ToString());

            }
            else
            {
                DataRow[] rows = dataset1.Doctor_appointment.Select($"id_appointment = {editId}");
                if (rows.Length > 0)
                {
                    rows[0]["patient_full_name"] = patient_full_name.Text;
                    rows[0]["patient_date_of_birth"] = patient_date_of_birth.Value.ToString("dd-MM-yyyy");
                    string selectedDoctor = fk_id_doctor.SelectedItem.ToString();
                    string doctorId = selectedDoctor.Split('-')[0].Trim();
                    rows[0]["fk_id_doctor"] = doctorId;
                    rows[0]["appointment_date"] = appointment_date.Value.ToString("dd-MM-yyyy");
                    rows[0]["appointment_time"] = appointment_time.Value.ToString("HH:mm");
                    rows[0]["appointment_report"] = appointment_report.Text;
                    dataset1.Doctor_appointment.AcceptChanges();
                    NewId = editId;
                }
            }
        }

        private UInt32 GetNewAppointmentId()
        {
            if (dataset1.Doctor_appointment.Rows.Count == 0)
                return 1;
            return Convert.ToUInt32(dataset1.Doctor_appointment.AsEnumerable()
                .Max(row => row.Field<UInt32>("id_appointment"))) + 1;
        }
        private void AppointValidating()
        {
            saveA = false;
            string FillingErrors = "";

            if (patient_full_name.Text == "") FillingErrors = "ФИО пациента не заполнено.\n";
            else if (patient_full_name.Text.Trim().Split(' ').Length < 2)
                FillingErrors = FillingErrors + "ФИО пациента должно содержать фамилию и имя.\n";
            else if (patient_full_name.Text.Length > 60)
                FillingErrors = FillingErrors + "ФИО пациента не может быть больше 60 символов.\n";
            else
            {
                foreach (char c in patient_full_name.Text)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        FillingErrors = FillingErrors + "ФИО пациента заполнено неправильно.\n";
                        break;
                    }
                }
            }


            if (patient_date_of_birth.Value > DateTime.Now)
                FillingErrors += "Дата рождения пациента не может быть больше текущей даты.\n";
            else if (patient_date_of_birth.Value < DateTime.Now.AddYears(-101))
            {
                FillingErrors += "Пациент не может быть старше 100 лет.\n";
            }

            if (fk_id_doctor.SelectedItem == null)
                FillingErrors = FillingErrors + "Доктор не выбран.\n";

            if (appointment_date.Value <patient_date_of_birth.Value)
            {
                FillingErrors += "Дата рождения пациента не может быть раньше приёма.\n";
            }
            else if (appointment_date.Value < DateTime.Now.AddYears(-26))
            {
                FillingErrors += "Дата приёма не может быть раньше 2000 года";
            }
            if (appointment_report.Text == "") FillingErrors = FillingErrors + "Отчёт о приёме не заполнен.\n";
            else if (appointment_report.Text.Length > 100)
                FillingErrors = FillingErrors + "Отчёт о приёме не может превышать 100 символов.\n";



            if (FillingErrors != "")
            {
                MessageBox.Show(FillingErrors, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                saveA = true;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            saveA = false;
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            AppointValidating();
            if (!saveA)
            {
                SaveAppoint();
                this.Close();
            }
        }

        private void Edit_appointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = saveA;
        }

        private void Edit_appointment_Load(object sender, EventArgs e)
        {
        }
    }
}
