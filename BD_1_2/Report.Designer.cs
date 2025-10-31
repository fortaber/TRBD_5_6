namespace BD_1_2
{
    partial class Report
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
            this.report_label = new System.Windows.Forms.Label();
            this.report_combobox = new System.Windows.Forms.ComboBox();
            this.Make_report = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.Preview = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // report_label
            // 
            this.report_label.AutoSize = true;
            this.report_label.Location = new System.Drawing.Point(8, 41);
            this.report_label.Name = "report_label";
            this.report_label.Size = new System.Drawing.Size(35, 13);
            this.report_label.TabIndex = 0;
            this.report_label.Text = "label1";
            // 
            // report_combobox
            // 
            this.report_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.report_combobox.FormattingEnabled = true;
            this.report_combobox.Location = new System.Drawing.Point(11, 63);
            this.report_combobox.Name = "report_combobox";
            this.report_combobox.Size = new System.Drawing.Size(291, 21);
            this.report_combobox.TabIndex = 1;
            // 
            // Make_report
            // 
            this.Make_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Make_report.Location = new System.Drawing.Point(7, 279);
            this.Make_report.Name = "Make_report";
            this.Make_report.Size = new System.Drawing.Size(173, 29);
            this.Make_report.TabIndex = 2;
            this.Make_report.Text = "Сформировать отчёт";
            this.Make_report.UseVisualStyleBackColor = true;
            this.Make_report.Click += new System.EventHandler(this.Make_report_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Location = new System.Drawing.Point(444, 282);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(79, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(8, 1);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(400, 40);
            this.Description.TabIndex = 4;
            this.Description.Text = "label1";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartDatePicker.Location = new System.Drawing.Point(7, 63);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(250, 20);
            this.StartDatePicker.TabIndex = 5;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDatePicker.Location = new System.Drawing.Point(269, 63);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(254, 20);
            this.EndDatePicker.TabIndex = 6;
            // 
            // Preview
            // 
            this.Preview.Location = new System.Drawing.Point(7, 0);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(167, 23);
            this.Preview.TabIndex = 7;
            this.Preview.Text = "Предосмотр";
            this.Preview.UseVisualStyleBackColor = true;
            this.Preview.Click += new System.EventHandler(this.Preview_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(523, 243);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.EndDatePicker);
            this.panel1.Controls.Add(this.StartDatePicker);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.report_combobox);
            this.panel1.Controls.Add(this.report_label);
            this.panel1.Location = new System.Drawing.Point(1, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 89);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Preview);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.Make_report);
            this.panel2.Location = new System.Drawing.Point(1, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 312);
            this.panel2.TabIndex = 10;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(550, 450);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label report_label;
        private System.Windows.Forms.ComboBox report_combobox;
        private System.Windows.Forms.Button Make_report;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Button Preview;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}