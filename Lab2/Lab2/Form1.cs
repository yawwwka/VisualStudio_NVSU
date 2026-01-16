namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);

                // Z(x, y) = sin(x) + cos(x) + sin(2x)
                double z = Math.Sin(x) + Math.Cos(x) + Math.Sin(2 * x);

                txtResult.Text = z.ToString("F4");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
