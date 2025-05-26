using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinTimer2
{
    public partial class Form1 : Form
    {
        private CustomTimerControl customTimer;
        private Button toggleButton;
        private ComboBox formatComboBox;

        public Form1()
        {
            InitializeComponent();
            SetupControls();
            this.Text = "Custom Timer Control Demo";
            this.ClientSize = new Size(300, 150);
        }

        private void SetupControls()
        {
            // Создаем и настраиваем элемент управления таймером
            customTimer = new CustomTimerControl();
            customTimer.Location = new Point(20, 20);
            customTimer.BackgroundColor = Color.Navy;
            customTimer.TextColor = Color.White;
            this.Controls.Add(customTimer);

            // Кнопка включения/выключения таймера
            toggleButton = new Button();
            toggleButton.Text = "Toggle Timer";
            toggleButton.Location = new Point(20, 80);
            toggleButton.Click += ToggleButton_Click;
            this.Controls.Add(toggleButton);

            // Комбобокс для выбора формата времени
            formatComboBox = new ComboBox();
            formatComboBox.Location = new Point(150, 80);
            formatComboBox.Items.AddRange(new object[] {
                "HH:mm:ss",
                "hh:mm:ss tt",
                "HH:mm",
                "hh:mm tt"
            });
            formatComboBox.SelectedIndex = 0;
            formatComboBox.SelectedIndexChanged += FormatComboBox_SelectedIndexChanged;
            this.Controls.Add(formatComboBox);
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            customTimer.TimerEnabled = !customTimer.TimerEnabled;
            toggleButton.Text = customTimer.TimerEnabled ? "Stop Timer" : "Start Timer";
        }

        private void FormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            customTimer.TimeFormat = formatComboBox.SelectedItem.ToString();
        }
    }
}