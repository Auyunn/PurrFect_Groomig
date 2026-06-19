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
    public partial class PaymentForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");
        public PaymentForm()
        {
            InitializeComponent();
            this.Load += PaymentForm_Load;
        }

        void GenerateReceipt()
        {
            string paymentMethod = "";

            if (CardRB.Checked)
                paymentMethod = "Card";
            else if (CashRB.Checked)
                paymentMethod = "Cash";
            else if (OnlineBankRB.Checked)
                paymentMethod = "FPX";

            Booking.PaymentMethod = paymentMethod;

            ReceiptRTB.Clear();

            ReceiptRTB.AppendText("============== PURRFECT RECEIPT ==============\n\n");

            ReceiptRTB.AppendText("PACKAGE\n");
            ReceiptRTB.AppendText(Booking.Package + "\n\n");

            ReceiptRTB.AppendText("GROOMER\n");
            ReceiptRTB.AppendText(Booking.groomer + "\n\n");

            ReceiptRTB.AppendText("DATE\n");
            ReceiptRTB.AppendText(Booking.BookingDate.ToString("dd MMM yyyy") + "\n\n");

            ReceiptRTB.AppendText("TIME SLOT\n");
            ReceiptRTB.AppendText(Booking.TimeSlot + "\n\n");

            ReceiptRTB.AppendText("ADD ONS\n");

            if (!string.IsNullOrEmpty(Booking.HairCut))
                ReceiptRTB.AppendText("- " + Booking.HairCut + "\n");

            if (!string.IsNullOrEmpty(Booking.Shampoo))
                ReceiptRTB.AppendText("- " + Booking.Shampoo + "\n");

            if (!string.IsNullOrEmpty(Booking.NailClip))
                ReceiptRTB.AppendText("- " + Booking.NailClip + "\n");

            if (!string.IsNullOrEmpty(Booking.FleaTreatment))
                ReceiptRTB.AppendText("- " + Booking.FleaTreatment + "\n");

            if (!string.IsNullOrEmpty(Booking.TeethCleaning))
                ReceiptRTB.AppendText("- " + Booking.TeethCleaning + "\n");

            ReceiptRTB.AppendText("\nPAYMENT METHOD\n");
            ReceiptRTB.AppendText(paymentMethod + "\n\n");

            ReceiptRTB.AppendText("TOTAL PRICE\n");
            ReceiptRTB.AppendText("RM " + Booking.TotalPrice.ToString("0.00"));
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            AddOnForm book = new AddOnForm();
            book.Show();
            this.Hide();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GenerateReceipt(); 
        }

        private void BillsP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OnlineBankRB_CheckedChanged(object sender, EventArgs e)
        {
            GenerateReceipt();
        }

        private void CashRB_CheckedChanged(object sender, EventArgs e)
        {
            GenerateReceipt();
        }

        private void ProceedBTN_Click(object sender, EventArgs e)
        {
            string paymentMethod = "";

            
            if (CardRB.Checked)
                paymentMethod = "Card";
            else if (CashRB.Checked)
                paymentMethod = "Cash";
            else if (OnlineBankRB.Checked)
                paymentMethod = "FPX";

            // Validation
            if (string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Please select payment method");
                return;
            }

           
            try
            {
                con.Open();

                
                string checkQuery = "SELECT COUNT(1) FROM Booking WHERE BookingID = @id";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@id", Booking.BookingID);

                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (exists == 0)
                {
                    MessageBox.Show("BookingID " + Booking.BookingID + " not found. Cannot record payment.");
                    return;
                }

                
                string insertQuery = "INSERT INTO Payment (BookingID, PaymentMethod, PaymentDate, Amount) " +
                                     "VALUES (@bookingid, @method, @date, @amount)";

                SqlCommand cmd = new SqlCommand(insertQuery, con);

               
                cmd.Parameters.AddWithValue("@bookingid", Booking.BookingID);
                cmd.Parameters.AddWithValue("@method", paymentMethod);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@amount", Booking.TotalPrice);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment Error: " + ex.Message);
                return; 
            }
            finally
            {
                con.Close();
            }

            
            ThankYouForm thankYou = new ThankYouForm();
            thankYou.Show();
            this.Hide();


        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            GenerateReceipt();
        }
    }
}
