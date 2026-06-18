using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace PurrFect
{

    public partial class SalesChart : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");

        public SalesChart()
        {
            InitializeComponent();
        }

        private void SalesChart_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                con.Open();

                SqlDataAdapter adt = new SqlDataAdapter(
                    @"SELECT MONTH(PaymentDate) AS Month, 
                             SUM(Amount) AS TotalSales
                      FROM Payment
                      GROUP BY MONTH(PaymentDate)
                      ORDER BY MONTH(PaymentDate) ASC", con);

                adt.Fill(dt);

                con.Close();

              
                sales_chart.Series.Clear();
                sales_chart.ChartAreas[0].AxisX.Title = "Month";
                sales_chart.ChartAreas[0].AxisY.Title = "Total Sales (RM)";
                sales_chart.ChartAreas[0].AxisX.Interval = 1;

                Series s = new Series("Sales");
                s.ChartType = SeriesChartType.Column;

                sales_chart.Series.Add(s);

                
                var chartData = dt.AsEnumerable()
                    .Select(row => new
                    {
                        Month = row.Field<int>("Month"),
                        Total = row.Field<decimal>("TotalSales")
                    });

                foreach (var item in chartData)
                {
                    string monthName =
                        System.Globalization.CultureInfo.CurrentCulture
                        .DateTimeFormat
                        .GetAbbreviatedMonthName(item.Month);

                    s.Points.AddXY(monthName, item.Total);
                }

               
                decimal totalSales = chartData.Sum(x => x.Total);
                decimal maxSales = chartData.Max(x => x.Total);
                decimal avgSales = chartData.Average(x => x.Total);

                MessageBox.Show(
                    "TOTAL SALES: RM " + totalSales.ToString("0.00") +
                    "\nHIGHEST MONTH SALES: RM " + maxSales.ToString("0.00") +
                    "\nAVERAGE MONTH SALES: RM " + avgSales.ToString("0.00")
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
