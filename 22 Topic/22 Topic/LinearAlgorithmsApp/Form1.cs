using System;
using System.Windows.Forms;
using System.Globalization;

namespace LinearAlgorithmCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Калькулятор линейных алгоритмов";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Парсим входные значения
                double x = double.Parse(txtX.Text, CultureInfo.InvariantCulture);
                double y = double.Parse(txtY.Text, CultureInfo.InvariantCulture);
                double z = double.Parse(txtZ.Text, CultureInfo.InvariantCulture);

                // Вычисляем значение функции
                double result = CalculateFunction(x, y, z);

                // Выводим результат
                lblResult.Text = $"f = {result:F5}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Ошибка: деление на ноль. Проверьте входные значения.", "Ошибка вычисления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateFunction(double x, double y, double z)
        {
            // Вычисляем числитель: 4 * sqrt(y + 3/x - 1)
            double numerator = 4 * Math.Sqrt(y + 3 / x - 1);

            // Вычисляем знаменатель: |x - y| * (sin^2(z) + tg(z))
            double denominator = Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2) + Math.Tan(z));

            // Возвращаем результат деления
            return numerator / denominator;
        }

        private void btnExample_Click(object sender, EventArgs e)
        {
            // Устанавливаем пример значений из задания
            txtX.Text = "17.421";
            txtY.Text = "0.010365"; // 10.365 × 10^(-3) = 0.010365
            txtZ.Text = "82800"; // 0.828 × 10^5 = 82800

            // Вычисляем результат
            btnCalculate_Click(sender, e);
        }
    }
}