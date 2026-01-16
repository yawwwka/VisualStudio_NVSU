using System;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEllipses_Click(object sender, EventArgs e)
        {
            EllipseForm ellipseForm = new EllipseForm();
            ellipseForm.Show();
        }

        private void btnRectangles_Click(object sender, EventArgs e)
        {
            RectangleForm rectangleForm = new RectangleForm();
            rectangleForm.Show();
        }

        private void btnMixedShapes_Click(object sender, EventArgs e)
        {
            MixedShapesForm mixedForm = new MixedShapesForm();
            mixedForm.Show();
        }
    }

    public class EllipseForm : Form
    {
        private Button btnDraw;
        private Panel drawingPanel;
        private Random random;

        public EllipseForm()
        {
            random = new Random();
            InitializeComponent();
            this.Text = "Рисование эллипсов";
            this.Size = new Size(500, 500);
        }

        private void InitializeComponent()
        {
            drawingPanel = new Panel();
            drawingPanel.Dock = DockStyle.Fill;
            drawingPanel.Paint += new PaintEventHandler(DrawingPanel_Paint);
            drawingPanel.BackColor = Color.White;

            btnDraw = new Button();
            btnDraw.Text = "Нарисовать эллипсы";
            btnDraw.Location = new Point(10, 10);
            btnDraw.Click += new EventHandler(btnDraw_Click);

            this.Controls.Add(drawingPanel);
            this.Controls.Add(btnDraw);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            drawingPanel.Invalidate(); // Перерисовать панель
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Рисуем 5 случайных эллипсов
            for (int i = 0; i < 5; i++)
            {
                // Случайные координаты и размеры
                int x = random.Next(50, 350);
                int y = random.Next(50, 350);
                int width = random.Next(50, 150);
                int height = random.Next(50, 150);

                // Случайный цвет для кисти
                Color brushColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                Brush brush = new SolidBrush(brushColor);

                // Случайные параметры пера
                int penWidth = random.Next(1, 5);
                Color penColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                Pen pen = new Pen(penColor, penWidth);

                // Рисуем эллипс
                g.FillEllipse(brush, x, y, width, height);
                g.DrawEllipse(pen, x, y, width, height);

                // Освобождаем ресурсы
                brush.Dispose();
                pen.Dispose();
            }
        }
    }

    public class RectangleForm : Form
    {
        private Button btnDraw;
        private Panel drawingPanel;
        private Random random;

        public RectangleForm()
        {
            random = new Random();
            InitializeComponent();
            this.Text = "Рисование прямоугольников";
            this.Size = new Size(500, 500);
        }

        private void InitializeComponent()
        {
            drawingPanel = new Panel();
            drawingPanel.Dock = DockStyle.Fill;
            drawingPanel.Paint += new PaintEventHandler(DrawingPanel_Paint);
            drawingPanel.BackColor = Color.White;

            btnDraw = new Button();
            btnDraw.Text = "Нарисовать прямоугольники";
            btnDraw.Location = new Point(10, 10);
            btnDraw.Click += new EventHandler(btnDraw_Click);

            this.Controls.Add(drawingPanel);
            this.Controls.Add(btnDraw);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            drawingPanel.Invalidate();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < 5; i++)
            {
                int x = random.Next(50, 350);
                int y = random.Next(50, 350);
                int width = random.Next(50, 150);
                int height = random.Next(50, 150);

                Color brushColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                Brush brush = new SolidBrush(brushColor);

                int penWidth = random.Next(1, 5);
                Color penColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                Pen pen = new Pen(penColor, penWidth);

                // Разные стили линий
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                g.FillRectangle(brush, x, y, width, height);
                g.DrawRectangle(pen, x, y, width, height);

                brush.Dispose();
                pen.Dispose();
            }
        }
    }

    public class MixedShapesForm : Form
    {
        private Button btnDraw;
        private Panel drawingPanel;
        private Random random;

        public MixedShapesForm()
        {
            random = new Random();
            InitializeComponent();
            this.Text = "Случайные фигуры";
            this.Size = new Size(600, 600);
        }

        private void InitializeComponent()
        {
            drawingPanel = new Panel();
            drawingPanel.Dock = DockStyle.Fill;
            drawingPanel.Paint += new PaintEventHandler(DrawingPanel_Paint);
            drawingPanel.BackColor = Color.White;

            btnDraw = new Button();
            btnDraw.Text = "Нарисовать фигуры";
            btnDraw.Location = new Point(10, 10);
            btnDraw.Click += new EventHandler(btnDraw_Click);

            this.Controls.Add(drawingPanel);
            this.Controls.Add(btnDraw);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            drawingPanel.Invalidate();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Рисуем 10 случайных фигур
            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(20, 450);
                int y = random.Next(20, 450);
                int width = random.Next(40, 120);
                int height = random.Next(40, 120);

                Color brushColor = Color.FromArgb(100 + random.Next(156),
                    random.Next(256), random.Next(256), random.Next(256));
                Brush brush = new SolidBrush(brushColor);

                int penWidth = random.Next(1, 4);
                Color penColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                Pen pen = new Pen(penColor, penWidth);

                // Случайно выбираем тип фигуры
                int shapeType = random.Next(3);

                switch (shapeType)
                {
                    case 0: // Эллипс
                        g.FillEllipse(brush, x, y, width, height);
                        g.DrawEllipse(pen, x, y, width, height);
                        break;

                    case 1: // Прямоугольник
                        g.FillRectangle(brush, x, y, width, height);
                        g.DrawRectangle(pen, x, y, width, height);
                        break;

                    case 2: // Скругленный прямоугольник
                        int cornerRadius = random.Next(10, 30);
                        g.FillRectangle(brush, x, y, width, height);
                        g.DrawRectangle(pen, x, y, width, height);
                        // Рисуем скругленные углы
                        g.FillEllipse(brush, x, y, cornerRadius, cornerRadius);
                        g.FillEllipse(brush, x + width - cornerRadius, y, cornerRadius, cornerRadius);
                        g.FillEllipse(brush, x, y + height - cornerRadius, cornerRadius, cornerRadius);
                        g.FillEllipse(brush, x + width - cornerRadius, y + height - cornerRadius, cornerRadius, cornerRadius);
                        break;
                }

                brush.Dispose();
                pen.Dispose();
            }
        }
    }
}
