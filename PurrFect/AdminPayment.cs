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
                MessageBox.Show("Error loading payments: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminPayment_Load(object sender, EventArgs e)
        {
            LoadPayments();

            // lock all input
            textBoxPaymentID.ReadOnly = true;
            textBoxPaymentID.BackColor = SystemColors.InactiveCaption;

            textBoxBookingID.ReadOnly = true;
            textBoxBookingID.BackColor = SystemColors.InactiveCaption;

            textBoxAmount.ReadOnly = true; // Amaun tidak boleh diedit sesuka hati selepas bayar
            textBoxAmount.BackColor = SystemColors.InactiveCaption;

            textBoxDate.ReadOnly = true; // Tarikh asal transaksi tidak boleh diubah suai
            textBoxDate.BackColor = SystemColors.InactiveCaption;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectID == 0)
            {
                MessageBox.Show("Please select a payment record from the table first before editing!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            try
            {
                con.Open();
                string query = "UPDATE Payment SET PaymentMethod=@PM WHERE PaymentID=@PI";
                SqlCommand com = new SqlCommand(query, con);

                com.Parameters.AddWithValue("@PM", textBoxMethod.Text.Trim());
                com.Parameters.AddWithValue("@PI", selectID);

                com.ExecuteNonQuery();
                MessageBox.Show("Payment method updated successfully. Financial audit trail remains secured.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating payment record: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please select a payment record from the table first to process a refund!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double currentAmount;
            if (!double.TryParse(textBoxAmount.Text.Trim(), out currentAmount))
            {
                MessageBox.Show("Invalid amount detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (currentAmount <= 0)
            {
                MessageBox.Show("This transaction has already been refunded or voided!", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            double refundValue = currentAmount * -1;
            string paymentMethodUsed = textBoxMethod.Text.Trim();

            string confirmMessage = $"ARE YOU SURE YOU WANT TO REFUND THIS TRANSACTION?\n\n" +
                                    $"Payment ID: {selectID}\n" +
                                    $"Booking ID: {currentBookingID}\n" +
                                    $"Original Amount: RM {currentAmount:0.00}\n" +
                                    $"Payment Method: {paymentMethodUsed}\n\n" +
                                    $"This will update the account balance by setting the amount to RM {refundValue:0.00}.";

            if (MessageBox.Show(confirmMessage, "Confirm System Refund", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    con.Open();

                    string query = "UPDATE Payment SET Amount = @RefundAmount WHERE PaymentID = @id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@RefundAmount", refundValue);
                    cmd.Parameters.AddWithValue("@id", selectID);

                    cmd.ExecuteNonQuery();

                    string finalNotice = $"Refund record has been processed successfully in the system database!\n\n" +
                                         $"ACTION REQUIRED FOR ADMIN:\n" +
                                         $"Please manually return/refund exactly RM {currentAmount:0.00} to the customer via {paymentMethodUsed}.";

                    MessageBox.Show(finalNotice, "Refund Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error executing refund command: " + ex.Message, "Database System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            textBoxAmount.Text = row.Cells[4].Value != DBNull.Value ? Convert.ToDecimal(row.Cells[4].Value).ToString("0.00") : "0.00";
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