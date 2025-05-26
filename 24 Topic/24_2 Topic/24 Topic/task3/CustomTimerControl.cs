using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinTimer2
{
    public partial class CustomTimerControl : Control
    {
        private Timer timer;
        private Color backgroundColor = Color.Blue;
        private Color textColor = Color.White;
        private string timeFormat = "HH:mm:ss";

        public CustomTimerControl()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.ResizeRedraw |
                        ControlStyles.UserPaint, true);
            this.Size = new Size(150, 50);
            this.Font = new Font("Arial", 14, FontStyle.Bold);
        }

        [Category("Timer Settings")]
        [Description("Включение/выключение таймера")]
        public bool TimerEnabled
        {
            get { return timer.Enabled; }
            set { timer.Enabled = value; }
        }

        [Category("Appearance")]
        [Description("Цвет фона")]
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; this.Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Цвет текста")]
        public Color TextColor
        {
            get { return textColor; }
            set { textColor = value; this.Invalidate(); }
        }

        [Category("Timer Settings")]
        [Description("Формат отображения времени")]
        public string TimeFormat
        {
            get { return timeFormat; }
            set { timeFormat = value; this.Invalidate(); }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (SolidBrush brush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }

            using (SolidBrush textBrush = new SolidBrush(textColor))
            {
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                e.Graphics.DrawString(
                    DateTime.Now.ToString(timeFormat),
                    this.Font,
                    textBrush,
                    ClientRectangle,
                    format);
            }

            using (Pen borderPen = new Pen(Color.DarkBlue, 2))
            {
                e.Graphics.DrawRectangle(borderPen,
                    new Rectangle(0, 0, Width - 1, Height - 1));
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }
    }
}