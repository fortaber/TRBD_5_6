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
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BD_1_2.DataSet1();
            this.doctorappointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorappointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorappointmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectToDB = new System.Windows.Forms.ToolStripTextBox();
            this.CloseConnection = new System.Windows.Forms.ToolStripTextBox();
            this.Exit = new System.Windows.Forms.ToolStripTextBox();
            this.TablesToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableTickets = new System.Windows.Forms.ToolStripTextBox();
            this.ReportsToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportWord = new System.Windows.Forms.ToolStripTextBox();
            this.ReportExcel = new System.Windows.Forms.ToolStripTextBox();
            this.ReportPDF = new System.Windows.Forms.ToolStripTextBox();
            this.WindowToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WinsCascade = new System.Windows.Forms.ToolStripTextBox();
            this.WinsHorisontal = new System.Windows.Forms.ToolStripTextBox();
            this.WinsVertical = new System.Windows.Forms.ToolStripTextBox();
            this.WinsCloseAll = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorappointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorappointmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorappointmentBindingSource2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // doctorappointmentBindingSource2
            // 
            this.doctorappointmentBindingSource2.DataMember = "Doctor_appointment";
            this.doctorappointmentBindingSource2.DataSource = this.dataSet1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripMenu,
            this.TablesToolStripMenu,
            this.ReportsToolStripMenu,
            this.WindowToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileStripMenu
            // 
            this.FileStripMenu.CheckOnClick = true;
            this.FileStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectToDB,
            this.CloseConnection,
            this.Exit});
            this.FileStripMenu.Name = "FileStripMenu";
            this.FileStripMenu.Size = new System.Drawing.Size(48, 20);
            this.FileStripMenu.Text = "Файл";
            // 
            // ConnectToDB
            // 
            this.ConnectToDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConnectToDB.Name = "ConnectToDB";
            this.ConnectToDB.ReadOnly = true;
            this.ConnectToDB.Size = new System.Drawing.Size(130, 23);
            this.ConnectToDB.Text = "Подключиться к БД";
            this.ConnectToDB.Click += new System.EventHandler(this.ConnectToDB_Click);
            // 
            // CloseConnection
            // 
            this.CloseConnection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseConnection.Name = "CloseConnection";
            this.CloseConnection.ReadOnly = true;
            this.CloseConnection.Size = new System.Drawing.Size(130, 23);
            this.CloseConnection.Text = "Закрыть соединение";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit.Name = "Exit";
            this.Exit.ReadOnly = true;
            this.Exit.Size = new System.Drawing.Size(100, 23);
            this.Exit.Text = "Выйти";
            // 
            // TablesToolStripMenu
            // 
            this.TablesToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTableTickets});
            this.TablesToolStripMenu.Name = "TablesToolStripMenu";
            this.TablesToolStripMenu.Size = new System.Drawing.Size(68, 20);
            this.TablesToolStripMenu.Text = "Таблицы";
            // 
            // OpenTableTickets
            // 
            this.OpenTableTickets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OpenTableTickets.Name = "OpenTableTickets";
            this.OpenTableTickets.ReadOnly = true;
            this.OpenTableTickets.Size = new System.Drawing.Size(160, 23);
            this.OpenTableTickets.Text = "Открыть таблицу \"Билеты\"";
            // 
            // ReportsToolStripMenu
            // 
            this.ReportsToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReportWord,
            this.ReportExcel,
            this.ReportPDF});
            this.ReportsToolStripMenu.Name = "ReportsToolStripMenu";
            this.ReportsToolStripMenu.Size = new System.Drawing.Size(60, 20);
            this.ReportsToolStripMenu.Text = "Отчеты";
            // 
            // ReportWord
            // 
            this.ReportWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReportWord.Name = "ReportWord";
            this.ReportWord.ReadOnly = true;
            this.ReportWord.Size = new System.Drawing.Size(170, 23);
            this.ReportWord.Text = "Сформировать отчет Word";
            // 
            // ReportExcel
            // 
            this.ReportExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReportExcel.Name = "ReportExcel";
            this.ReportExcel.ReadOnly = true;
            this.ReportExcel.Size = new System.Drawing.Size(170, 23);
            this.ReportExcel.Text = "Сформировать отчет Excel";
            // 
            // ReportPDF
            // 
            this.ReportPDF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReportPDF.Name = "ReportPDF";
            this.ReportPDF.ReadOnly = true;
            this.ReportPDF.Size = new System.Drawing.Size(170, 23);
            this.ReportPDF.Text = "Сформировать отчет PDF";
            // 
            // WindowToolStripMenu
            // 
            this.WindowToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WinsCascade,
            this.WinsHorisontal,
            this.WinsVertical,
            this.WinsCloseAll});
            this.WindowToolStripMenu.Name = "WindowToolStripMenu";
            this.WindowToolStripMenu.Size = new System.Drawing.Size(48, 20);
            this.WindowToolStripMenu.Text = "Окно";
            // 
            // WinsCascade
            // 
            this.WinsCascade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WinsCascade.Name = "WinsCascade";
            this.WinsCascade.ReadOnly = true;
            this.WinsCascade.Size = new System.Drawing.Size(100, 23);
            this.WinsCascade.Text = "Окна каскадом";
            // 
            // WinsHorisontal
            // 
            this.WinsHorisontal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WinsHorisontal.Name = "WinsHorisontal";
            this.WinsHorisontal.ReadOnly = true;
            this.WinsHorisontal.Size = new System.Drawing.Size(100, 23);
            this.WinsHorisontal.Text = "По горизонтали";
            // 
            // WinsVertical
            // 
            this.WinsVertical.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WinsVertical.Name = "WinsVertical";
            this.WinsVertical.ReadOnly = true;
            this.WinsVertical.Size = new System.Drawing.Size(100, 23);
            this.WinsVertical.Text = "По вертикали";
            // 
            // WinsCloseAll
            // 
            this.WinsCloseAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WinsCloseAll.Name = "WinsCloseAll";
            this.WinsCloseAll.ReadOnly = true;
            this.WinsCloseAll.Size = new System.Drawing.Size(110, 23);
            this.WinsCloseAll.Text = "Закрыть все окна";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1043, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 513);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1050, 550);
            this.Name = "Form1";
            this.Text = "Управление базой данных";
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorappointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorappointmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorappointmentBindingSource2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource doctorappointmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentdurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doctorappointmentBindingSource1;
        private System.Windows.Forms.BindingSource doctorappointmentBindingSource2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileStripMenu;
        private System.Windows.Forms.ToolStripTextBox ConnectToDB;
        private System.Windows.Forms.ToolStripTextBox CloseConnection;
        private System.Windows.Forms.ToolStripTextBox Exit;
        private System.Windows.Forms.ToolStripMenuItem TablesToolStripMenu;
        private System.Windows.Forms.ToolStripTextBox OpenTableTickets;
        private System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenu;
        private System.Windows.Forms.ToolStripTextBox ReportWord;
        private System.Windows.Forms.ToolStripTextBox ReportExcel;
        private System.Windows.Forms.ToolStripTextBox ReportPDF;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStripMenu;
        private System.Windows.Forms.ToolStripTextBox WinsCascade;
        private System.Windows.Forms.ToolStripTextBox WinsHorisontal;
        private System.Windows.Forms.ToolStripTextBox WinsVertical;
        private System.Windows.Forms.ToolStripTextBox WinsCloseAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}