using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task7
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private float t = 0;

        public Form1()
        {
            InitializeComponent();

            // Создаем таймер, который будет вызывать перерисовку каждые 5 мс
            timer = new System.Windows.Forms.Timer { Interval = 5 };
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Рисуем ось X
            e.Graphics.DrawLine(Pens.Black, 0, this.ClientSize.Height / 2, this.ClientSize.Width, this.ClientSize.Height / 2);

            // Рисуем окружность, движущуюся по синусоиде
            float x = t;
            float y = (float)Math.Sin(t) * this.ClientSize.Height / 4 + this.ClientSize.Height / 2;
            e.Graphics.FillEllipse(Brushes.Red, x, y, 10, 10);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            t += 0.1f; // управление скоростью анимации
            if (t > this.ClientSize.Width)
                t = 0;
            this.Invalidate(); // Перерисовываем форму
        }
    }

}
