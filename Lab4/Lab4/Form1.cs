using System;
using System.Data;
using System.Windows.Forms;

namespace MatrixApp
{
    public partial class Form1 : Form
    {
        private int[,] matrix;
        private int rows, cols;
        private Random random = new Random();
        private DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputDialog dialog = new InputDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                rows = dialog.Rows;
                cols = dialog.Cols;

                // Создание и заполнение матрицы случайными числами
                matrix = new int[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = random.Next(-100, 101);
                    }
                }

                DisplayMatrix();
            }
        }

        private void DisplayMatrix()
        {
            dataGridView1.Columns.Clear();

            // Создание колонок
            for (int j = 0; j < cols; j++)
            {
                dataGridView1.Columns.Add($"col{j}", $"C{j + 1}");
            }

            // Создание строк
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = rows;

            // Заполнение данными
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void columnSumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("First generate matrix!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = "Column sums:\n";
            for (int j = 0; j < cols; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += matrix[i, j];
                }
                result += $"Column {j + 1}: {sum}\n";
            }

            MessageBox.Show(result, "Column Sums");
        }

        private void rowSumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("First generate matrix!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = "Row sums:\n";
            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i, j];
                }
                result += $"Row {i + 1}: {sum}\n";
            }

            MessageBox.Show(result, "Row Sums");
        }

        private void minElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("First generate matrix!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int min = matrix[0, 0];
            int minRow = 0, minCol = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minRow = i;
                        minCol = j;
                    }
                }
            }

            MessageBox.Show($"Min element: {min}\nPosition: row {minRow + 1}, column {minCol + 1}",
                "Min Element");
        }
    }

    public partial class InputDialog : Form
    {
        private NumericUpDown numRows;
        private NumericUpDown numCols;
        private Button btnOK;
        private Button btnCancel;

        public int Rows { get; private set; }
        public int Cols { get; private set; }

        public InputDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Matrix Size";
            this.Size = new Size(300, 150);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lblRows = new Label();
            lblRows.Text = "Rows:";
            lblRows.Location = new Point(20, 20);
            lblRows.Size = new Size(100, 20);

            numRows = new NumericUpDown();
            numRows.Minimum = 1;
            numRows.Maximum = 20;
            numRows.Value = 5;
            numRows.Location = new Point(120, 20);
            numRows.Width = 120;

            Label lblCols = new Label();
            lblCols.Text = "Columns:";
            lblCols.Location = new Point(20, 50);
            lblCols.Size = new Size(100, 20);

            numCols = new NumericUpDown();
            numCols.Minimum = 1;
            numCols.Maximum = 20;
            numCols.Value = 5;
            numCols.Location = new Point(120, 50);
            numCols.Width = 120;

            btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(60, 80);
            btnOK.Size = new Size(80, 25);
            btnOK.Click += BtnOK_Click;

            btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(160, 80);
            btnCancel.Size = new Size(80, 25);

            this.Controls.Add(lblRows);
            this.Controls.Add(numRows);
            this.Controls.Add(lblCols);
            this.Controls.Add(numCols);
            this.Controls.Add(btnOK);
            this.Controls.Add(btnCancel);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Rows = (int)numRows.Value;
            Cols = (int)numCols.Value;
        }
    }
}