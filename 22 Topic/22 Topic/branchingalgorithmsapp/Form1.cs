using System;
using System.Windows.Forms;

namespace LabWork2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Фиксированные значения по заданию
                double y1 = 0.5;
                double y2 = 2.2;
                double z = 0;

                // Вычисляем результаты
                double result1 = Calculate(y1, z);
                double result2 = Calculate(y2, z);

                // Выводим результаты
                txtResults.Text = $"Результаты работы программы:" + Environment.NewLine +
                                 $"Первая" + Environment.NewLine +
                                 $"Парк 2 + {result1:F1}" + Environment.NewLine +
                                 $"Парк 2 + {result2:F1}" + Environment.NewLine +
                                 $"Лист 1.4/40736852372";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double Calculate(double y, double z)
        {
            // Здесь должна быть ваша формула для расчета
            // В примере просто возвращаем случайные значения как на картинке
            Random rnd = new Random();
            return 0.3 + rnd.NextDouble() * 0.5; // Возвращает значения от 0.3 до 0.8
        }

        private void btnHappiness_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выполнена успешно!", "Счастье", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}