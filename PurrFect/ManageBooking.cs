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

        private void ManageBooking_Load(object sender, EventArgs e)
        {
            // stop acces for role other than admin
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

            // SEKAT USER DARIPADA USIK BOOKING ID SECARA MANUAL
            txtbxID.ReadOnly = true;
            txtbxID.BackColor = SystemColors.InactiveCaption; // Tukar warna paparan supaya nampak 'disabled'

            LoadBooking();
            LoadComboBoxData();
        }

        void LoadBooking()
        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

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

        void LoadComboBoxData()
        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                // load Data Groomer
                SqlDataAdapter daGroomer = new SqlDataAdapter("SELECT GroomerID, GroomerName FROM Groomer", con);
                DataTable dtGroomer = new DataTable();
                daGroomer.Fill(dtGroomer);
                TBGroomerID.DataSource = dtGroomer;
                TBGroomerID.DisplayMember = "GroomerName";
                TBGroomerID.ValueMember = "GroomerID";

                // Load Data Service
                SqlDataAdapter daService = new SqlDataAdapter("SELECT ServiceID, ServiceName FROM ServicePackage", con);
                DataTable dtService = new DataTable();
                daService.Fill(dtService);
                TBServiceID.DataSource = dtService;
                TBServiceID.DisplayMember = "ServiceName";
                TBServiceID.ValueMember = "ServiceID";

                // Load Data Pet ke dalam ComboBox 
                SqlDataAdapter daPet = new SqlDataAdapter("SELECT PetID, PetName FROM Pet", con);
                DataTable dtPet = new DataTable();
                daPet.Fill(dtPet);
                TBPetID.DataSource = dtPet;
                TBPetID.DisplayMember = "PetName";
                TBPetID.ValueMember = "PetID";

                // Set pilihan awal ke kosong
                TBGroomerID.SelectedIndex = -1;
                TBServiceID.SelectedIndex = -1;
                TBPetID.SelectedIndex = -1;
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

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            // Validasi baris input menggunakan SelectedValue ComboBox
            if (TBPetID.SelectedValue == null ||
                TBGroomerID.SelectedValue == null ||
                TBServiceID.SelectedValue == null ||
                string.IsNullOrWhiteSpace(cbTime.Text) ||
                string.IsNullOrWhiteSpace(TBStatus.Text) ||
                string.IsNullOrWhiteSpace(TBTotPrice.Text))
            {
                MessageBox.Show("Please fill/select all the required fields before adding a booking!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Booking (PetID, GroomerID, ServiceID, BookingDate, BookingTime, Status, TotalPrice) " +
                    "VALUES (@p, @g, @s, @d, @t, @st, @pr)", con);

                //ambil ValueMember (ID integer) dari ComboBox
                cmd.Parameters.AddWithValue("@p", TBPetID.SelectedValue);
                cmd.Parameters.AddWithValue("@g", TBGroomerID.SelectedValue);
                cmd.Parameters.AddWithValue("@s", TBServiceID.SelectedValue);
                cmd.Parameters.AddWithValue("@d", dtpDate.Value);
                cmd.Parameters.AddWithValue("@t", cbTime.Text);
                cmd.Parameters.AddWithValue("@st", TBStatus.Text);
                cmd.Parameters.AddWithValue("@pr", Convert.ToDecimal(TBTotPrice.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking record successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
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

                txtbxID.Text = row.Cells["BookingID"].Value.ToString(); 

                
                TBPetID.SelectedValue = row.Cells["PetID"].Value;
                TBGroomerID.SelectedValue = row.Cells["GroomerID"].Value;
                TBServiceID.SelectedValue = row.Cells["ServiceID"].Value;

                cbTime.Text = row.Cells["BookingTime"].Value.ToString();
                TBStatus.Text = row.Cells["Status"].Value.ToString();

                if (row.Cells["TotalPrice"].Value != DBNull.Value)
                {
                    TBTotPrice.Text = Convert.ToDecimal(row.Cells["TotalPrice"].Value).ToString("0.00");
                }

                if (row.Cells["BookingDate"].Value != DBNull.Value)
                    dtpDate.Value = Convert.ToDateTime(row.Cells["BookingDate"].Value);
            }
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxID.Text))
            {
                MessageBox.Show("Please select a booking record from the table first to update!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Booking SET PetID=@p, GroomerID=@g, ServiceID=@s, " +
                    "BookingDate=@d, BookingTime=@t, Status=@st, TotalPrice=@pr WHERE BookingID=@b", con);

                cmd.Parameters.AddWithValue("@b", txtbxID.Text);
                cmd.Parameters.AddWithValue("@p", TBPetID.SelectedValue);
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

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete Booking ID: " + txtbxID.Text + "? This will also delete its payment history.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    if (con.State == ConnectionState.Closed) con.Open();

                    //  PADAM REKOD ANAK DI JADUAL PAYMENT DULU
                    SqlCommand cmdChild = new SqlCommand("DELETE FROM Payment WHERE BookingID=@id", con);
                    cmdChild.Parameters.AddWithValue("@id", txtbxID.Text);
                    cmdChild.ExecuteNonQuery();

                    // PADAM REKOD INDUK DI JADUAL BOOKING
                    SqlCommand cmdParent = new SqlCommand("DELETE FROM Booking WHERE BookingID=@id", con);
                    cmdParent.Parameters.AddWithValue("@id", txtbxID.Text);
                    cmdParent.ExecuteNonQuery();

                    MessageBox.Show("Booking and associated payment records successfully deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
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

        void ClearFields()
        {
            txtbxID.Clear();
            TBStatus.Clear();
            TBTotPrice.Clear();
            TBPetID.SelectedIndex = -1;
            TBGroomerID.SelectedIndex = -1;
            TBServiceID.SelectedIndex = -1;
            cbTime.SelectedIndex = -1;
        }

        private void CalculateSystemMetrics(DataTable dt)
        {
            int rowCount = dt.Rows.Count;
            decimal totalSum = 0;

            for (int i = 0; i < rowCount; i++)
            {
                if (dt.Rows[i]["TotalPrice"] != DBNull.Value)
                {
                    totalSum += Convert.ToDecimal(dt.Rows[i]["TotalPrice"]);
                }
            }

            BookingReport currentReport = new BookingReport(rowCount, totalSum);
            Console.WriteLine("Summary Created: " + currentReport.TotalAppointments + " items found.");
        }

        public class BookingReport
        {
            public int TotalAppointments { get; set; }
            public decimal TotalRevenue { get; set; }

            public BookingReport(int appointments, decimal revenue)
            {
                this.TotalAppointments = appointments;
                this.TotalRevenue = revenue;
            }
        }

        private void txtbxID_TextChanged(object sender, EventArgs e) { }
        private void cbTime_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}