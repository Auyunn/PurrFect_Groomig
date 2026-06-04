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
            {
                paymentMethod = "Card";
            }
            else if (CashRB.Checked)
            {
                paymentMethod = "Cash";
            }
            else if (OnlineBankRB.Checked)
            {
                paymentMethod = "FPX";
            }

            Booking.PaymentMethod = paymentMethod;

            //generate receipt
            ReceiptRTB.Clear();

            ReceiptRTB.AppendText("============== PURRFECT RECEIPT ==============\n");
            ReceiptRTB.AppendText("\t\t   PACKAGE\n");
            ReceiptRTB.AppendText("\t\t "+Booking.Package + "\n\n");

            ReceiptRTB.AppendText("\t\t  GROOMER\n");
            ReceiptRTB.AppendText("\t\t " + Booking.groomer + "\n\n");

            ReceiptRTB.AppendText("\t\tDATE\n");
            ReceiptRTB.AppendText("\t\t" + Booking.BookingDate + "\n\n");

            ReceiptRTB.AppendText("\t\tTime Slot\n");
            ReceiptRTB.AppendText("\t\t  " + Booking.TimeSlot + "\n\n");

            ReceiptRTB.AppendText("\t\t  ADDS ON \n");
            if(Booking.HairCut != "")
                ReceiptRTB.AppendText("\t\t-" + Booking.HairCut + "\n");
            if(Booking.Shampoo != "")
                ReceiptRTB.AppendText("\t\t-" + Booking.Shampoo + "\n");
            if(Booking.NailClip != "")
                ReceiptRTB.AppendText("\t\t-" + Booking.NailClip + "\n");
            if (Booking.NailClip != "No")
                ReceiptRTB.AppendText("\t\t-" + Booking.NailClip + "\n");
            if (Booking.FleaTreatment != "")
                ReceiptRTB.AppendText("\t\t-" + Booking.FleaTreatment + "\n");
            if(Booking.TeethCleaning != "")
                ReceiptRTB.AppendText("\t\t-" + Booking.TeethCleaning + "\n");
            if (Booking.TeethCleaning != "No")
                ReceiptRTB.AppendText("\t\t-" + Booking.TeethCleaning + "\n");

            ReceiptRTB.AppendText("\n");

            ReceiptRTB.AppendText("\t\tPAYMENT METHOD \n");
            ReceiptRTB.AppendText("\t\t  " + Booking.PaymentMethod + "\n\n");

            ReceiptRTB.AppendText("\t\tTOTAL PRICE \n");
            ReceiptRTB.AppendText("\t\t  RM " + Booking.TotalPrice.ToString("0.00"));
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

            //payment
            if(CardRB.Checked)
            {
                paymentMethod = "Card";
            }
            else if(CashRB.Checked)
            {
                paymentMethod = "Cash";
            }
            else if(OnlineBankRB.Checked)
            {
                paymentMethod = "FPX";
            }

            //validate
            if (paymentMethod == "")
            {
                MessageBox.Show("Please select payment method");
                return;
            }

            //save payment
            con.Open();
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO Payment (BookingID, PaymentMethod, PaymentDate, Amount) VALUES (@bookingid, @method, @date, @amount)", con))
            {
                cmd.Parameters.AddWithValue("@bookingid", Booking.BookingID);
                cmd.Parameters.AddWithValue("@method", paymentMethod);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@amount", Booking.TotalPrice);

                cmd.ExecuteNonQuery();
            }
            con.Close();

            ThankYouForm thankYou = new ThankYouForm();
            thankYou.Show();
            this.Hide();


        }

        private void ReceiptRTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            // Letak dummy ID sementara untuk tujuan testing run berasingan
            if (Booking.BookingID == 0)
            {
                Booking.BookingID = 1; // Pastikan ID 1 ini wujud dalam table Booking kau
            }
            GenerateReceipt();
        }
    }
}
