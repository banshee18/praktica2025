using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();

            // Создаем таймер, который будет вызывать перерисовку каждую секунду
            timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int clockRadius = Math.Min(ClientSize.Width, ClientSize.Height) / 2;
            Point clockCenter = new Point(ClientSize.Width / 2, ClientSize.Height / 2);

            // Рисуем циферблат
            e.Graphics.DrawEllipse(Pens.Black, clockCenter.X - clockRadius, clockCenter.Y - clockRadius, clockRadius * 2, clockRadius * 2);

            // Рисуем секундную стрелку
            double angle = DateTime.Now.Second * 6 * Math.PI / 180; // 6 градусов на секунду
            int handRadius = (int)(clockRadius * 0.9);
            Point handEnd = new Point(clockCenter.X + (int)(handRadius * Math.Sin(angle)), clockCenter.Y - (int)(handRadius * Math.Cos(angle)));
            e.Graphics.DrawLine(Pens.Red, clockCenter, handEnd);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate(); // Перерисовываем форму
        }
    }

}
