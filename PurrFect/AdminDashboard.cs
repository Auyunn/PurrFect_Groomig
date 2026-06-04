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
using System.Data.SqlClient;


namespace PurrFect
{
    public partial class AdminDashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void SalesLabel_Click(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
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






        }
    }
}
