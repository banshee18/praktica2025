using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        private PictureBox rocketPictureBox;
        private System.Windows.Forms.Timer timer;
        private Button launchButton;
        private int rocketPosition;

        public Form1()
        {
            InitializeComponent();

            // Создаем PictureBox для ракеты
            rocketPictureBox = new PictureBox
            {
                Image = Image.FromFile("C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice29\\Practice29\\source\\Rocket.png"), // путь к изображению ракеты
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height)
            };

            // Создаем кнопку запуска
            launchButton = new Button
            {
                Text = "Запуск!",
                BackColor = Color.Red,
                Location = new Point(this.ClientSize.Width / 2 - 200, this.ClientSize.Height - 50)
            };
            launchButton.Click += LaunchButton_Click;

            // Создаем таймер для анимации
            timer = new System.Windows.Forms.Timer { Interval = 50 };
            timer.Tick += Timer_Tick;

            // Добавляем контролы на форму
            this.Controls.Add(rocketPictureBox);
            this.Controls.Add(launchButton);
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            rocketPosition += 5;
            rocketPictureBox.Location = new Point(rocketPictureBox.Location.X, this.ClientSize.Height - rocketPosition);

            if (rocketPictureBox.Location.Y < 0)
            {
                timer.Stop();
                MessageBox.Show("Ракета запущена!");
            }
        }
    }

}
