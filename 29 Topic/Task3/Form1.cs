using System;
using System.Drawing;
using System.Windows.Forms;



namespace Task3
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private float t = 0;
        private int a = 100; // изменение размера и формы кривой

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(Form1_Paint);

            timer.Interval = 50; // управление скоростью анимации
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            t += 0.01f; // управление скоростью анимации
            this.Invalidate(); // Перерисовать форму
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (t >= -1 && t <= 1)
            {
                float x = 3 * a * t / (1 + t * t * t) + this.ClientSize.Width / 2;
                float y = 3 * a * t * t / (1 + t * t * t) + this.ClientSize.Height / 2;

                e.Graphics.FillEllipse(Brushes.Red, x, y, 10, 10); // Рисуем окружность
            }
        }
    }

}
