using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black, 3);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            // Рисуем три смайлика
            for (int i = 0; i < 3; i++)
            {
                int x = 50 + i * 100;

                // Рисуем лицо
                g.DrawEllipse(blackPen, x, 50, 50, 50);
                g.FillEllipse(yellowBrush, x, 50, 50, 50);

                // Рисуем глаза
                g.FillEllipse(blackBrush, x + 10, 70, 10, 10);
                g.FillEllipse(blackBrush, x + 30, 70, 10, 10);

                // Рисуем улыбку
                g.DrawArc(blackPen, x + 10, 70, 30, 20, 0, 180);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
