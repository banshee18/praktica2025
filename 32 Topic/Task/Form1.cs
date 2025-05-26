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
            // ������� ������ � �������� ����������
            Button buttonLoadTours = new Button() { Text = "��������� ����", Left = 10, Top = 10, Width = 170, Height = 30 };
            buttonLoadTours.Click += ButtonLoadTours_Click;

            Button buttonDeleteTour = new Button() { Text = "������� ���", Left = 10, Top = 50, Width = 170, Height = 30 };
            buttonDeleteTour.Click += ButtonDeleteTour_Click;

            Button buttonAddTourist = new Button() { Text = "�������� �������", Left = 10, Top = 90, Width = 170, Height = 30 };
            buttonAddTourist.Click += ButtonAddTourist_Click;

            Button buttonUpdateTourist = new Button() { Text = "�������� �������", Left = 10, Top = 130, Width = 170, Height = 30 };
            buttonUpdateTourist.Click += ButtonUpdateTourist_Click;

            Button buttonLoadTourists = new Button() { Text = "��������� ��������", Left = 10, Top = 370, Width = 170, Height = 30 };
            buttonLoadTourists.Click += ButtonLoadTourists_Click;

            Button buttonDeleteTourist = new Button() { Text = "������� �������", Left = 10, Top = 410, Width = 170, Height = 30 };
            buttonDeleteTourist.Click += ButtonDeleteTourist_Click;

            Button buttonSaveChanges = new Button() { Text = "��������� ���������", Left = 10, Top = 450, Width = 170, Height = 30 };
            buttonSaveChanges.Click += ButtonSaveChanges_Click;

            dataGridViewTourists = new DataGridView() { Left = 200, Top = 320, Width = 620, Height = 150 };
            
            dataGridViewTours = new DataGridView() { Left = 200, Top = 10, Width = 620, Height = 300 };

            textBoxTourId = new TextBox() { Left = 10, Top = 170, Width = 170, Height = 30 };
            textBoxTourId.GotFocus += (s, e) => { if (textBoxTourId.Text == "������� id ����") textBoxTourId.Text = ""; };
            textBoxTourId.LostFocus += (s, e) => { if (textBoxTourId.Text == "") textBoxTourId.Text = "������� id ����"; };
            textBoxTourId.Text = "������� id ����";

            textBoxLastName = new TextBox() { Left = 10, Top = 210, Width = 170, Height = 30 };
            textBoxLastName.GotFocus += (s, e) => { if (textBoxLastName.Text == "������� �������") textBoxLastName.Text = ""; };
            textBoxLastName.LostFocus += (s, e) => { if (textBoxLastName.Text == "") textBoxLastName.Text = "������� �������"; };
            textBoxLastName.Text = "������� �������";

            textBoxFirstName = new TextBox() { Left = 10, Top = 250, Width = 170, Height = 30 };
            textBoxFirstName.GotFocus += (s, e) => { if (textBoxFirstName.Text == "������� ���") textBoxFirstName.Text = ""; };
            textBoxFirstName.LostFocus += (s, e) => { if (textBoxFirstName.Text == "") textBoxFirstName.Text = "������� ���"; };
            textBoxFirstName.Text = "������� ���";

            textBoxMiddleName = new TextBox() { Left = 10, Top = 290, Width = 170, Height = 30 };
            textBoxMiddleName.GotFocus += (s, e) => { if (textBoxMiddleName.Text == "������� ��������") textBoxMiddleName.Text = ""; };
            textBoxMiddleName.LostFocus += (s, e) => { if (textBoxMiddleName.Text == "") textBoxMiddleName.Text = "������� ��������"; };
            textBoxMiddleName.Text = "������� ��������";

            textBoxTouristId = new TextBox() { Left = 10, Top = 330, Width = 170, Height = 30 };
            textBoxTouristId.GotFocus += (s, e) => { if (textBoxTouristId.Text == "������� id �������") textBoxTouristId.Text = ""; };
            textBoxTouristId.LostFocus += (s, e) => { if (textBoxTouristId.Text == "") textBoxTouristId.Text = "������� id �������"; };
            textBoxTouristId.Text = "������� id �������";

            // ��������� �������� ���������� �� �����
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
            dataTableTours = new DataTable("����");
            dataTableTourists = new DataTable("�������");

            // ��������� DataTable � DataSet
            dataSet.Tables.Add(dataTableTours);
            dataSet.Tables.Add(dataTableTourists);

            // ������� ������� ��� ������
            dataTableTours.Columns.Add("���_����", typeof(int));
            dataTableTours.Columns.Add("��������", typeof(string));
            dataTableTours.Columns.Add("����_������", typeof(DateTime));
            dataTableTours.Columns.Add("����_���������", typeof(DateTime));
            dataTableTours.Columns.Add("����", typeof(decimal));

            dataTableTourists.Columns.Add("���_�������", typeof(int));
            dataTableTourists.Columns.Add("�������", typeof(string));
            dataTableTourists.Columns.Add("���", typeof(string));
            dataTableTourists.Columns.Add("��������", typeof(string));
            dataTableTourists.Columns.Add("���_����", typeof(int));

            // ������������� ��������� ����� ��� ������
            dataTableTours.PrimaryKey = new DataColumn[] { dataTableTours.Columns["���_����"] };
            dataTableTourists.PrimaryKey = new DataColumn[] { dataTableTourists.Columns["���_�������"] };

            // ��������� DataGridView � DataTable
            dataGridViewTours.DataSource = dataSet;
            dataGridViewTours.DataMember = "����";

            dataGridViewTourists.DataSource = dataSet;
            dataGridViewTourists.DataMember = "�������";
        }

        private void LoadTours()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string queryTours = "SELECT * FROM ����";

                    SQLiteDataAdapter adapterTours = new SQLiteDataAdapter(queryTours, connection);

                    dataTableTours.Clear();

                    adapterTours.Fill(dataTableTours);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� �������� ����� � ��������: " + ex.Message);
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
                    string query = "SELECT * FROM �������";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                    dataTableTourists.Clear();
                    adapter.Fill(dataTableTourists);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� �������� ������ � ��������: " + ex.Message);
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
                    string query = "DELETE FROM ���� WHERE ���_���� = @tourId";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@tourId", tourId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� �������� ����: " + ex.Message);
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
                    string query = "DELETE FROM ������� WHERE ���_������� = @touristId";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@touristId", touristId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� �������� �������: " + ex.Message);
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
                    string query = "INSERT INTO ������� (�������, ���, ��������, ���_����) VALUES (@lastName, @firstName, @middleName, @tourId)";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@middleName", middleName);
                    command.Parameters.AddWithValue("@tourId", tourId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� ���������� �������: " + ex.Message);
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
                    string query = "UPDATE ������� SET ������� = @lastName, ��� = @firstName, �������� = @middleName, ���_���� = @tourId WHERE ���_������� = @touristId";
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
                    MessageBox.Show("������ ��� ���������� ������ �������: " + ex.Message);
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

                    // ��������� ������� �����
                    SQLiteDataAdapter adapterTours = new SQLiteDataAdapter("SELECT * FROM ����", connection);
                    SQLiteCommandBuilder commandBuilderTours = new SQLiteCommandBuilder(adapterTours);
                    adapterTours.Update(dataTableTours);

                    // ��������� ������� ��������
                    SQLiteDataAdapter adapterTourists = new SQLiteDataAdapter("SELECT * FROM �������", connection);
                    SQLiteCommandBuilder commandBuilderTourists = new SQLiteCommandBuilder(adapterTourists);
                    adapterTourists.Update(dataTableTourists);

                    // ���������� �������� ���������
                    MessageBox.Show("������ ������� ���������!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� ���������� ������: " + ex.Message);
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
                MessageBox.Show("������� ���������� ID ����.");
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
                MessageBox.Show("������� ���������� ID �������.");
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
                MessageBox.Show("������� ���������� ID ����.");
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
                MessageBox.Show("������� ���������� ID ������� � ID ����.");
            }
        }

        private void ButtonSaveData_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
