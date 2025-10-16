namespace BD_1_2
{
    partial class Edit_appointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.patient_full_name = new System.Windows.Forms.TextBox();
            this.appointment_report = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.patient_date_of_birth = new System.Windows.Forms.DateTimePicker();
            this.appointment_date = new System.Windows.Forms.DateTimePicker();
            this.appointment_time = new System.Windows.Forms.DateTimePicker();
            this.fk_id_doctor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО пациента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(45, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Код врача";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(45, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Дата приёма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(45, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Время приёма (ЧЧ:ММ)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(45, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Отчёт о приёме";
            // 
            // patient_full_name
            // 
            this.patient_full_name.Location = new System.Drawing.Point(283, 42);
            this.patient_full_name.Name = "patient_full_name";
            this.patient_full_name.Size = new System.Drawing.Size(192, 20);
            this.patient_full_name.TabIndex = 1;
            // 
            // appointment_report
            // 
            this.appointment_report.Location = new System.Drawing.Point(283, 293);
            this.appointment_report.Name = "appointment_report";
            this.appointment_report.Size = new System.Drawing.Size(192, 20);
            this.appointment_report.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(154, 358);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(150, 60);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Отменить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(405, 358);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(150, 60);
            this.Save.TabIndex = 3;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // patient_date_of_birth
            // 
            this.patient_date_of_birth.Location = new System.Drawing.Point(283, 96);
            this.patient_date_of_birth.Name = "patient_date_of_birth";
            this.patient_date_of_birth.Size = new System.Drawing.Size(192, 20);
            this.patient_date_of_birth.TabIndex = 4;
            this.patient_date_of_birth.Value = new System.DateTime(2025, 10, 1, 14, 7, 59, 0);
            // 
            // appointment_date
            // 
            this.appointment_date.Location = new System.Drawing.Point(283, 198);
            this.appointment_date.Name = "appointment_date";
            this.appointment_date.Size = new System.Drawing.Size(192, 20);
            this.appointment_date.TabIndex = 5;
            this.appointment_date.Value = new System.DateTime(2025, 10, 1, 14, 7, 45, 0);
            // 
            // appointment_time
            // 
            this.appointment_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.appointment_time.Location = new System.Drawing.Point(283, 248);
            this.appointment_time.Name = "appointment_time";
            this.appointment_time.ShowUpDown = true;
            this.appointment_time.Size = new System.Drawing.Size(192, 20);
            this.appointment_time.TabIndex = 6;
            // 
            // fk_id_doctor
            // 
            this.fk_id_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fk_id_doctor.FormattingEnabled = true;
            this.fk_id_doctor.Location = new System.Drawing.Point(283, 148);
            this.fk_id_doctor.Name = "fk_id_doctor";
            this.fk_id_doctor.Size = new System.Drawing.Size(192, 21);
            this.fk_id_doctor.TabIndex = 7;
            // 
            // Edit_appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.fk_id_doctor);
            this.Controls.Add(this.appointment_time);
            this.Controls.Add(this.appointment_date);
            this.Controls.Add(this.patient_date_of_birth);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.appointment_report);
            this.Controls.Add(this.patient_full_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Edit_appointment";
            this.Text = "Добавление приёма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox patient_full_name;
        private System.Windows.Forms.TextBox appointment_report;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DateTimePicker patient_date_of_birth;
        private System.Windows.Forms.DateTimePicker appointment_date;
        private System.Windows.Forms.DateTimePicker appointment_time;
        private System.Windows.Forms.ComboBox fk_id_doctor;
    }
}