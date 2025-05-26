using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=C:\\sqlite\\DBTur_firm.sqlite;Version=3;";
        private DataGridView dataGridViewTours;
        private TextBox textBoxTourId, textBoxLastName, textBoxFirstName, textBoxMiddleName, textBoxTouristId;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Создаем кнопки и элементы управления
            Button buttonLoadTours = new Button() { Text = "Загрузить туры", Left = 10, Top = 10, Width = 170, Height = 30 };
            buttonLoadTours.Click += new EventHandler(ButtonLoadTours_Click);

            Button buttonDeleteTour = new Button() { Text = "Удалить тур", Left = 10, Top = 50, Width = 170, Height = 30 };
            buttonDeleteTour.Click += new EventHandler(ButtonDeleteTour_Click);

            Button buttonAddTourist = new Button() { Text = "Добавить туриста", Left = 10, Top = 90, Width = 170, Height = 30 };
            buttonAddTourist.Click += new EventHandler(ButtonAddTourist_Click);

            Button buttonUpdateTourist = new Button() { Text = "Изменить туриста", Left = 10, Top = 130, Width = 170, Height = 30 };
            buttonUpdateTourist.Click += new EventHandler(ButtonUpdateTourist_Click);

            Button buttonLoadTourists = new Button() { Text = "Загрузить туристов", Left = 10, Top = 370, Width = 170, Height = 30 };
            buttonLoadTourists.Click += new EventHandler(ButtonLoadTourists_Click);

            Button buttonDeleteTourist = new Button() { Text = "Удалить туриста", Left = 10, Top = 410, Width = 170, Height = 30 };
            buttonDeleteTourist.Click += new EventHandler(ButtonDeleteTourist_Click);

            dataGridViewTours = new DataGridView() { Left = 200, Top = 10, Width = 600, Height = 430 };

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
            this.Controls.Add(dataGridViewTours);
            this.Controls.Add(textBoxTourId);
            this.Controls.Add(textBoxLastName);
            this.Controls.Add(textBoxFirstName);
            this.Controls.Add(textBoxMiddleName);
            this.Controls.Add(textBoxTouristId);
        }

        private void LoadTours()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Туры";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewTours.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке туров: " + ex.Message);
                }
            }
        }

        private void LoadTourists()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Туристы";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewTours.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке туристов: " + ex.Message);
                }
            }
        }


        private void DeleteTour(int tourId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM Туры WHERE Код_тура = @tourId";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                    adapter.DeleteCommand = new SQLiteCommand(query, connection);
                    adapter.DeleteCommand.Parameters.AddWithValue("@tourId", tourId);
                    connection.Open();
                    adapter.DeleteCommand.ExecuteNonQuery();
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
                    string query = "DELETE FROM Туристы WHERE Код_туриста = @touristId";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                    adapter.DeleteCommand = new SQLiteCommand(query, connection);
                    adapter.DeleteCommand.Parameters.AddWithValue("@touristId", touristId);
                    connection.Open();
                    adapter.DeleteCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении туриста: " + ex.Message);
                }
            }
        }


        private void AddTourist(string lastName, string firstName, string middleName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Туристы (Фамилия, Имя, Отчество) VALUES (@lastName, @firstName, @middleName)";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                    adapter.InsertCommand = new SQLiteCommand(query, connection);
                    adapter.InsertCommand.Parameters.AddWithValue("@lastName", lastName);
                    adapter.InsertCommand.Parameters.AddWithValue("@firstName", firstName);
                    adapter.InsertCommand.Parameters.AddWithValue("@middleName", middleName);
                    connection.Open();
                    adapter.InsertCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении туриста: " + ex.Message);
                }
            }
        }


        private void UpdateTourist(int touristId, string lastName, string firstName, string middleName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE Туристы SET Фамилия = @lastName, Имя = @firstName, Отчество = @middleName WHERE Код_туриста = @touristId";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                    adapter.UpdateCommand = new SQLiteCommand(query, connection);
                    adapter.UpdateCommand.Parameters.AddWithValue("@touristId", touristId);
                    adapter.UpdateCommand.Parameters.AddWithValue("@lastName", lastName);
                    adapter.UpdateCommand.Parameters.AddWithValue("@firstName", firstName);
                    adapter.UpdateCommand.Parameters.AddWithValue("@middleName", middleName);
                    connection.Open();
                    adapter.UpdateCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении туриста: " + ex.Message);
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
                MessageBox.Show("Введите корректный Код тура");
            }
        }

        private void ButtonDeleteTourist_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTouristId.Text, out int touristId))
            {
                DeleteTourist(touristId);
                LoadTourists();
            }
            else
            {
                MessageBox.Show("Введите корректный Код туриста");
            }
        }

        private void ButtonAddTourist_Click(object sender, EventArgs e)
        {
            string lastName = textBoxLastName.Text;
            string firstName = textBoxFirstName.Text;
            string middleName = textBoxMiddleName.Text;
            AddTourist(lastName, firstName, middleName);
            LoadTourists();
        }

        private void ButtonUpdateTourist_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTouristId.Text, out int touristId))
            {
                string lastName = textBoxLastName.Text;
                string firstName = textBoxFirstName.Text;
                string middleName = textBoxMiddleName.Text;
                UpdateTourist(touristId, lastName, firstName, middleName);
                LoadTourists();
            }
            else
            {
                MessageBox.Show("Введите корректный Код туриста");
            }
        }
    }
}
