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
    public partial class Best_Selling_Service : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");

        public Best_Selling_Service()
        {
            InitializeComponent();
        }



        private void Best_Selling_Service_Load(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void service_chart_Click(object sender, EventArgs e)
        {

        }

        private void LoadChart()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();

                string query =
                    "SELECT s.ServiceName AS Service, COUNT(b.BookingID) AS TotalServiceBooked " +
                    "FROM Booking b " +
                    "JOIN ServicePackage s ON b.ServiceID = s.ServiceID " +
                    "GROUP BY s.ServiceName " +
                    "ORDER BY TotalServiceBooked DESC";

                SqlDataAdapter adt = new SqlDataAdapter(query, con);
                adt.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return;
            }
            finally
            {
                con.Close();
            }

            
            service_chart.Series.Clear();
            service_chart.ChartAreas[0].AxisX.Title = "Service";
            service_chart.ChartAreas[0].AxisY.Title = "Total Bookings";
            service_chart.ChartAreas[0].AxisX.Interval = 1;

            Series s = new Series("Best Selling Service");
            s.ChartType = SeriesChartType.Column;

            service_chart.Series.Add(s);

           
            var chartData = dt.AsEnumerable()
                               .Select(row => new
                               {
                                   Service = row["Service"].ToString(),
                                   Total = Convert.ToInt32(row["TotalServiceBooked"])
                               })
                               .OrderByDescending(x => x.Total);

            foreach (var item in chartData)
            {
                s.Points.AddXY(item.Service, item.Total);
            }

            
            var topService = chartData.FirstOrDefault();

            if (topService != null)
            {
                this.Text = "Top Service: " + topService.Service +
                            " (" + topService.Total + " bookings)";
            }
        }
    
    }
}


