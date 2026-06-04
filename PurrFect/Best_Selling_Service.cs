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
            DataTable dt = new DataTable();
            con.Open();

           string query =
                       "SELECT s.ServiceName AS Service, COUNT(b.BookingID) AS TotalServiceBooked " +
                       "FROM Booking b " +
                       "JOIN ServicePackage s ON b.ServiceID = s.ServiceID " +
                       "GROUP BY s.ServiceName " +
                       "ORDER BY TotalServiceBooked DESC";              

            SqlDataAdapter adt = new SqlDataAdapter(query, con);
            adt.Fill(dt);
            con.Close();

            service_chart.Series.Clear();
            service_chart.ChartAreas[0].AxisX.Title = "Service";
            service_chart.ChartAreas[0].AxisY.Title = "Preferred Service";
            service_chart.ChartAreas[0].AxisX.Interval = 1;

            service_chart.ChartAreas[0].AxisX.LabelStyle.IsStaggered = false; // Ensure labels are not staggered
            service_chart.ChartAreas[0].AxisX.LabelStyle.Angle = 0;


            Series s = new Series("Best Selling");
            s.ChartType = SeriesChartType.Column;

            service_chart.Series.Add(s);

            foreach (DataRow row in dt.Rows)
            {
                s.Points.AddXY(
                    row["Service"].ToString(),
                    Convert.ToInt32(row["TotalServiceBooked"])
                );
            }
        }

        private void service_chart_Click(object sender, EventArgs e)
        {

        }
    }
}


