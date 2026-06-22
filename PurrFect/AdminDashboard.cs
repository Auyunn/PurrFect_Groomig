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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPayment ap = new AdminPayment();
            ap.Show();
=======
       

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bookingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ManageBooking mb = new ManageBooking();

            Panel.Visible = false;
            WelcomeLabel.Visible = false;

            mb.MdiParent = this;

            mb.FormClosed += (s, args) =>
            {
                Panel.Visible = true;
                WelcomeLabel.Visible = true;
            };

            mb.WindowState = FormWindowState.Maximized;
            mb.Show();
        }

        private void groomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageGroomer mb = new ManageGroomer();

            Panel.Visible = false;
            WelcomeLabel.Visible = false;

            mb.MdiParent = this;

            mb.FormClosed += (s, args) =>
            {
                Panel.Visible = true;
                WelcomeLabel.Visible = true;
            };

            mb.WindowState = FormWindowState.Maximized;
            mb.Show();
>>>>>>> 0b3e1c66058459d9c2d90964d4938d02ddf56b1d
        }
    }
}
