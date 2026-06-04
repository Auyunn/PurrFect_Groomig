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
    public partial class ThankYouForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");

        public ThankYouForm()
        {
            InitializeComponent();
        }

        public static int BookingID;

        private void IDTagLabel_Click(object sender, EventArgs e)
        {

        }

        private void ReminderLabel_Click(object sender, EventArgs e)
        {

        }

        private void ThankYouForm_Load(object sender, EventArgs e)
        {

            con.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT MAX(BookingID) FROM Booking", con);
                object result = cmd.ExecuteScalar();

            if (result != null)
            {
                IDlabel.Text = result.ToString();
            }

            con.Close();

             ReminderTagLabel.Text = 
                "Please show your booking id at the counter on " + 
                Booking.BookingDate.ToString("dd MMMM yyyy") + " at " + 
                Booking.TimeSlot + " to redeem your booking.";

        }

        private void IDlabel_Click(object sender, EventArgs e)
        {

        }

        private void ReminderTagLabel_Click(object sender, EventArgs e)
        {
        }
    }
}
