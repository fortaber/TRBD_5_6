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
            this.OpenTicketsTable = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenCinemaHallsTable = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenClientsTable = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSessionsTable = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSeatsTable = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMoviesTable = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительныеТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenAgeRatingsTable = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenGenresTable = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenHallTypesTable = new System.Windows.Forms.ToolStripMenuItem();
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
            this.OpenMovieGenreTable = new System.Windows.Forms.ToolStripMenuItem();
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
            this.CloseConnection.Click += new System.EventHandler(this.CloseConnection_Click_1);
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
            this.OpenTicketsTable,
            this.OpenCinemaHallsTable,
            this.OpenClientsTable,
            this.OpenSessionsTable,
            this.OpenSeatsTable,
            this.OpenMoviesTable,
            this.OpenMovieGenreTable});
            this.TablesToolStripMenu.Name = "TablesToolStripMenu";
            this.TablesToolStripMenu.Size = new System.Drawing.Size(68, 20);
            this.TablesToolStripMenu.Text = "Таблицы";
            // 
            // OpenTicketsTable
            // 
            this.OpenTicketsTable.Name = "OpenTicketsTable";
            this.OpenTicketsTable.Size = new System.Drawing.Size(251, 22);
            this.OpenTicketsTable.Text = "Билеты - Клиенты";
            this.OpenTicketsTable.Click += new System.EventHandler(this.OpenTable_Click);
            // 
            // OpenCinemaHallsTable
            // 
            this.OpenCinemaHallsTable.Name = "OpenCinemaHallsTable";
            this.OpenCinemaHallsTable.Size = new System.Drawing.Size(251, 22);
            this.OpenCinemaHallsTable.Text = "Кинозалы - Типы залов";
            this.OpenCinemaHallsTable.Click += new System.EventHandler(this.OpenTable_Click);
            // 
            // OpenClientsTable
            // 
            this.OpenClientsTable.Name = "OpenClientsTable";
            this.OpenClientsTable.Size = new System.Drawing.Size(251, 22);
            this.OpenClientsTable.Text = "Клиенты";
            this.OpenClientsTable.Click += new System.EventHandler(this.OpenTable_Click);
            // 
            // OpenSessionsTable
            // 
            this.OpenSessionsTable.Name = "OpenSessionsTable";
            this.OpenSessionsTable.Size = new System.Drawing.Size(251, 22);
            this.OpenSessionsTable.Text = "Сеансы";
            this.OpenSessionsTable.Click += new System.EventHandler(this.OpenTable_Click);
            // 
            // OpenSeatsTable
            // 
            this.OpenSeatsTable.Name = "OpenSeatsTable";
            this.OpenSeatsTable.Size = new System.Drawing.Size(251, 22);
            this.OpenSeatsTable.Text = "Места";
            this.OpenSeatsTable.Click += new System.EventHandler(this.OpenTable_Click);
            // 
            // OpenMoviesTable
            // 
            this.OpenMoviesTable.Name = "OpenMoviesTable";
            this.OpenMoviesTable.Size = new System.Drawing.Size(251, 22);
            this.OpenMoviesTable.Text = "Фильмы - Возрастные рейтинги";
            this.OpenMoviesTable.Click += new System.EventHandler(this.OpenTable_Click);
            // 
            // дополнительныеТаблицыToolStripMenuItem
            // 
            this.дополнительныеТаблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenAgeRatingsTable,
            this.OpenGenresTable,
            this.OpenHallTypesTable});
            this.дополнительныеТаблицыToolStripMenuItem.Name = "дополнительныеТаблицыToolStripMenuItem";
            this.дополнительныеТаблицыToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
            this.дополнительныеТаблицыToolStripMenuItem.Text = "Дополнительные таблицы";
            // 
            // OpenAgeRatingsTable
            // 
            this.OpenAgeRatingsTable.Name = "OpenAgeRatingsTable";
            this.OpenAgeRatingsTable.Size = new System.Drawing.Size(193, 22);
            this.OpenAgeRatingsTable.Text = "Возрастные рейтинги";
            this.OpenAgeRatingsTable.Click += new System.EventHandler(this.OpenTable_Click);
            // 
            // OpenGenresTable
            // 
            this.OpenGenresTable.Name = "OpenGenresTable";
            this.OpenGenresTable.Size = new System.Drawing.Size(193, 22);
            this.OpenGenresTable.Text = "Жанры";
            this.OpenGenresTable.Click += new System.EventHandler(this.OpenTable_Click);
            // 
            // OpenHallTypesTable
            // 
            this.OpenHallTypesTable.Name = "OpenHallTypesTable";
            this.OpenHallTypesTable.Size = new System.Drawing.Size(193, 22);
            this.OpenHallTypesTable.Text = "Типы залов";
            this.OpenHallTypesTable.Click += new System.EventHandler(this.OpenTable_Click);
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
            this.ReportWord.Click += new System.EventHandler(this.ReportWord_Click);
            // 
            // ReportExcel
            // 
            this.ReportExcel.Name = "ReportExcel";
            this.ReportExcel.Size = new System.Drawing.Size(223, 22);
            this.ReportExcel.Text = "Сформировать отчет Excel";
            this.ReportExcel.Click += new System.EventHandler(this.ReportExcel_Click);
            // 
            // ReportPDF
            // 
            this.ReportPDF.Name = "ReportPDF";
            this.ReportPDF.Size = new System.Drawing.Size(223, 22);
            this.ReportPDF.Text = "Сформировать отчет PDF";
            this.ReportPDF.Click += new System.EventHandler(this.ReportPDF_Click);
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
            // OpenMovieGenreTable
            // 
            this.OpenMovieGenreTable.Name = "OpenMovieGenreTable";
            this.OpenMovieGenreTable.Size = new System.Drawing.Size(251, 22);
            this.OpenMovieGenreTable.Text = "Фильмы - Жанры";
            this.OpenMovieGenreTable.Click += new System.EventHandler(this.OpenTable_Click);
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
            this.MinimumSize = new System.Drawing.Size(800, 400);
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
        private System.Windows.Forms.ToolStripMenuItem OpenCinemaHallsTable;
        private System.Windows.Forms.ToolStripMenuItem OpenClientsTable;
        private System.Windows.Forms.ToolStripMenuItem OpenTicketsTable;
        private System.Windows.Forms.ToolStripMenuItem OpenSessionsTable;
        private System.Windows.Forms.ToolStripMenuItem OpenSeatsTable;
        private System.Windows.Forms.ToolStripMenuItem OpenMoviesTable;
        private System.Windows.Forms.ToolStripMenuItem OpenAgeRatingsTable;
        private System.Windows.Forms.ToolStripMenuItem OpenGenresTable;
        private System.Windows.Forms.ToolStripMenuItem OpenHallTypesTable;
        private System.Windows.Forms.ToolStripMenuItem OpenMovieGenreTable;
    }
}