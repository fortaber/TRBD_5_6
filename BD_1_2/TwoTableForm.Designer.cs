namespace MyDatabase
{
    partial class TwoTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwoTableForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.InsTable1 = new System.Windows.Forms.ToolStripButton();
            this.EditTable1 = new System.Windows.Forms.ToolStripButton();
            this.DelTable1 = new System.Windows.Forms.ToolStripButton();
            this.Update = new System.Windows.Forms.ToolStripButton();
            this.search_label = new System.Windows.Forms.ToolStripLabel();
            this.search_field_combobox1 = new System.Windows.Forms.ToolStripComboBox();
            this.search_textbox1 = new System.Windows.Forms.ToolStripTextBox();
            this.search_btn1 = new System.Windows.Forms.ToolStripButton();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.InsTable2 = new System.Windows.Forms.ToolStripButton();
            this.EditTable2 = new System.Windows.Forms.ToolStripButton();
            this.DelTable2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.search_field_combobox2 = new System.Windows.Forms.ToolStripComboBox();
            this.search_textbox2 = new System.Windows.Forms.ToolStripTextBox();
            this.search_btn2 = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsTable1,
            this.EditTable1,
            this.DelTable1,
            this.Update,
            this.search_label,
            this.search_field_combobox1,
            this.search_textbox1,
            this.search_btn1,
            this.CloseButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(492, 37);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // InsTable1
            // 
            this.InsTable1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InsTable1.Image = ((System.Drawing.Image)(resources.GetObject("InsTable1.Image")));
            this.InsTable1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsTable1.Name = "InsTable1";
            this.InsTable1.Size = new System.Drawing.Size(34, 34);
            this.InsTable1.Text = "Добавление данных";
            this.InsTable1.Click += new System.EventHandler(this.InsTable_Click);
            // 
            // EditTable1
            // 
            this.EditTable1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditTable1.Image = ((System.Drawing.Image)(resources.GetObject("EditTable1.Image")));
            this.EditTable1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditTable1.Name = "EditTable1";
            this.EditTable1.Size = new System.Drawing.Size(34, 34);
            this.EditTable1.Text = "Редактирование данных";
            this.EditTable1.Click += new System.EventHandler(this.EditTable_Click);
            // 
            // DelTable1
            // 
            this.DelTable1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DelTable1.Image = ((System.Drawing.Image)(resources.GetObject("DelTable1.Image")));
            this.DelTable1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelTable1.Name = "DelTable1";
            this.DelTable1.Size = new System.Drawing.Size(34, 34);
            this.DelTable1.Text = "Удаление данных";
            this.DelTable1.Click += new System.EventHandler(this.DelTable_Click);
            // 
            // Update
            // 
            this.Update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(34, 34);
            this.Update.Text = "Обновление формы";
            this.Update.ToolTipText = "Обновление формы";
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // search_label
            // 
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(45, 34);
            this.search_label.Text = "Поиск:";
            // 
            // search_field_combobox1
            // 
            this.search_field_combobox1.BackColor = System.Drawing.SystemColors.Window;
            this.search_field_combobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_field_combobox1.Name = "search_field_combobox1";
            this.search_field_combobox1.Size = new System.Drawing.Size(130, 37);
            // 
            // search_textbox1
            // 
            this.search_textbox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.search_textbox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_textbox1.Name = "search_textbox1";
            this.search_textbox1.Size = new System.Drawing.Size(80, 37);
            // 
            // search_btn1
            // 
            this.search_btn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.search_btn1.Image = ((System.Drawing.Image)(resources.GetObject("search_btn1.Image")));
            this.search_btn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.search_btn1.Name = "search_btn1";
            this.search_btn1.Size = new System.Drawing.Size(34, 34);
            this.search_btn1.Text = "Начать поиск";
            this.search_btn1.ToolTipText = "Начать поиск";
            this.search_btn1.Click += new System.EventHandler(this.ApplySearchFilter);
            // 
            // CloseButton
            // 
            this.CloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(34, 34);
            this.CloseButton.Text = "Закрытие формы";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(492, 142);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 361);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.toolStrip2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 182);
            this.panel3.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 37);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(492, 145);
            this.dataGridView2.TabIndex = 6;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsTable2,
            this.EditTable2,
            this.DelTable2,
            this.toolStripLabel1,
            this.search_field_combobox2,
            this.search_textbox2,
            this.search_btn2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(492, 37);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // InsTable2
            // 
            this.InsTable2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InsTable2.Image = ((System.Drawing.Image)(resources.GetObject("InsTable2.Image")));
            this.InsTable2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsTable2.Name = "InsTable2";
            this.InsTable2.Size = new System.Drawing.Size(34, 34);
            this.InsTable2.Text = "Добавление данных";
            this.InsTable2.Click += new System.EventHandler(this.InsTable_Click);
            // 
            // EditTable2
            // 
            this.EditTable2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditTable2.Image = ((System.Drawing.Image)(resources.GetObject("EditTable2.Image")));
            this.EditTable2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditTable2.Name = "EditTable2";
            this.EditTable2.Size = new System.Drawing.Size(34, 34);
            this.EditTable2.Text = "Редактирование данных";
            this.EditTable2.Click += new System.EventHandler(this.EditTable_Click);
            // 
            // DelTable2
            // 
            this.DelTable2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DelTable2.Image = ((System.Drawing.Image)(resources.GetObject("DelTable2.Image")));
            this.DelTable2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelTable2.Name = "DelTable2";
            this.DelTable2.Size = new System.Drawing.Size(34, 34);
            this.DelTable2.Text = "Удаление данных";
            this.DelTable2.Click += new System.EventHandler(this.DelTable_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 34);
            this.toolStripLabel1.Text = "Поиск:";
            // 
            // search_field_combobox2
            // 
            this.search_field_combobox2.BackColor = System.Drawing.SystemColors.Window;
            this.search_field_combobox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_field_combobox2.Name = "search_field_combobox2";
            this.search_field_combobox2.Size = new System.Drawing.Size(130, 37);
            // 
            // search_textbox2
            // 
            this.search_textbox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.search_textbox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_textbox2.Name = "search_textbox2";
            this.search_textbox2.Size = new System.Drawing.Size(80, 37);
            // 
            // search_btn2
            // 
            this.search_btn2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.search_btn2.Image = ((System.Drawing.Image)(resources.GetObject("search_btn2.Image")));
            this.search_btn2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.search_btn2.Name = "search_btn2";
            this.search_btn2.Size = new System.Drawing.Size(34, 34);
            this.search_btn2.Text = "Начать поиск";
            this.search_btn2.ToolTipText = "Начать поиск";
            this.search_btn2.Click += new System.EventHandler(this.ApplySearchFilter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 179);
            this.panel2.TabIndex = 6;
            // 
            // TwoTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 361);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "TwoTableForm";
            this.Text = "Данные таблицы ";
            this.ResizeEnd += new System.EventHandler(this.OnResize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton InsTable1;
        private System.Windows.Forms.ToolStripButton EditTable1;
        private System.Windows.Forms.ToolStripButton DelTable1;
        private System.Windows.Forms.ToolStripButton Update;
        private System.Windows.Forms.ToolStripLabel search_label;
        private System.Windows.Forms.ToolStripComboBox search_field_combobox1;
        private System.Windows.Forms.ToolStripTextBox search_textbox1;
        private System.Windows.Forms.ToolStripButton search_btn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton InsTable2;
        private System.Windows.Forms.ToolStripButton EditTable2;
        private System.Windows.Forms.ToolStripButton DelTable2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox search_field_combobox2;
        private System.Windows.Forms.ToolStripTextBox search_textbox2;
        private System.Windows.Forms.ToolStripButton search_btn2;
    }
}