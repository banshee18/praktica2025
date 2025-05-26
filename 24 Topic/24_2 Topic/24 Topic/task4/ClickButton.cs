using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinButNum
{
    public partial class ClickButton : Button
    {
        private int _clicks;
        private Color _counterColor = Color.Red;
        private int _counterMargin = 3;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Количество кликов по кнопке")]
        public int Clicks
        {
            get { return _clicks; }
            set
            {
                _clicks = value;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Цвет отображения счетчика кликов")]
        public Color CounterColor
        {
            get { return _counterColor; }
            set
            {
                _counterColor = value;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Отступ счетчика от краев кнопки")]
        public int CounterMargin
        {
            get { return _counterMargin; }
            set
            {
                _counterMargin = value;
                this.Invalidate();
            }
        }

        public ClickButton()
        {
            InitializeComponent();
        }

        protected override void OnClick(EventArgs e)
        {
            _clicks++;
            base.OnClick(e);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            using (Brush textBrush = new SolidBrush(_counterColor))
            {
                string clicksText = _clicks.ToString();
                SizeF textSize = pevent.Graphics.MeasureString(clicksText, this.Font);

                float x = this.Width - textSize.Width - _counterMargin;
                float y = this.Height - textSize.Height - _counterMargin;

                pevent.Graphics.DrawString(clicksText, this.Font, textBrush, x, y);
            }
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            _clicks = 0;
            base.OnDoubleClick(e);
            this.Invalidate();
        }
    }
}