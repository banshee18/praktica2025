using System;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WinTimer1
{
    public partial class UserControlTimer : UserControl
    {
        public UserControlTimer()
        {
            InitializeComponent();
        }

        // Свойство для управления таймером
        [Category("Timer Settings")]
        [Description("Включение/выключение таймера")]
        public bool TimeEnabled
        {
            get { return timer1.Enabled; }
            set { timer1.Enabled = value; }
        }

        // Обработчик события таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        // Метод для обновления времени вручную
        public void UpdateTime()
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}