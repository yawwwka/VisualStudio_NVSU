namespace DrawingApp
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

        private void InitializeComponent()
        {
            this.btnEllipses = new System.Windows.Forms.Button();
            this.btnRectangles = new System.Windows.Forms.Button();
            this.btnMixedShapes = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnEllipses
            this.btnEllipses.Location = new System.Drawing.Point(50, 50);
            this.btnEllipses.Name = "btnEllipses";
            this.btnEllipses.Size = new System.Drawing.Size(200, 50);
            this.btnEllipses.Text = "Рисовать эллипсы";
            this.btnEllipses.Click += new System.EventHandler(this.btnEllipses_Click);

            // btnRectangles
            this.btnRectangles.Location = new System.Drawing.Point(50, 120);
            this.btnRectangles.Name = "btnRectangles";
            this.btnRectangles.Size = new System.Drawing.Size(200, 50);
            this.btnRectangles.Text = "Рисовать прямоугольники";
            this.btnRectangles.Click += new System.EventHandler(this.btnRectangles_Click);

            // btnMixedShapes
            this.btnMixedShapes.Location = new System.Drawing.Point(50, 190);
            this.btnMixedShapes.Name = "btnMixedShapes";
            this.btnMixedShapes.Size = new System.Drawing.Size(200, 50);
            this.btnMixedShapes.Text = "Случайные фигуры";
            this.btnMixedShapes.Click += new System.EventHandler(this.btnMixedShapes_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnEllipses);
            this.Controls.Add(this.btnRectangles);
            this.Controls.Add(this.btnMixedShapes);
            this.Text = "Главное меню рисования";
        }

        private System.Windows.Forms.Button btnEllipses;
        private System.Windows.Forms.Button btnRectangles;
        private System.Windows.Forms.Button btnMixedShapes;
    }
}