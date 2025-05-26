using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load); // ���������� ����� � ������� Load
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // ������� ����� ������� ��� ��������� �������
            var chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // ������� ������ Series (��� ����� ������)
            var series = new Series("MySeries");
            series.ChartType = SeriesChartType.Line;
            chart1.Series.Add(series);

            // ������ ��� h
            double h = 0.1;

            // ��������� ������� �� -10 �� 10
            for (double x = -10; x <= 10; x += h)
            {
                double y = Math.Abs(x);
                series.Points.AddXY(x, y);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
