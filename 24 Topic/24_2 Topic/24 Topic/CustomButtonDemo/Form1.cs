using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupButtons();
        }

        private void SetupButtons()
        {
            // Создаем и настраиваем кнопки
            FancyButton btn1 = new FancyButton();
            btn1.Text = "Primary Button";
            btn1.BackColor = Color.DimGray;  // Исправлено: было DodGray, стало DimGray
            btn1.BorderColor = Color.Orange;
            btn1.BorderSize = 2;
            btn1.BorderRadius = 15;
            btn1.Location = new Point(50, 50);
            btn1.Size = new Size(200, 50);
            btn1.Click += (s, e) => MessageBox.Show("Primary button clicked!");
            this.Controls.Add(btn1);

            FancyButton btn2 = new FancyButton();
            btn2.Text = "Success Button";
            btn2.BackColor = Color.SeaGreen;
            btn2.BorderRadius = 20;
            btn2.Location = new Point(50, 120);
            btn2.Size = new Size(200, 50);
            btn2.Click += (s, e) => MessageBox.Show("Success button clicked!");
            this.Controls.Add(btn2);

            FancyButton btn3 = new FancyButton();
            btn3.Text = "Danger Button";
            btn3.BackColor = Color.IndianRed;
            btn3.BorderRadius = 25;
            btn3.Location = new Point(50, 190);
            btn3.Size = new Size(200, 50);
            btn3.Click += (s, e) => MessageBox.Show("Danger button clicked!");
            this.Controls.Add(btn3);
        }
    }
}