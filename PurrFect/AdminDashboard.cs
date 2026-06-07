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
            SalesChart sc = new SalesChart();
            Panel.Visible = false;
            WelcomeLabel.Visible = false;
            sc.MdiParent = this;
            sc.FormClosed += (s, args) =>
            {
                Panel.Visible = true;
                WelcomeLabel.Visible = true;
            };
            sc.WindowState = FormWindowState.Maximized;
            sc.Show();




        }

        private void BestSellingMS_Click(object sender, EventArgs e)
        {
            Best_Selling_Service bss = new Best_Selling_Service();
            Panel.Visible = false;
            WelcomeLabel.Visible = false;
            bss.MdiParent = this; //put form in dashboard

            bss.FormClosed += (s, args) =>
            {
                Panel.Visible = true;
                WelcomeLabel.Visible = true;
            };

            bss.WindowState = FormWindowState.Maximized;
            bss.Show();

        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ManageCustomer cc = new ManageCustomer();

            Panel.Visible = false;
            WelcomeLabel.Visible = false;

            cc.MdiParent = this;
            cc.FormClosed += (s, args) =>
            {
                Panel.Visible = true;
                WelcomeLabel.Visible = true;
            };
            cc.WindowState = FormWindowState.Maximized;

            cc.Show();
        }
    }
}
