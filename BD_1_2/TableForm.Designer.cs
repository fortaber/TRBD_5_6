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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.InsTable = new System.Windows.Forms.ToolStripButton();
            this.EditTable = new System.Windows.Forms.ToolStripButton();
            this.DelTable = new System.Windows.Forms.ToolStripButton();
            this.CloseTable = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(492, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsTable,
            this.EditTable,
            this.DelTable,
            this.CloseTable});
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
            // 
            // EditTable
            // 
            this.EditTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditTable.Image = ((System.Drawing.Image)(resources.GetObject("EditTable.Image")));
            this.EditTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditTable.Name = "EditTable";
            this.EditTable.Size = new System.Drawing.Size(34, 34);
            this.EditTable.Text = "Редактирование данных";
            // 
            // DelTable
            // 
            this.DelTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DelTable.Image = ((System.Drawing.Image)(resources.GetObject("DelTable.Image")));
            this.DelTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelTable.Name = "DelTable";
            this.DelTable.Size = new System.Drawing.Size(34, 34);
            this.DelTable.Text = "Удаление данных";
            // 
            // CloseTable
            // 
            this.CloseTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseTable.Image = ((System.Drawing.Image)(resources.GetObject("CloseTable.Image")));
            this.CloseTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseTable.Name = "CloseTable";
            this.CloseTable.Size = new System.Drawing.Size(34, 34);
            this.CloseTable.Text = "Выход";
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 326);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TableForm";
            this.Text = "Данные таблицы ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton InsTable;
        private System.Windows.Forms.ToolStripButton EditTable;
        private System.Windows.Forms.ToolStripButton DelTable;
        private System.Windows.Forms.ToolStripButton CloseTable;
    }
}