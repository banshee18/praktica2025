using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data Source=C:\\sqlite\\DBTur_firm.sqlite;Version=3;";
        private DataSet dataSet;
        private DataTable dataTableTours, dataTableTourists;
        private DataGridView dataGridViewTours, dataGridViewTourists;
        private TextBox textBoxTourId, textBoxLastName, textBoxFirstName, textBoxMiddleName, textBoxTouristId;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
            InitializeDataSet();
        }

        private void InitializeCustomComponents()
        {
            // Создаем кнопки и элементы управления
            Button buttonLoadTours = new Button() { Text = "Загрузить туры", Left = 10, Top = 10, Width = 170, Height = 30 };
            buttonLoadTours.Click += ButtonLoadTours_Click;

            Button buttonDeleteTour = new Button() { Text = "Удалить тур", Left = 10, Top = 50, Width = 170, Height = 30 };
            buttonDeleteTour.Click += ButtonDeleteTour_Click;

            Button buttonAddTourist = new Button() { Text = "Добавить туриста", Left = 10, Top = 90, Width = 170, Height = 30 };
            buttonAddTourist.Click += ButtonAddTourist_Click;

            Button buttonUpdateTourist = new Button() { Text = "Изменить туриста", Left = 10, Top = 130, Width = 170, Height = 30 };
            buttonUpdateTourist.Click += ButtonUpdateTourist_Click;

            Button buttonLoadTourists = new Button() { Text = "Загрузить туристов", Left = 10, Top = 370, Width = 170, Height = 30 };
            buttonLoadTourists.Click += ButtonLoadTourists_Click;

            Button buttonDeleteTourist = new Button() { Text = "Удалить туриста", Left = 10, Top = 410, Width = 170, Height = 30 };
            buttonDeleteTourist.Click += ButtonDeleteTourist_Click;

            Button buttonSaveChanges = new Button() { Text = "Сохранить изменения", Left = 10, Top = 450, Width = 170, Height = 30 };
            buttonSaveChanges.Click += ButtonSaveChanges_Click;

            dataGridViewTourists = new DataGridView() { Left = 200, Top = 320, Width = 620, Height = 150 };
            
            dataGridViewTours = new DataGridView() { Left = 200, Top = 10, Width = 620, Height = 300 };

            textBoxTourId = new TextBox() { Left = 10, Top = 170, Width = 170, Height = 30 };
            textBoxTourId.GotFocus += (s, e) => { if (textBoxTourId.Text == "введите id тура") textBoxTourId.Text = ""; };
            textBoxTourId.LostFocus += (s, e) => { if (textBoxTourId.Text == "") textBoxTourId.Text = "введите id тура"; };
            textBoxTourId.Text = "введите id тура";

            textBoxLastName = new TextBox() { Left = 10, Top = 210, Width = 170, Height = 30 };
            textBoxLastName.GotFocus += (s, e) => { if (textBoxLastName.Text == "введите фамилия") textBoxLastName.Text = ""; };
            textBoxLastName.LostFocus += (s, e) => { if (textBoxLastName.Text == "") textBoxLastName.Text = "введите фамилия"; };
            textBoxLastName.Text = "введите фамилия";

            textBoxFirstName = new TextBox() { Left = 10, Top = 250, Width = 170, Height = 30 };
            textBoxFirstName.GotFocus += (s, e) => { if (textBoxFirstName.Text == "введите имя") textBoxFirstName.Text = ""; };
            textBoxFirstName.LostFocus += (s, e) => { if (textBoxFirstName.Text == "") textBoxFirstName.Text = "введите имя"; };
            textBoxFirstName.Text = "введите имя";

            textBoxMiddleName = new TextBox() { Left = 10, Top = 290, Width = 170, Height = 30 };
            textBoxMiddleName.GotFocus += (s, e) => { if (textBoxMiddleName.Text == "введите отчество") textBoxMiddleName.Text = ""; };
            textBoxMiddleName.LostFocus += (s, e) => { if (textBoxMiddleName.Text == "") textBoxMiddleName.Text = "введите отчество"; };
            textBoxMiddleName.Text = "введите отчество";

            textBoxTouristId = new TextBox() { Left = 10, Top = 330, Width = 170, Height = 30 };
            textBoxTouristId.GotFocus += (s, e) => { if (textBoxTouristId.Text == "введите id туриста") textBoxTouristId.Text = ""; };
            textBoxTouristId.LostFocus += (s, e) => { if (textBoxTouristId.Text == "") textBoxTouristId.Text = "введите id туриста"; };
            textBoxTouristId.Text = "введите id туриста";

            // Добавляем элементы управления на форму
            this.Controls.Add(buttonLoadTours);
            this.Controls.Add(buttonDeleteTour);
            this.Controls.Add(buttonAddTourist);
            this.Controls.Add(buttonUpdateTourist);
            this.Controls.Add(buttonLoadTourists);
            this.Controls.Add(buttonDeleteTourist);
            this.Controls.Add(buttonSaveChanges);
            this.Controls.Add(dataGridViewTours);
            this.Controls.Add(dataGridViewTourists);
            this.Controls.Add(textBoxTourId);
            this.Controls.Add(textBoxLastName);
            this.Controls.Add(textBoxFirstName);
            this.Controls.Add(textBoxMiddleName);
            this.Controls.Add(textBoxTouristId);
        }

        private void InitializeDataSet()
        {
            dataSet = new DataSet();
            dataTableTours = new DataTable("Туры");
            dataTableTourists = new DataTable("Туристы");

            // Добавляем DataTable в DataSet
            dataSet.Tables.Add(dataTableTours);
            dataSet.Tables.Add(dataTableTourists);

            // Создаем колонки для таблиц
            dataTableTours.Columns.Add("Код_тура", typeof(int));
            dataTableTours.Columns.Add("Название", typeof(string));
            dataTableTours.Columns.Add("Дата_начала", typeof(DateTime));
            dataTableTours.Columns.Add("Дата_окончания", typeof(DateTime));
            dataTableTours.Columns.Add("Цена", typeof(decimal));

            dataTableTourists.Columns.Add("Код_туриста", typeof(int));
            dataTableTourists.Columns.Add("Фамилия", typeof(string));
            dataTableTourists.Columns.Add("Имя", typeof(string));
            dataTableTourists.Columns.Add("Отчество", typeof(string));
            dataTableTourists.Columns.Add("Код_тура", typeof(int));

            // Устанавливаем первичные ключи для таблиц
            dataTableTours.PrimaryKey = new DataColumn[] { dataTableTours.Columns["Код_тура"] };
            dataTableTourists.PrimaryKey = new DataColumn[] { dataTableTourists.Columns["Код_туриста"] };

            // Связываем DataGridView с DataTable
            dataGridViewTours.DataSource = dataSet;
            dataGridViewTours.DataMember = "Туры";

            dataGridViewTourists.DataSource = dataSet;
            dataGridViewTourists.DataMember = "Туристы";
        }

        private void LoadTours()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string queryTours = "SELECT * FROM Туры";

                    SQLiteDataAdapter adapterTours = new SQLiteDataAdapter(queryTours, connection);

                    dataTableTours.Clear();

                    adapterTours.Fill(dataTableTours);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке туров и туристов: " + ex.Message);
                }
            }
        }

        private void LoadTourists()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Туристы";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                    dataTableTourists.Clear();
                    adapter.Fill(dataTableTourists);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных о туристах: " + ex.Message);
                }
            }
        }

        private void DeleteTour(int tourId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Туры WHERE Код_тура = @tourId";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@tourId", tourId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении тура: " + ex.Message);
                }
            }
        }

        private void DeleteTourist(int touristId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Туристы WHERE Код_туриста = @touristId";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@touristId", touristId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении туриста: " + ex.Message);
                }
            }
        }

        private void AddTourist(string lastName, string firstName, string middleName, int tourId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Туристы (Фамилия, Имя, Отчество, Код_тура) VALUES (@lastName, @firstName, @middleName, @tourId)";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@middleName", middleName);
                    command.Parameters.AddWithValue("@tourId", tourId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении туриста: " + ex.Message);
                }
            }
        }

        private void UpdateTourist(int touristId, string lastName, string firstName, string middleName, int tourId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Туристы SET Фамилия = @lastName, Имя = @firstName, Отчество = @middleName, Код_тура = @tourId WHERE Код_туриста = @touristId";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@touristId", touristId);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@middleName", middleName);
                    command.Parameters.AddWithValue("@tourId", tourId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении данных туриста: " + ex.Message);
                }
            }
        }

        private void ButtonSaveChanges_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Обновляем таблицу туров
                    SQLiteDataAdapter adapterTours = new SQLiteDataAdapter("SELECT * FROM Туры", connection);
                    SQLiteCommandBuilder commandBuilderTours = new SQLiteCommandBuilder(adapterTours);
                    adapterTours.Update(dataTableTours);

                    // Обновляем таблицу туристов
                    SQLiteDataAdapter adapterTourists = new SQLiteDataAdapter("SELECT * FROM Туристы", connection);
                    SQLiteCommandBuilder commandBuilderTourists = new SQLiteCommandBuilder(adapterTourists);
                    adapterTourists.Update(dataTableTourists);

                    // Отображаем успешное сообщение
                    MessageBox.Show("Данные успешно сохранены!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
                }
            }
        }


        private void ButtonLoadTours_Click(object sender, EventArgs e)
        {
            LoadTours();
        }

        private void ButtonLoadTourists_Click(object sender, EventArgs e)
        {
            LoadTourists();
        }

        private void ButtonDeleteTour_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTourId.Text, out int tourId))
            {
                DeleteTour(tourId);
                LoadTours();
            }
            else
            {
                MessageBox.Show("Введите корректный ID тура.");
            }
        }

        private void ButtonDeleteTourist_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTouristId.Text, out int touristId))
            {
                DeleteTourist(touristId);
                LoadTours();
            }
            else
            {
                MessageBox.Show("Введите корректный ID туриста.");
            }
        }

        private void ButtonAddTourist_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTourId.Text, out int tourId))
            {
                AddTourist(textBoxLastName.Text, textBoxFirstName.Text, textBoxMiddleName.Text, tourId);
                LoadTours();
            }
            else
            {
                MessageBox.Show("Введите корректный ID тура.");
            }
        }

        private void ButtonUpdateTourist_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTouristId.Text, out int touristId) && int.TryParse(textBoxTourId.Text, out int tourId))
            {
                UpdateTourist(touristId, textBoxLastName.Text, textBoxFirstName.Text, textBoxMiddleName.Text, tourId);
                LoadTours();
            }
            else
            {
                MessageBox.Show("Введите корректный ID туриста и ID тура.");
            }
        }

        private void ButtonSaveData_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
