using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PurrFect
{
    public partial class BookingForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");
        public BookingForm()
        {
            InitializeComponent();
            this.Load += BookingForm_Load;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            LoadPackage();
            LoadGroomer();

            DateMC.MinDate = DateTime.Today;

            TimeLB.Items.Add("10:00 AM");
            TimeLB.Items.Add("12:00 PM");
            TimeLB.Items.Add("2:00 PM");
            TimeLB.Items.Add("4:00 PM");
        }

        void LoadPackage()
        {
           con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM ServicePackage", con);
            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;

            while (dr.Read())
            {
                if (i == 0) 
                    { Package1RB.Text = dr["ServiceName"].ToString(); }
                else if (i == 1) 
                    { Package2RB.Text = dr["ServiceName"].ToString(); }
                else if (i == 2) 
                   { Package3RB.Text = dr["ServiceName"].ToString(); }

                i++;
            }

            con.Close();
        }

        void LoadGroomer()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Groomer", con);
            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;

            while (dr.Read())
            {
                if (i == 0) Groomer1RB.Text = dr["GroomerName"].ToString();
                else if (i == 1) Groomer2RB.Text = dr["GroomerName"].ToString();
                else if (i == 2) Groomer3RB.Text = dr["GroomerName"].ToString();
                else if (i == 3) Groomer4RB.Text = dr["GroomerName"].ToString();

                i++;
            }

            con.Close();

        }

        private void ServicePackageGB_Enter(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void Package2RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Package2RB.Checked)
                LoadPackageDetails(Package2RB.Text);
        }

        private void Package1RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Package1RB.Checked)
                LoadPackageDetails(Package1RB.Text);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            string package = "";
            string timeSlot = "";
            string groomer = "";
            DateTime bookingDate;
            bookingDate = DateMC.SelectionStart;

            //get package
            if (Package1RB.Checked)
                package = "Basic";
            else if (Package2RB.Checked)
                package = "Silver";
            else if (Package3RB.Checked)
                package = "Premium";

            //get time slot
            if (TimeLB.SelectedItem != null)
            {
                timeSlot = TimeLB.SelectedItem.ToString();
            }

            //get groomer
            if (Groomer1RB.Checked)
            {
                groomer = Groomer1RB.Text;
            }
            else if (Groomer2RB.Checked)
            {
                groomer = Groomer2RB.Text;
            }
            else if (Groomer3RB.Checked)
            {
                groomer = Groomer3RB.Text;
            }
            else if (Groomer4RB.Checked)
            {
                groomer = Groomer4RB.Text;
            }

            //check
            if (package == "")
            {
                MessageBox.Show("Please select package.");
                return;
            }

            if (groomer == "")
            {
                MessageBox.Show("Please select groomer.");
                return;
            }

            if (timeSlot == "")
            {
                MessageBox.Show("Please select time slot.");
                return;
            }

            if (bookingDate < DateTime.Today)
            {
                MessageBox.Show("Please select valid date.");
                return;
            }

            MessageBox.Show(
                "Package: " + package +
                "\nGroomer: " + groomer +
                "\nTime: " + timeSlot +
                "\nDate: " + bookingDate.ToShortDateString()
                );

            Booking.Package = package;
            Booking.groomer = groomer;
            Booking.TimeSlot = timeSlot;
            Booking.BookingDate = bookingDate;

            RegisterPetForm RegPet = new RegisterPetForm();
            RegPet.Show();
            this.Hide();
        }

        private void NextBTN_Click(object sender, EventArgs e)
        {
            string package = "";
            string groomer = "";
            string timeSlot = "";
            DateTime bookingDate = DateMC.SelectionStart;

            // package
            if (Package1RB.Checked) package = "Basic";
            else if (Package2RB.Checked) package = "Silver";
            else if (Package3RB.Checked) package = "Premium";

            // time
            if (TimeLB.SelectedItem != null)
                timeSlot = TimeLB.SelectedItem.ToString();

            // groomer
            if (Groomer1RB.Checked) groomer = Groomer1RB.Text;
            else if (Groomer2RB.Checked) groomer = Groomer2RB.Text;
            else if (Groomer3RB.Checked) groomer = Groomer3RB.Text;
            else if (Groomer4RB.Checked) groomer = Groomer4RB.Text;

            // VALIDATION (FIXED)
            if (string.IsNullOrEmpty(package))
            {
                MessageBox.Show("Please select package.");
                return;
            }

            if (string.IsNullOrEmpty(groomer))
            {
                MessageBox.Show("Please select groomer.");
                return;
            }

            if (string.IsNullOrEmpty(timeSlot))
            {
                MessageBox.Show("Please select time slot.");
                return;
            }

            if (bookingDate < DateTime.Today)
            {
                MessageBox.Show("Please select valid date.");
                return;
            }

            MessageBox.Show(
                $"Package: {package}\nGroomer: {groomer}\nTime: {timeSlot}\nDate: {bookingDate.ToShortDateString()}"
            );

            // optional pass data
            Booking.Package = package;
            Booking.groomer = groomer;
            Booking.TimeSlot = timeSlot;
            Booking.BookingDate = bookingDate;

            AddOnForm addon = new AddOnForm();
            addon.Show();
            this.Hide();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Package3RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Package3RB.Checked)
                LoadPackageDetails(Package3RB.Text);
        }

        private void TimeSlotLabel_Click(object sender, EventArgs e)
        {

        }

        private void GroomerLabel_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void LoadPackageDetails(string packageName)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM ServicePackage WHERE ServiceName=@name", con);

            cmd.Parameters.AddWithValue("@name", packageName);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string price = "RM " + dr["Price"].ToString();
                string desc = dr["Description"].ToString();

                if (packageName == "Basic")
                {
                    BasicPriceLabel.Text = price;
                    Package1RTB.Text = desc;
                }
                else if (packageName == "Silver")
                {
                    SilverPriceLabel.Text = price;
                    Package2RTB.Text = desc;
                }
                else if (packageName == "Premium")
                {
                    PremiumPackageLabel.Text = price;
                    Package3RTB.Text = desc;
                }
            }

            con.Close();

        }

        void LoadDescription(string packageName)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM ServicePackage WHERE ServiceName=@name",
                con);

            cmd.Parameters.AddWithValue("@name", packageName);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                if (packageName == "Basic")
                {
                    Package1RTB.Text = dr["Description"].ToString();
                }

                else if (packageName == "Silver")
                {
                    Package2RTB.Text = dr["Description"].ToString();
                }

                else if (packageName == "Premium")
                {
                    Package3RTB.Text = dr["Description"].ToString();
                }
            }

            con.Close();
        
        }

    }
}
