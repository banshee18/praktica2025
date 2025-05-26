namespace Task4
{
    public partial class Form1 : Form
    {
        private TextBox textBoxLetter;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private Button buttonCreate;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Создаем поля ввода и кнопку
            textBoxLetter = new TextBox { Location = new Point(10, 15), Width = 100 };
            textBoxX = new TextBox { Location = new Point(120, 15), Width = 100 };
            textBoxY = new TextBox { Location = new Point(230, 15), Width = 100 };
            buttonCreate = new Button { Text = "Создать", Location = new Point(450, 20) };

            // Добавляем обработчик нажатия на кнопку
            buttonCreate.Click += Create_Click;

            // Добавляем элементы на форму
            Controls.Add(textBoxLetter);
            Controls.Add(textBoxX);
            Controls.Add(textBoxY);
            Controls.Add(buttonCreate);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            // Получаем данные из полей ввода
            string letter = textBoxLetter.Text.ToUpper();
            int.TryParse(textBoxX.Text, out int x);
            int.TryParse(textBoxY.Text, out int y);

            // Создаем элемент управления в зависимости от введенной буквы
            Control control = null;
            switch (letter)
            {
                case "К":
                    control = new Button { Text = "Кнопка", BackColor = Color.AliceBlue, Size = new Size(100, 50) };
                    break;
                case "П":
                    control = new TextBox { BackColor = Color.LightYellow, Size = new Size(100, 50) };
                    break;
                case "М":
                    control = new Label { Text = "Метка", BackColor = Color.LightGreen, Size = new Size(100, 50) };
                    break;
            }

            // Если элемент был создан, настраиваем его и добавляем на форму
            if (control != null)
            {
                control.Location = new Point(x, y);
                control.MouseEnter += (s, args) => Controls.Remove(control); // Удаление при наведении курсора
                Controls.Add(control);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
