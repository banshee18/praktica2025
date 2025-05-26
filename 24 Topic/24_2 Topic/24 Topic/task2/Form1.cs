using System;
using System.Windows.Forms;

namespace WinTimer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Digital Clock Control Demo";

            // Добавляем кнопку для управления таймером
            Button toggleButton = new Button();
            toggleButton.Text = "Toggle Timer";
            toggleButton.Location = new System.Drawing.Point(10, 70);
            toggleButton.Click += ToggleButton_Click;
            this.Controls.Add(toggleButton);
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            userControlTimer1.TimeEnabled = !userControlTimer1.TimeEnabled;
        }
    }
}