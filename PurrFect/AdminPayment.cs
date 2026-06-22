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
    public partial class AdminPayment : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");

        int selectID = 0;
        int currentBookingID = 0;

        public AdminPayment()
        {
            InitializeComponent();

            this.dataGridViewPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPayment_CellClick);
        }

        void LoadPayments()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT PaymentID, BookingID, PaymentMethod, PaymentDate, Amount FROM Payment", con);

                da.Fill(dt);
                dataGridViewPayment.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message);
            }
        }

        private void AdminPayment_Load(object sender, EventArgs e)
        {
            LoadPayments();

            textBoxPaymentID.ReadOnly = true;
            textBoxPaymentID.BackColor = SystemColors.InactiveCaption;

            textBoxBookingID.ReadOnly = true;
            textBoxBookingID.BackColor = SystemColors.InactiveCaption;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
            if (selectID == 0)
            {
                MessageBox.Show("Please select a payment record from the table first before editing!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            int inputBookingID;
            if (!int.TryParse(textBoxBookingID.Text.Trim(), out inputBookingID) || inputBookingID != currentBookingID)
            {
                MessageBox.Show("CRITICAL LOGIC ERROR: You are NOT allowed to change or re-assign the Booking ID of an existing invoice/receipt!", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxBookingID.Text = currentBookingID.ToString(); 
                return;
            }

            double targetAmount;
            if (!double.TryParse(textBoxAmount.Text.Trim(), out targetAmount))
            {
                MessageBox.Show("Amount must be a valid numeric price value!", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();
                string query = "UPDATE Payment SET PaymentMethod=@PM, PaymentDate=@PD, Amount=@A WHERE PaymentID=@PI";
                SqlCommand com = new SqlCommand(query, con);

                com.Parameters.AddWithValue("@PM", textBoxMethod.Text.Trim());
                com.Parameters.AddWithValue("@PD", textBoxDate.Text.Trim());
                com.Parameters.AddWithValue("@A", targetAmount);
                com.Parameters.AddWithValue("@PI", selectID);

                com.ExecuteNonQuery();
                MessageBox.Show("Payment invoice updated successfully. (Booking association remained locked)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating payment record: " + ex.Message);
            }
            finally
            {
                con.Close();
                LoadPayments();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectID == 0)
            {
                MessageBox.Show("Please select a payment record from the table first to delete!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string warningMessage = $"Are you sure you want to permanently DELETE Payment ID: {selectID}?\n\n" +
                                    "WARNING: Deleting this payment receipt will leave the associated Booking ID without a paid transaction statement! This action cannot be undone.";

            if (MessageBox.Show(warningMessage, "Critical Delete Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Payment WHERE PaymentID=@id", con);
                    cmd.Parameters.AddWithValue("@id", selectID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment record has been successfully wiped out from database.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error executing delete command: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    LoadPayments();
                }
            }
        }

        private void dataGridViewPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridViewPayment.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            if (row.Cells[0].Value != null && row.Cells[0].Value != DBNull.Value)
            {
                selectID = Convert.ToInt32(row.Cells[0].Value);
                textBoxPaymentID.Text = selectID.ToString();
            }
            else
            {
                selectID = 0;
                textBoxPaymentID.Text = string.Empty;
            }

            if (row.Cells[1].Value != null && row.Cells[1].Value != DBNull.Value)
            {
                currentBookingID = Convert.ToInt32(row.Cells[1].Value);
                textBoxBookingID.Text = currentBookingID.ToString();
            }
            else
            {
                currentBookingID = 0;
                textBoxBookingID.Text = string.Empty;
            }

            textBoxMethod.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
            textBoxDate.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
            textBoxAmount.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
        }

        private void ClearInputs()
        {
            selectID = 0;
            currentBookingID = 0;
            textBoxPaymentID.Text = string.Empty;
            textBoxBookingID.Text = string.Empty;
            textBoxMethod.Text = string.Empty;
            textBoxDate.Text = string.Empty;
            textBoxAmount.Text = string.Empty;
        }
    }
}