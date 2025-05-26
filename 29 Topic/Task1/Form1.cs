namespace Task1
{
    public partial class Form1 : Form
    {
        private double x1, y1, x2, y2;
        private int alpha = 90;
        private readonly Pen pen = new Pen(Color.DarkRed, 2);
        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer(); // Объявление и инициализация таймера

        public Form1()
        {
            InitializeComponent();
            // Начинаем таймер
            timer1.Interval = 1000; // Установка интервала таймера (в миллисекундах)
            timer1.Start();
            // Добавляем обработчики событий
            this.Paint += new PaintEventHandler(Form1_Paint);
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //...
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            alpha += -6; // увеличиваем угол на 6°
            if (alpha >= 360) alpha -= 360; // начинаем с начала если прошли полный круг
            double radian = alpha * Math.PI / 180;
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            x2 = x1 + (int)(100 * Math.Cos(radian));
            y2 = y1 - (int)(100 * Math.Sin(radian));
            Invalidate(); // Принудительный вызов события Paint
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(pen, (float)x1, (float)y1, (float)x2, (float)y2);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }

}
