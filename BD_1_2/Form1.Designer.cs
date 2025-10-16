namespace BD_1_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AddDoctor = new System.Windows.Forms.Button();
            this.EditDoctor = new System.Windows.Forms.Button();
            this.DeleteDoctor = new System.Windows.Forms.Button();
            this.AddAppointment = new System.Windows.Forms.Button();
            this.EditAppointment = new System.Windows.Forms.Button();
            this.DeleteAppointment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BD_1_2.DataSet1();
            this.doctorappointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorappointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idappointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientfullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientdateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkiddoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmenttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentreportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorappointmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Main = new System.Windows.Forms.SplitContainer();
            this.tableContainer = new System.Windows.Forms.SplitContainer();
            this.buttons = new System.Windows.Forms.SplitContainer();
            this.iddoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorfullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorappointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorappointmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorappointmentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main)).BeginInit();
            this.Main.Panel1.SuspendLayout();
            this.Main.Panel2.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableContainer)).BeginInit();
            this.tableContainer.Panel1.SuspendLayout();
            this.tableContainer.Panel2.SuspendLayout();
            this.tableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttons)).BeginInit();
            this.buttons.Panel1.SuspendLayout();
            this.buttons.Panel2.SuspendLayout();
            this.buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddDoctor
            // 
            this.AddDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDoctor.Location = new System.Drawing.Point(28, 38);
            this.AddDoctor.MinimumSize = new System.Drawing.Size(180, 50);
            this.AddDoctor.Name = "AddDoctor";
            this.AddDoctor.Size = new System.Drawing.Size(186, 54);
            this.AddDoctor.TabIndex = 0;
            this.AddDoctor.Text = "Добавить доктора";
            this.AddDoctor.UseVisualStyleBackColor = true;
            this.AddDoctor.Click += new System.EventHandler(this.AddDoctor_Click);
            // 
            // EditDoctor
            // 
            this.EditDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditDoctor.Location = new System.Drawing.Point(28, 98);
            this.EditDoctor.MinimumSize = new System.Drawing.Size(180, 50);
            this.EditDoctor.Name = "EditDoctor";
            this.EditDoctor.Size = new System.Drawing.Size(186, 54);
            this.EditDoctor.TabIndex = 0;
            this.EditDoctor.Text = "Редактировать доктора";
            this.EditDoctor.UseVisualStyleBackColor = true;
            this.EditDoctor.Click += new System.EventHandler(this.EditDoctor_Click);
            // 
            // DeleteDoctor
            // 
            this.DeleteDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteDoctor.Location = new System.Drawing.Point(28, 158);
            this.DeleteDoctor.MinimumSize = new System.Drawing.Size(180, 50);
            this.DeleteDoctor.Name = "DeleteDoctor";
            this.DeleteDoctor.Size = new System.Drawing.Size(186, 54);
            this.DeleteDoctor.TabIndex = 0;
            this.DeleteDoctor.Text = "Удалить доктора";
            this.DeleteDoctor.UseVisualStyleBackColor = true;
            this.DeleteDoctor.Click += new System.EventHandler(this.DeleteDoctor_Click);
            // 
            // AddAppointment
            // 
            this.AddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAppointment.Location = new System.Drawing.Point(28, 42);
            this.AddAppointment.MinimumSize = new System.Drawing.Size(180, 50);
            this.AddAppointment.Name = "AddAppointment";
            this.AddAppointment.Size = new System.Drawing.Size(186, 54);
            this.AddAppointment.TabIndex = 0;
            this.AddAppointment.Text = "Добавить приём";
            this.AddAppointment.UseVisualStyleBackColor = true;
            this.AddAppointment.Click += new System.EventHandler(this.AddAppointment_Click);
            // 
            // EditAppointment
            // 
            this.EditAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditAppointment.Location = new System.Drawing.Point(28, 102);
            this.EditAppointment.MinimumSize = new System.Drawing.Size(180, 50);
            this.EditAppointment.Name = "EditAppointment";
            this.EditAppointment.Size = new System.Drawing.Size(186, 54);
            this.EditAppointment.TabIndex = 0;
            this.EditAppointment.Text = "Редактировать приём";
            this.EditAppointment.UseVisualStyleBackColor = true;
            this.EditAppointment.Click += new System.EventHandler(this.EditAppointment_Click);
            // 
            // DeleteAppointment
            // 
            this.DeleteAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteAppointment.Location = new System.Drawing.Point(28, 162);
            this.DeleteAppointment.MinimumSize = new System.Drawing.Size(180, 50);
            this.DeleteAppointment.Name = "DeleteAppointment";
            this.DeleteAppointment.Size = new System.Drawing.Size(186, 54);
            this.DeleteAppointment.TabIndex = 0;
            this.DeleteAppointment.Text = "Удалить приём";
            this.DeleteAppointment.UseVisualStyleBackColor = true;
            this.DeleteAppointment.Click += new System.EventHandler(this.DeleteAppointment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddoctorDataGridViewTextBoxColumn,
            this.doctorfullnameDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.iddepartmentDataGridViewTextBoxColumn,
            this.idpositionDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 255);
            this.dataGridView1.TabIndex = 1;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorappointmentBindingSource
            // 
            this.doctorappointmentBindingSource.DataMember = "Doctor_appointment";
            this.doctorappointmentBindingSource.DataSource = this.dataSet1;
            // 
            // doctorappointmentBindingSource1
            // 
            this.doctorappointmentBindingSource1.DataMember = "Doctor_appointment";
            this.doctorappointmentBindingSource1.DataSource = this.dataSet1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idappointmentDataGridViewTextBoxColumn,
            this.patientfullnameDataGridViewTextBoxColumn,
            this.patientdateofbirthDataGridViewTextBoxColumn,
            this.fkiddoctorDataGridViewTextBoxColumn,
            this.appointmentdateDataGridViewTextBoxColumn,
            this.appointmenttimeDataGridViewTextBoxColumn,
            this.appointmentreportDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.doctorappointmentBindingSource2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(800, 251);
            this.dataGridView2.TabIndex = 2;
            // 
            // idappointmentDataGridViewTextBoxColumn
            // 
            this.idappointmentDataGridViewTextBoxColumn.DataPropertyName = "id_appointment";
            this.idappointmentDataGridViewTextBoxColumn.HeaderText = "Код приёма";
            this.idappointmentDataGridViewTextBoxColumn.Name = "idappointmentDataGridViewTextBoxColumn";
            this.idappointmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientfullnameDataGridViewTextBoxColumn
            // 
            this.patientfullnameDataGridViewTextBoxColumn.DataPropertyName = "patient_full_name";
            this.patientfullnameDataGridViewTextBoxColumn.HeaderText = "ФИО пациента";
            this.patientfullnameDataGridViewTextBoxColumn.Name = "patientfullnameDataGridViewTextBoxColumn";
            this.patientfullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientdateofbirthDataGridViewTextBoxColumn
            // 
            this.patientdateofbirthDataGridViewTextBoxColumn.DataPropertyName = "patient_date_of_birth";
            this.patientdateofbirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения пациента";
            this.patientdateofbirthDataGridViewTextBoxColumn.Name = "patientdateofbirthDataGridViewTextBoxColumn";
            this.patientdateofbirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkiddoctorDataGridViewTextBoxColumn
            // 
            this.fkiddoctorDataGridViewTextBoxColumn.DataPropertyName = "fk_id_doctor";
            this.fkiddoctorDataGridViewTextBoxColumn.HeaderText = "Код доктора";
            this.fkiddoctorDataGridViewTextBoxColumn.Name = "fkiddoctorDataGridViewTextBoxColumn";
            this.fkiddoctorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentdateDataGridViewTextBoxColumn
            // 
            this.appointmentdateDataGridViewTextBoxColumn.DataPropertyName = "appointment_date";
            this.appointmentdateDataGridViewTextBoxColumn.HeaderText = "Дата приёма";
            this.appointmentdateDataGridViewTextBoxColumn.Name = "appointmentdateDataGridViewTextBoxColumn";
            this.appointmentdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmenttimeDataGridViewTextBoxColumn
            // 
            this.appointmenttimeDataGridViewTextBoxColumn.DataPropertyName = "appointment_time";
            this.appointmenttimeDataGridViewTextBoxColumn.HeaderText = "Время приёма";
            this.appointmenttimeDataGridViewTextBoxColumn.Name = "appointmenttimeDataGridViewTextBoxColumn";
            this.appointmenttimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentreportDataGridViewTextBoxColumn
            // 
            this.appointmentreportDataGridViewTextBoxColumn.DataPropertyName = "appointment_report";
            this.appointmentreportDataGridViewTextBoxColumn.HeaderText = "Отчёт о приёме";
            this.appointmentreportDataGridViewTextBoxColumn.Name = "appointmentreportDataGridViewTextBoxColumn";
            this.appointmentreportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorappointmentBindingSource2
            // 
            this.doctorappointmentBindingSource2.DataMember = "Doctor_appointment";
            this.doctorappointmentBindingSource2.DataSource = this.dataSet1;
            // 
            // Main
            // 
            this.Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            // 
            // Main.Panel1
            // 
            this.Main.Panel1.Controls.Add(this.tableContainer);
            // 
            // Main.Panel2
            // 
            this.Main.Panel2.Controls.Add(this.buttons);
            this.Main.Size = new System.Drawing.Size(1043, 510);
            this.Main.SplitterDistance = 800;
            this.Main.TabIndex = 3;
            // 
            // tableContainer
            // 
            this.tableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContainer.Location = new System.Drawing.Point(0, 0);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // tableContainer.Panel1
            // 
            this.tableContainer.Panel1.Controls.Add(this.dataGridView1);
            // 
            // tableContainer.Panel2
            // 
            this.tableContainer.Panel2.Controls.Add(this.dataGridView2);
            this.tableContainer.Size = new System.Drawing.Size(800, 510);
            this.tableContainer.SplitterDistance = 255;
            this.tableContainer.TabIndex = 0;
            // 
            // buttons
            // 
            this.buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttons.Location = new System.Drawing.Point(0, 0);
            this.buttons.Name = "buttons";
            this.buttons.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // buttons.Panel1
            // 
            this.buttons.Panel1.Controls.Add(this.EditDoctor);
            this.buttons.Panel1.Controls.Add(this.DeleteDoctor);
            this.buttons.Panel1.Controls.Add(this.AddDoctor);
            // 
            // buttons.Panel2
            // 
            this.buttons.Panel2.Controls.Add(this.DeleteAppointment);
            this.buttons.Panel2.Controls.Add(this.AddAppointment);
            this.buttons.Panel2.Controls.Add(this.EditAppointment);
            this.buttons.Size = new System.Drawing.Size(239, 510);
            this.buttons.SplitterDistance = 255;
            this.buttons.TabIndex = 1;
            // 
            // iddoctorDataGridViewTextBoxColumn
            // 
            this.iddoctorDataGridViewTextBoxColumn.DataPropertyName = "id_doctor";
            this.iddoctorDataGridViewTextBoxColumn.HeaderText = "Код доктора";
            this.iddoctorDataGridViewTextBoxColumn.Name = "iddoctorDataGridViewTextBoxColumn";
            this.iddoctorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorfullnameDataGridViewTextBoxColumn
            // 
            this.doctorfullnameDataGridViewTextBoxColumn.DataPropertyName = "doctor_full_name";
            this.doctorfullnameDataGridViewTextBoxColumn.HeaderText = "ФИО доктора";
            this.doctorfullnameDataGridViewTextBoxColumn.Name = "doctorfullnameDataGridViewTextBoxColumn";
            this.doctorfullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            this.dateofbirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iddepartmentDataGridViewTextBoxColumn
            // 
            this.iddepartmentDataGridViewTextBoxColumn.DataPropertyName = "id_department";
            this.iddepartmentDataGridViewTextBoxColumn.HeaderText = "Код подразделения";
            this.iddepartmentDataGridViewTextBoxColumn.Name = "iddepartmentDataGridViewTextBoxColumn";
            this.iddepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpositionDataGridViewTextBoxColumn
            // 
            this.idpositionDataGridViewTextBoxColumn.DataPropertyName = "id_position";
            this.idpositionDataGridViewTextBoxColumn.HeaderText = "Код должности";
            this.idpositionDataGridViewTextBoxColumn.Name = "idpositionDataGridViewTextBoxColumn";
            this.idpositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 513);
            this.Controls.Add(this.Main);
            this.MinimumSize = new System.Drawing.Size(1050, 550);
            this.Name = "Form1";
            this.Text = "БД для докторов и приёмов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorappointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorappointmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorappointmentBindingSource2)).EndInit();
            this.Main.Panel1.ResumeLayout(false);
            this.Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main)).EndInit();
            this.Main.ResumeLayout(false);
            this.tableContainer.Panel1.ResumeLayout(false);
            this.tableContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableContainer)).EndInit();
            this.tableContainer.ResumeLayout(false);
            this.buttons.Panel1.ResumeLayout(false);
            this.buttons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttons)).EndInit();
            this.buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddDoctor;
        private System.Windows.Forms.Button EditDoctor;
        private System.Windows.Forms.Button DeleteDoctor;
        private System.Windows.Forms.Button AddAppointment;
        private System.Windows.Forms.Button EditAppointment;
        private System.Windows.Forms.Button DeleteAppointment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource doctorappointmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentdurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doctorappointmentBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idappointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientfullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientdateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkiddoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmenttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentreportDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doctorappointmentBindingSource2;
        private System.Windows.Forms.SplitContainer Main;
        private System.Windows.Forms.SplitContainer tableContainer;
        private System.Windows.Forms.SplitContainer buttons;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorfullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
    }
}