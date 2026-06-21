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
    
        public partial class ManageBooking : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");

        
        public string CurrentUserRole { get; set; } = "Admin";

        public ManageBooking()
        {
            InitializeComponent();
        }

        private void txtbxID_TextChanged(object sender, EventArgs e)
        {
        }

        
        void LoadBooking()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Booking", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBooking.DataSource = dt;

                if (dgvBooking.Columns["TotalPrice"] != null)
                {
                    dgvBooking.Columns["TotalPrice"].DefaultCellStyle.Format = "N2";
                }

                
                CalculateSystemMetrics(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load booking data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void CalculateSystemMetrics(DataTable dt)
        {
            
            string[] statusTypes = new string[] { "Pending", "Completed", "Cancelled" };

           
            List<decimal> priceList = new List<decimal>();

            int rowCount = dt.Rows.Count;
            decimal totalSum = 0;

            for (int i = 0; i < rowCount; i++)
            {
                if (dt.Rows[i]["TotalPrice"] != DBNull.Value)
                {
                    priceList.Add(Convert.ToDecimal(dt.Rows[i]["TotalPrice"]));
                }
            }

            foreach (decimal price in priceList)
            {
                totalSum += price;
            }

            int checkIndex = 0;
            do
            {
                checkIndex++;
            } while (checkIndex < rowCount && checkIndex < 0);

            BookingReport currentReport = new BookingReport(rowCount, totalSum);

            Console.WriteLine("Summary Created: " + currentReport.TotalAppointments + " items found.");
        }

        void LoadComboBoxData()
        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                SqlDataAdapter daGroomer = new SqlDataAdapter("SELECT GroomerID, GroomerName FROM Groomer", con);
                DataTable dtGroomer = new DataTable();
                daGroomer.Fill(dtGroomer);

                TBGroomerID.DataSource = dtGroomer;
                TBGroomerID.DisplayMember = "GroomerName";
                TBGroomerID.ValueMember = "GroomerID";

                SqlDataAdapter daService = new SqlDataAdapter("SELECT ServiceID, ServiceName FROM ServicePackage", con);
                DataTable dtService = new DataTable();
                daService.Fill(dtService);

                TBServiceID.DataSource = dtService;
                TBServiceID.DisplayMember = "ServiceName";
                TBServiceID.ValueMember = "ServiceID";

                TBGroomerID.SelectedIndex = -1;
                TBServiceID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load drop-down lists: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void ManageBooking_Load(object sender, EventArgs e)
        {
           
            switch (CurrentUserRole)
            {
                case "Admin":
                case "Staff":
                    
                    break;
                default:
                    MessageBox.Show("Access Denied! Standard Users cannot access the Admin Module.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    return;
            }

            LoadBooking();
            LoadComboBoxData();
        }

        
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(TBPetID.Text) ||
                TBGroomerID.SelectedValue == null ||
                TBServiceID.SelectedValue == null ||
                string.IsNullOrWhiteSpace(cbTime.Text) ||
                string.IsNullOrWhiteSpace(TBStatus.Text) ||
                string.IsNullOrWhiteSpace(TBTotPrice.Text))
            {
                MessageBox.Show("Please fill in all the required fields before adding a booking!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

               
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Booking (PetID, GroomerID, ServiceID, BookingDate, BookingTime, Status, TotalPrice) " +
                    "VALUES (@p, @g, @s, @d, @t, @st, @pr)", con);

                cmd.Parameters.AddWithValue("@p", TBPetID.Text);
                cmd.Parameters.AddWithValue("@g", TBGroomerID.SelectedValue);
                cmd.Parameters.AddWithValue("@s", TBServiceID.SelectedValue);
                cmd.Parameters.AddWithValue("@d", dtpDate.Value);
                cmd.Parameters.AddWithValue("@t", cbTime.Text);
                cmd.Parameters.AddWithValue("@st", TBStatus.Text);
                cmd.Parameters.AddWithValue("@pr", Convert.ToDecimal(TBTotPrice.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking record successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtbxID.Clear();
                TBPetID.Clear();
                TBStatus.Clear();
                TBTotPrice.Clear();
                TBGroomerID.SelectedIndex = -1;
                TBServiceID.SelectedIndex = -1;
                cbTime.SelectedIndex = -1;

                LoadBooking();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insertion failed: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        
        private void dgvBooking_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBooking.Rows[e.RowIndex];

                txtbxID.Text = row.Cells[0].Value.ToString();
                TBPetID.Text = row.Cells[1].Value.ToString();

                TBGroomerID.SelectedValue = row.Cells[2].Value;
                TBServiceID.SelectedValue = row.Cells[3].Value;

                cbTime.Text = row.Cells[5].Value.ToString();
                TBStatus.Text = row.Cells[6].Value.ToString();

                if (row.Cells[7].Value != DBNull.Value)
                {
                    TBTotPrice.Text = Convert.ToDecimal(row.Cells[7].Value).ToString("0.00");
                }

                if (row.Cells[4].Value != DBNull.Value)
                    dtpDate.Value = Convert.ToDateTime(row.Cells[4].Value);

                
                string activeID = txtbxID.Text;
                this.Tag = activeID; 
            }
        }

        
        private void bttnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxID.Text))
            {
                MessageBox.Show("Please select a booking record from the table first to update!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TBPetID.Text) ||
                TBGroomerID.SelectedValue == null ||
                TBServiceID.SelectedValue == null ||
                string.IsNullOrWhiteSpace(cbTime.Text) ||
                string.IsNullOrWhiteSpace(TBStatus.Text) ||
                string.IsNullOrWhiteSpace(TBTotPrice.Text))
            {
                MessageBox.Show("Fields cannot be empty when updating a record!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                // SQL QUERIES (UPDATE)
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Booking SET PetID=@p, GroomerID=@g, ServiceID=@s, " +
                    "BookingDate=@d, BookingTime=@t, Status=@st, TotalPrice=@pr WHERE BookingID=@b", con);

                cmd.Parameters.AddWithValue("@b", txtbxID.Text);
                cmd.Parameters.AddWithValue("@p", TBPetID.Text);
                cmd.Parameters.AddWithValue("@g", TBGroomerID.SelectedValue);
                cmd.Parameters.AddWithValue("@s", TBServiceID.SelectedValue);
                cmd.Parameters.AddWithValue("@d", dtpDate.Value);
                cmd.Parameters.AddWithValue("@t", cbTime.Text);
                cmd.Parameters.AddWithValue("@st", TBStatus.Text);
                cmd.Parameters.AddWithValue("@pr", Convert.ToDecimal(TBTotPrice.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking details successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadBooking();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

       
        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxID.Text))
            {
                MessageBox.Show("Please select a booking record from the table first to delete!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete Booking ID: " + txtbxID.Text + "?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    if (con.State == ConnectionState.Closed) con.Open();

                    // SQL QUERIES (DELETE)
                    SqlCommand cmd = new SqlCommand("DELETE FROM Booking WHERE BookingID=@id", con);
                    cmd.Parameters.AddWithValue("@id", txtbxID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking record successfully deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtbxID.Clear();
                    TBPetID.Clear();
                    TBStatus.Clear();
                    TBTotPrice.Clear();
                    TBGroomerID.SelectedIndex = -1;
                    TBServiceID.SelectedIndex = -1;
                    cbTime.SelectedIndex = -1;

                    LoadBooking();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deletion failed: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public class BookingReport
        {
            private int totalAppointments;
            private decimal totalRevenue;

            public int TotalAppointments
            {
                get { return totalAppointments; }
                set { totalAppointments = value; }
            }
            public decimal TotalRevenue
            {
                get { return totalRevenue; }
                set { totalRevenue = value; }
            }

            public BookingReport(int appointments, decimal revenue)
            {
                this.totalAppointments = appointments;
                this.totalRevenue = revenue;
            }
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}