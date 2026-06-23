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
        private SqlConnection con;

       
        protected string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True";

        public class InvalidBookingException : Exception
        {
            public InvalidBookingException(string message) : base(message) { }
        }

        public void ValidateBookingDate(DateTime date)
        {
            if (date < DateTime.Today)
            {
                throw new InvalidBookingException("Date chosen cannot be a past date!");
            }
        }

        // Delegate
        public delegate void LogHandler(string msg);

        // Constructor
        public BookingForm()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectionString);
            this.Load += BookingForm_Load;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            var defaultSlots = new List<string> { "10:00 AM", "12:00 PM", "2:00 PM", "4:00 PM" };
            defaultSlots.ForEach(slot => TimeLB.Items.Add(slot));

            LoadPackage();
            LoadGroomer();

            DateMC.MinDate = DateTime.Today;

            if (Booking.Package == "Basic") Package1RB.Checked = true;
            else if (Booking.Package == "Silver") Package2RB.Checked = true;
            else if (Booking.Package == "Premium") Package3RB.Checked = true;

            if (!string.IsNullOrEmpty(Booking.TimeSlot))
            {
                TimeLB.SelectedItem = Booking.TimeSlot;
            }

            if (!string.IsNullOrEmpty(Booking.groomer))
            {
                if (Groomer1RB.Text == Booking.groomer) Groomer1RB.Checked = true;
                else if (Groomer2RB.Text == Booking.groomer) Groomer2RB.Checked = true;
                else if (Groomer3RB.Text == Booking.groomer) Groomer3RB.Checked = true;
                else if (Groomer4RB.Text == Booking.groomer) Groomer4RB.Checked = true;
            }

            if (Booking.BookingDate >= DateMC.MinDate)
            {
                DateMC.SetDate(Booking.BookingDate);
            }
        }

        void LoadPackage()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ServicePackage", con);
                SqlDataReader dr = cmd.ExecuteReader();

                List<string> packages = new List<string>();
                while (dr.Read())
                {
                    packages.Add(dr["ServiceName"].ToString());
                }
                dr.Close();

                if (packages.Count > 0) Package1RB.Text = packages[0];
                if (packages.Count > 1) Package2RB.Text = packages[1];
                if (packages.Count > 2) Package3RB.Text = packages[2];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ralat Database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        void LoadGroomer()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Groomer", con);
                SqlDataReader dr = cmd.ExecuteReader();

                List<string> groomers = new List<string>();
                while (dr.Read())
                {
                    groomers.Add(dr["GroomerName"].ToString());
                }
                dr.Close();

                if (groomers.Count > 0) Groomer1RB.Text = groomers[0];
                if (groomers.Count > 1) Groomer2RB.Text = groomers[1];
                if (groomers.Count > 2) Groomer3RB.Text = groomers[2];
                if (groomers.Count > 3) Groomer4RB.Text = groomers[3];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ralat memuatkan groomer: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Package1RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Package1RB.Checked) LoadPackageDetails(Package1RB.Text);
        }

        private void Package2RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Package2RB.Checked) LoadPackageDetails(Package2RB.Text);
        }

        private void Package3RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Package3RB.Checked) LoadPackageDetails(Package3RB.Text);
        }

        void LoadPackageDetails(string packageName)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ServicePackage WHERE ServiceName=@name", con);
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
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            RegisterPetForm reg = new RegisterPetForm();
            reg.Show();
            this.Hide();
        }

        private void NextBTN_Click(object sender, EventArgs e)
        {
            string package = "";
            string groomer = "";
            string timeSlot = "";
            DateTime bookingDate = DateMC.SelectionStart;

            if (Package1RB.Checked) package = Package1RB.Text;
            else if (Package2RB.Checked) package = Package2RB.Text;
            else if (Package3RB.Checked) package = Package3RB.Text;

            if (TimeLB.SelectedItem != null) timeSlot = TimeLB.SelectedItem.ToString();

            if (Groomer1RB.Checked) groomer = Groomer1RB.Text;
            else if (Groomer2RB.Checked) groomer = Groomer2RB.Text;
            else if (Groomer3RB.Checked) groomer = Groomer3RB.Text;
            else if (Groomer4RB.Checked) groomer = Groomer4RB.Text;

            try
            {
                ValidateBookingDate(bookingDate);

                if (string.IsNullOrEmpty(package) || string.IsNullOrEmpty(groomer) || string.IsNullOrEmpty(timeSlot))
                {
                    throw new InvalidBookingException("Please make sure everything is selected!");
                }

                con.Open();

                SqlCommand cmdService = new SqlCommand("SELECT ServiceID FROM ServicePackage WHERE ServiceName = @pName", con);
                cmdService.Parameters.AddWithValue("@pName", package);
                object sID = cmdService.ExecuteScalar();
                if (sID != null) Booking.ServiceID = Convert.ToInt32(sID);

                SqlCommand cmdGroomer = new SqlCommand("SELECT GroomerID FROM Groomer WHERE GroomerName = @gName", con);
                cmdGroomer.Parameters.AddWithValue("@gName", groomer);
                object gID = cmdGroomer.ExecuteScalar();
                if (gID != null) Booking.GroomerID = Convert.ToInt32(gID);
            }
            catch (InvalidBookingException ex)
            {
                LogHandler log = msg => MessageBox.Show(msg, "Validation Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                log(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error System: " + ex.Message);
                return;
            }
            finally
            {
                con.Close();
            }

            var validSlotsCollection = TimeLB.Items.Cast<string>().ToList();
            bool isSlotValid = validSlotsCollection.Any(s => s == timeSlot);

            if (isSlotValid)
            {
                Booking.Package = package;
                Booking.groomer = groomer;
                Booking.TimeSlot = timeSlot;
                Booking.BookingDate = bookingDate;

                AddOnForm addon = new AddOnForm();
                addon.Show();
                this.Hide();
            }
        }

       
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void BookingForm_Load_1(object sender, EventArgs e) { }
        private void TimeSlotLabel_Click(object sender, EventArgs e) { }
        private void GroomerLabel_Click(object sender, EventArgs e) { }
        private void richTextBox2_TextChanged(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void radioButton4_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void ServicePackageGB_Enter(object sender, EventArgs e) { }
        private void DateLabel_Click(object sender, EventArgs e) { }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}