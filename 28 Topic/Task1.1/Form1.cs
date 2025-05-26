using System.Drawing;
using System.Windows.Forms;

namespace Task1._1
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

            // Треугольник
            Point[] trianglePoints = { new Point(50, 0), new Point(0, 100), new Point(100, 100) };
            g.DrawPolygon(Pens.Black, trianglePoints);

            // Эллипс
            g.DrawEllipse(Pens.Black, new Rectangle(120, 120, 100, 50));

            // Закрашенный круг
            g.FillEllipse(Brushes.Blue, new Rectangle(240, 240, 100, 100));

            // Закрашенный прямоугольник
            g.FillRectangle(Brushes.Green, new Rectangle(360, 360, 100, 50));

            // Сектор
            g.FillPie(Brushes.Red, new Rectangle(480, 480, 100, 100), 0, 120);

            // Три концентрических круга
            for (int i = 0; i < 3; i++)
            {
                g.DrawEllipse(Pens.Black, new Rectangle(150 - i * 20, 150 - i * 20 + 200, 40 + i * 40, 40 + i * 40));
            }

            // Серия из семи квадратов по диагонали
            for (int i = 0; i < 7; i++)
            {
                g.DrawRectangle(Pens.Black, new Rectangle(10 + i * 20 + 200, 300 + i * 20 + 200, 30, 30));
            }

            // Шахматная доска 8x8
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Brush brush = (i + j) % 2 == 0 ? Brushes.Black : Brushes.White;
                    g.FillRectangle(brush, new Rectangle(10 + j * 20 + 400, 400 + i * 20 + 400, 20, 20));
                }
            }
        }
    }
}
