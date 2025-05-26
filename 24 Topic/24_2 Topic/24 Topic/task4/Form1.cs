using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinButNum
{
    public partial class Form1 : Form
    {
        private ClickButton clickButton1;
        private Button resetButton;
        private Label infoLabel;

        public Form1()
        {
            InitializeComponent();
            SetupControls();
            this.Text = "Extended Button Control Demo";
            this.ClientSize = new Size(400, 200);
        }

        private void SetupControls()
        {
            // Создаем и настраиваем кнопку со счетчиком
            clickButton1 = new ClickButton();
            clickButton1.Text = "Click Me!";
            clickButton1.Location = new Point(50, 50);
            clickButton1.Size = new Size(150, 50);
            clickButton1.Font = new Font("Arial", 12, FontStyle.Bold);
            clickButton1.BackColor = Color.LightBlue;
            clickButton1.CounterColor = Color.DarkBlue;
            this.Controls.Add(clickButton1);

            // Кнопка сброса счетчика
            resetButton = new Button();
            resetButton.Text = "Reset Counter";
            resetButton.Location = new Point(220, 50);
            resetButton.Size = new Size(120, 50);
            resetButton.Click += ResetButton_Click;
            this.Controls.Add(resetButton);

            // Информационная метка
            infoLabel = new Label();
            infoLabel.Text = "Кликните по кнопке, чтобы увеличить счетчик.\nДвойной клик сбрасывает счетчик.";
            infoLabel.Location = new Point(50, 120);
            infoLabel.AutoSize = true;
            this.Controls.Add(infoLabel);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            clickButton1.Clicks = 0;
        }
    }
}