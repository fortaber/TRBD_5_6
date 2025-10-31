namespace MyDatabase
{
    partial class TableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.InsTable = new System.Windows.Forms.ToolStripButton();
            this.EditTable = new System.Windows.Forms.ToolStripButton();
            this.DelTable = new System.Windows.Forms.ToolStripButton();
            this.Update = new System.Windows.Forms.ToolStripButton();
            this.search_label = new System.Windows.Forms.ToolStripLabel();
            this.search_field_combobox = new System.Windows.Forms.ToolStripComboBox();
            this.search_textbox = new System.Windows.Forms.ToolStripTextBox();
            this.search_btn = new System.Windows.Forms.ToolStripButton();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsTable,
            this.EditTable,
            this.DelTable,
            this.Update,
            this.search_label,
            this.search_field_combobox,
            this.search_textbox,
            this.search_btn,
            this.CloseButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(492, 37);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // InsTable
            // 
            this.InsTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InsTable.Image = ((System.Drawing.Image)(resources.GetObject("InsTable.Image")));
            this.InsTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsTable.Name = "InsTable";
            this.InsTable.Size = new System.Drawing.Size(34, 34);
            this.InsTable.Text = "Добавление данных";
            this.InsTable.Click += new System.EventHandler(this.InsTable_Click);
            // 
            // EditTable
            // 
            this.EditTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditTable.Image = ((System.Drawing.Image)(resources.GetObject("EditTable.Image")));
            this.EditTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditTable.Name = "EditTable";
            this.EditTable.Size = new System.Drawing.Size(34, 34);
            this.EditTable.Text = "Редактирование данных";
            this.EditTable.Click += new System.EventHandler(this.EditTable_Click);
            // 
            // DelTable
            // 
            this.DelTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DelTable.Image = ((System.Drawing.Image)(resources.GetObject("DelTable.Image")));
            this.DelTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelTable.Name = "DelTable";
            this.DelTable.Size = new System.Drawing.Size(34, 34);
            this.DelTable.Text = "Удаление данных";
            this.DelTable.Click += new System.EventHandler(this.DelTable_Click);
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
            // search_field_combobox
            // 
            this.search_field_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.search_field_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_field_combobox.Name = "search_field_combobox";
            this.search_field_combobox.Size = new System.Drawing.Size(130, 37);
            // 
            // search_textbox
            // 
            this.search_textbox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(80, 37);
            // 
            // search_btn
            // 
            this.search_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(34, 34);
            this.search_btn.Text = "Начать поиск";
            this.search_btn.ToolTipText = "Начать поиск";
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click_1);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(492, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 289);
            this.panel1.TabIndex = 5;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(500, 100);
            this.Name = "TableForm";
            this.Text = "Данные таблицы ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton InsTable;
        private System.Windows.Forms.ToolStripButton EditTable;
        private System.Windows.Forms.ToolStripButton DelTable;
        private System.Windows.Forms.ToolStripButton Update;
        private System.Windows.Forms.ToolStripLabel search_label;
        private System.Windows.Forms.ToolStripComboBox search_field_combobox;
        private System.Windows.Forms.ToolStripTextBox search_textbox;
        private System.Windows.Forms.ToolStripButton search_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton CloseButton;
    }
}