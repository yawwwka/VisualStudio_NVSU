namespace MatrixApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            generateToolStripMenuItem = new ToolStripMenuItem();
            columnSumsToolStripMenuItem = new ToolStripMenuItem();
            rowSumsToolStripMenuItem = new ToolStripMenuItem();
            minElementToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(681, 393);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { generateToolStripMenuItem, columnSumsToolStripMenuItem, rowSumsToolStripMenuItem, minElementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(681, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // generateToolStripMenuItem
            // 
            generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            generateToolStripMenuItem.Size = new Size(66, 20);
            generateToolStripMenuItem.Text = "Generate";
            generateToolStripMenuItem.Click += generateToolStripMenuItem_Click;
            // 
            // columnSumsToolStripMenuItem
            // 
            columnSumsToolStripMenuItem.Name = "columnSumsToolStripMenuItem";
            columnSumsToolStripMenuItem.Size = new Size(94, 20);
            columnSumsToolStripMenuItem.Text = "Column Sums";
            columnSumsToolStripMenuItem.Click += columnSumsToolStripMenuItem_Click;
            // 
            // rowSumsToolStripMenuItem
            // 
            rowSumsToolStripMenuItem.Name = "rowSumsToolStripMenuItem";
            rowSumsToolStripMenuItem.Size = new Size(74, 20);
            rowSumsToolStripMenuItem.Text = "Row Sums";
            rowSumsToolStripMenuItem.Click += rowSumsToolStripMenuItem_Click;
            // 
            // minElementToolStripMenuItem
            // 
            minElementToolStripMenuItem.Name = "minElementToolStripMenuItem";
            minElementToolStripMenuItem.Size = new Size(86, 20);
            minElementToolStripMenuItem.Text = "Min Element";
            minElementToolStripMenuItem.Click += minElementToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 417);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Matrix Application";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnSumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowSumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minElementToolStripMenuItem;
    }
}