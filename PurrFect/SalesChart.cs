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
            DataTable dt = new DataTable();
            con.Open();

            SqlDataAdapter adt = new SqlDataAdapter(
                "SELECT MONTH(PaymentDate) AS Month, SUM(Amount) AS TotalSales " +
                "FROM Payment " +
                "GROUP BY MONTH(PaymentDate)" +
                "ORDER BY MONTH(PaymentDate) ASC", con
                );

            adt.Fill(dt);

            con.Close();

            sales_chart.Series.Clear();
            sales_chart.ChartAreas[0].AxisX.Title = "Month";
            sales_chart.ChartAreas[0].AxisY.Title = "Total Sales (RM)";
            sales_chart.ChartAreas[0].AxisX.Interval = 1;


            Series s = new Series("Sales");
            s.ChartType = SeriesChartType.Column;

            sales_chart.Series.Add(s);

            foreach(DataRow row in dt.Rows)
            {
                int MonthNum = Convert.ToInt32(row["Month"]);
                string monthName = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(MonthNum);
                s.Points.AddXY(
                    row["Month"].ToString(),
                    Convert.ToDecimal(row["TotalSales"])
                );
            }
        }


    }
}
