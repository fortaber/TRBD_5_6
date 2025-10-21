namespace MyDatabase
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectToDB = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TablesToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableHalls = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableClients = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительныеТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportWord = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WinsCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.WinsHorisontal = new System.Windows.Forms.ToolStripMenuItem();
            this.WinsVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.WinsCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarField1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripMenu,
            this.TablesToolStripMenu,
            this.дополнительныеТаблицыToolStripMenuItem,
            this.ReportsToolStripMenu,
            this.WindowToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.WindowToolStripMenu;
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
            this.ConnectToDB.Name = "ConnectToDB";
            this.ConnectToDB.Size = new System.Drawing.Size(188, 22);
            this.ConnectToDB.Text = "Подключиться к БД";
            this.ConnectToDB.Click += new System.EventHandler(this.ConnectToDB_Click);
            // 
            // CloseConnection
            // 
            this.CloseConnection.Name = "CloseConnection";
            this.CloseConnection.Size = new System.Drawing.Size(188, 22);
            this.CloseConnection.Text = "Закрыть соединение";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(188, 22);
            this.Exit.Text = "Выйти";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // TablesToolStripMenu
            // 
            this.TablesToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTableTickets,
            this.OpenTableHalls,
            this.OpenTableClients});
            this.TablesToolStripMenu.Name = "TablesToolStripMenu";
            this.TablesToolStripMenu.Size = new System.Drawing.Size(68, 20);
            this.TablesToolStripMenu.Text = "Таблицы";
            // 
            // OpenTableTickets
            // 
            this.OpenTableTickets.Name = "OpenTableTickets";
            this.OpenTableTickets.Size = new System.Drawing.Size(180, 22);
            this.OpenTableTickets.Text = "Билеты";
            this.OpenTableTickets.Click += new System.EventHandler(this.OpenTable_Click);
            // 
            // OpenTableHalls
            // 
            this.OpenTableHalls.Name = "OpenTableHalls";
            this.OpenTableHalls.Size = new System.Drawing.Size(180, 22);
            this.OpenTableHalls.Text = "Кинозалы";
            this.OpenTableHalls.Click += new System.EventHandler(this.OpenTable_Click);
            // 
            // OpenTableClients
            // 
            this.OpenTableClients.Name = "OpenTableClients";
            this.OpenTableClients.Size = new System.Drawing.Size(180, 22);
            this.OpenTableClients.Text = "Клиенты";
            this.OpenTableClients.Click += new System.EventHandler(this.OpenTable_Click);
            // 
            // дополнительныеТаблицыToolStripMenuItem
            // 
            this.дополнительныеТаблицыToolStripMenuItem.Name = "дополнительныеТаблицыToolStripMenuItem";
            this.дополнительныеТаблицыToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
            this.дополнительныеТаблицыToolStripMenuItem.Text = "Дополнительные таблицы";
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
            this.ReportWord.Name = "ReportWord";
            this.ReportWord.Size = new System.Drawing.Size(223, 22);
            this.ReportWord.Text = "Сформировать отчет Word";
            // 
            // ReportExcel
            // 
            this.ReportExcel.Name = "ReportExcel";
            this.ReportExcel.Size = new System.Drawing.Size(223, 22);
            this.ReportExcel.Text = "Сформировать отчет Excel";
            // 
            // ReportPDF
            // 
            this.ReportPDF.Name = "ReportPDF";
            this.ReportPDF.Size = new System.Drawing.Size(223, 22);
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
            this.WinsCascade.Name = "WinsCascade";
            this.WinsCascade.Size = new System.Drawing.Size(170, 22);
            this.WinsCascade.Text = "Окна каскадом";
            this.WinsCascade.Click += new System.EventHandler(this.WinsCascade_Click);
            // 
            // WinsHorisontal
            // 
            this.WinsHorisontal.Name = "WinsHorisontal";
            this.WinsHorisontal.Size = new System.Drawing.Size(170, 22);
            this.WinsHorisontal.Text = "По горизонтали";
            this.WinsHorisontal.Click += new System.EventHandler(this.WinsHorisontal_Click);
            // 
            // WinsVertical
            // 
            this.WinsVertical.Name = "WinsVertical";
            this.WinsVertical.Size = new System.Drawing.Size(170, 22);
            this.WinsVertical.Text = "По вертикали";
            this.WinsVertical.Click += new System.EventHandler(this.WinsVertical_Click);
            // 
            // WinsCloseAll
            // 
            this.WinsCloseAll.Name = "WinsCloseAll";
            this.WinsCloseAll.Size = new System.Drawing.Size(170, 22);
            this.WinsCloseAll.Text = "Закрыть все окна";
            this.WinsCloseAll.Click += new System.EventHandler(this.WinsCloseAll_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarField1});
            this.statusBar.Location = new System.Drawing.Point(0, 491);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1043, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarField1
            // 
            this.statusBarField1.Name = "statusBarField1";
            this.statusBarField1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 513);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(450, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных \"Кинотеатр\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentdurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileStripMenu;
        private System.Windows.Forms.ToolStripMenuItem TablesToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStripMenu;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarField1;
        private System.Windows.Forms.ToolStripMenuItem ConnectToDB;
        private System.Windows.Forms.ToolStripMenuItem CloseConnection;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem ReportWord;
        private System.Windows.Forms.ToolStripMenuItem ReportExcel;
        private System.Windows.Forms.ToolStripMenuItem ReportPDF;
        private System.Windows.Forms.ToolStripMenuItem WinsCascade;
        private System.Windows.Forms.ToolStripMenuItem WinsHorisontal;
        private System.Windows.Forms.ToolStripMenuItem WinsVertical;
        private System.Windows.Forms.ToolStripMenuItem WinsCloseAll;
        private System.Windows.Forms.ToolStripMenuItem дополнительныеТаблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenTableHalls;
        private System.Windows.Forms.ToolStripMenuItem OpenTableClients;
        private System.Windows.Forms.ToolStripMenuItem OpenTableTickets;
    }
}