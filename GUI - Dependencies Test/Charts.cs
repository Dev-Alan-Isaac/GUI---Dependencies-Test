using System.Windows.Forms.DataVisualization.Charting;

namespace GUI___Dependencies_Test
{
    public partial class Charts : UserControl
    {
        public Charts()
        {
            InitializeComponent();
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            // Create a new chart
            Chart pieChart = new Chart();

            // Create a chart area
            ChartArea chartArea = new ChartArea();
            pieChart.ChartAreas.Add(chartArea);

            // Create a series and add data points
            Series series = new Series() { ChartType = SeriesChartType.Pie };
            series.Points.AddXY("Category1", 10);
            series.Points.AddXY("Category2", 20);
            series.Points.AddXY("Category3", 30);
            series.Points.AddXY("Category4", 40);

            // Add the series to the chart
            pieChart.Series.Add(series);

            // Set the size and position of the chart
            pieChart.Width = 300;
            pieChart.Height = 300;
            pieChart.Left = 10;
            pieChart.Top = 10;

            // Add the chart to the form
            this.Controls.Add(pieChart);
        }
    }
}
