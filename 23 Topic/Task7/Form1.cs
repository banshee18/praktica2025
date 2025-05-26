using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task7
{
    public partial class Form1 : Form
    {
        private int[,] matrix15x15 = new int[15, 15];
        private int[,] matrix10x20 = new int[10, 20];
        private int[] arrayN = new int[10];
        private Random random = new Random(); // ��������� random �����

        public Form1()
        {
            InitializeComponent();
            InitializeMatrixControls();
        }

        private void InitializeMatrixControls()
        {
            // ��������� ����������� ������� � ��������
            FindMaxButton.Click += FindMaxButton_Click;
            CountPositiveButton.Click += CountPositivesButton_Click;
        }


        private void DisplayArrayInDataGridView(int[,] array, DataGridView dataGridView)
        {
            dataGridView.ColumnCount = array.GetLength(1);
            dataGridView.RowCount = array.GetLength(0);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    dataGridView[j, i].Value = array[i, j];
                }
            }
        }

        private void FindMaxButton_Click(object sender, EventArgs e)
        {
            // ���������� ������� 15x15 ���������� ������� � ����� ������������� ��������...
            int max = int.MinValue;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    matrix15x15[i, j] = random.Next(-100, 100);
                    if (i + j == 14 && matrix15x15[i, j] > max)
                    {
                        max = matrix15x15[i, j];
                    }
                }
            }
            DisplayArrayInDataGridView(matrix15x15, MassiveGridView);
            ResultTextBox.Text = $"������������ ������� �� �������������� ���������: {max}";
        }


        private void CountPositivesButton_Click(object sender, EventArgs e)
        {
            // ���������� ������� A(10,20) ���������� ������� � ������� ������������� ���������...
            for (int i = 0; i < 10; i++)
            {
                int count = 0;
                for (int j = 0; j < 20; j++)
                {
                    matrix10x20[i, j] = random.Next(-100, 100);
                    if (matrix10x20[i, j] > 0)
                    {
                        count++;
                    }
                }
                arrayN[i] = count;
            }

            DisplayArrayInDataGridView(matrix10x20, MassiveGridView);
            // ����� ������� N...
            MessageBox.Show("���������� ������������� ��������� � ������ ������: " + string.Join(", ", arrayN));
        }

        private void MassiveGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}