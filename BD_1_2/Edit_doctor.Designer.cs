namespace BD_1_2
{
    partial class Edit_doctor
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
            this.doctor_full_name = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.date_of_birth = new System.Windows.Forms.DateTimePicker();
            this.gender = new System.Windows.Forms.ComboBox();
            this.id_position = new System.Windows.Forms.ComboBox();
            this.id_department = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО доктора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(46, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(46, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Код подразделения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(46, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Код должности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(46, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Пол";
            // 
            // doctor_full_name
            // 
            this.doctor_full_name.Location = new System.Drawing.Point(276, 33);
            this.doctor_full_name.Name = "doctor_full_name";
            this.doctor_full_name.Size = new System.Drawing.Size(187, 20);
            this.doctor_full_name.TabIndex = 1;
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
            // date_of_birth
            // 
            this.date_of_birth.Location = new System.Drawing.Point(276, 86);
            this.date_of_birth.Name = "date_of_birth";
            this.date_of_birth.Size = new System.Drawing.Size(187, 20);
            this.date_of_birth.TabIndex = 4;
            this.date_of_birth.Value = new System.DateTime(2025, 10, 1, 14, 7, 29, 0);
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.gender.Location = new System.Drawing.Point(276, 259);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(187, 21);
            this.gender.TabIndex = 5;
            // 
            // id_position
            // 
            this.id_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_position.FormattingEnabled = true;
            this.id_position.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.id_position.Location = new System.Drawing.Point(276, 202);
            this.id_position.Name = "id_position";
            this.id_position.Size = new System.Drawing.Size(187, 21);
            this.id_position.TabIndex = 6;
            // 
            // id_department
            // 
            this.id_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_department.FormattingEnabled = true;
            this.id_department.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.id_department.Location = new System.Drawing.Point(276, 144);
            this.id_department.Name = "id_department";
            this.id_department.Size = new System.Drawing.Size(187, 21);
            this.id_department.TabIndex = 7;
            // 
            // Edit_doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.id_department);
            this.Controls.Add(this.id_position);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.date_of_birth);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.doctor_full_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Edit_doctor";
            this.Text = "Добавление доктора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox doctor_full_name;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DateTimePicker date_of_birth;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.ComboBox id_position;
        private System.Windows.Forms.ComboBox id_department;
    }
}