using System;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        private Button btnFill;
        private Button btnReplace;
        private TextBox[] txtOriginal;
        private TextBox[] txtObtained;

        public Form1()
        {
            InitializeComponent();
            InitializeArrayControls();
        }

        private void InitializeArrayControls()
        {
            txtOriginal = new TextBox[15];
            txtObtained = new TextBox[15];

            for (int i = 0; i < 15; i++)
            {
                // Исходный массив
                txtOriginal[i] = new TextBox { Location = new System.Drawing.Point(10, 30 + i * 20), Width = 100 };
                Controls.Add(txtOriginal[i]);

                // Полученный массив
                txtObtained[i] = new TextBox { Location = new System.Drawing.Point(130, 30 + i * 20), Width = 100, ReadOnly = true };
                Controls.Add(txtObtained[i]);
            }

            // Кнопка "Заполнить"
            btnFill = new Button { Text = "Заполнить", Location = new System.Drawing.Point(350, 30), Width = 100, Height = 30 };
            btnFill.Click += BtnFill_Click;
            Controls.Add(btnFill);

            // Кнопка "Заменить"
            btnReplace = new Button { Text = "Заменить", Location = new System.Drawing.Point(350, 70), Width = 100, Height = 30 };
            btnReplace.Click += BtnReplace_Click;
            Controls.Add(btnReplace);
        }

        private void BtnFill_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                int value = rnd.Next(-50, 51);
                txtOriginal[i].Text = value.ToString();
            }
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                if (int.TryParse(txtOriginal[i].Text, out int value))
                {
                    if (value > 0)
                    {
                        txtObtained[i].Text = (value * value).ToString();
                    }
                    else
                    {
                        txtObtained[i].Text = (value * 2).ToString();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
