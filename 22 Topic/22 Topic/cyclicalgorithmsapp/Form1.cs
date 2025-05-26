using System;
using System.Text;
using System.Windows.Forms;

namespace FunctionTabulation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем параметры из интерфейса
                double x0 = double.Parse(txtX0.Text);
                double xk = double.Parse(txtXk.Text);
                double dx = double.Parse(txtDx.Text);
                double b = double.Parse(txtB.Text);

                // Проверка корректности шага
                if (Math.Sign(xk - x0) != Math.Sign(dx) && dx != 0)
                {
                    MessageBox.Show("Некорректный шаг dx! Должен быть того же знака, что и (xk - x0)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Очищаем предыдущие результаты
                txtResults.Clear();

                // Добавляем заголовок
                txtResults.AppendText("Работу выполнил ст. Иванов М.А.\r\n");

                // Табулируем функцию
                StringBuilder results = new StringBuilder();
                for (double x = x0; Math.Sign(xk - x) == Math.Sign(xk - x0) || x == xk; x += dx)
                {
                    double y = CalculateFunction(x, b);
                    results.AppendLine($"x={x:F2}; y={y:F15}");
                }

                // Выводим результаты
                txtResults.AppendText(results.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для всех параметров.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateFunction(double x, double b)
        {
            // Вычисляем функцию y(x) по заданной формуле
            double term1 = Math.Sqrt(Math.Abs(x - b)) / Math.Pow(Math.Abs(Math.Pow(b, 3) - Math.Pow(x, 3)), 1.5);
            double term2 = Math.Log(Math.Abs(x - b));
            return term1 + term2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Очищаем все поля
            txtX0.Clear();
            txtXk.Clear();
            txtDx.Clear();
            txtB.Clear();
            txtResults.Clear();
        }

        private void txtX0_TextChanged(object sender, EventArgs e)
        {

        }
    }
}