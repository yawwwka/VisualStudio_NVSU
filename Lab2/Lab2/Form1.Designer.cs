namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtX = new TextBox();
            txtY = new TextBox();
            label3 = new Label();
            btnCalculate = new Button();
            label4 = new Label();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 132);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "X = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 174);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "Y = ";
            // 
            // txtX
            // 
            txtX.Location = new Point(366, 129);
            txtX.Name = "txtX";
            txtX.Size = new Size(100, 23);
            txtX.TabIndex = 2;
            // 
            // txtY
            // 
            txtY.Location = new Point(366, 171);
            txtY.Name = "txtY";
            txtY.Size = new Size(100, 23);
            txtY.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 82);
            label3.Name = "label3";
            label3.Size = new Size(174, 30);
            label3.TabIndex = 4;
            label3.Text = "Z(x, y) = sin(x) + cos(x) + sin(2x)\r\nх,у- вещественные\r\n";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(332, 219);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(174, 38);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "ВЫЧИСЛИТЬ";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 284);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 6;
            label4.Text = "Результат: ";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(404, 281);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 7;
            txtResult.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(label4);
            Controls.Add(btnCalculate);
            Controls.Add(label3);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtX;
        private TextBox txtY;
        private Label label3;
        private Button btnCalculate;
        private Label label4;
        private TextBox txtResult;
    }
}
