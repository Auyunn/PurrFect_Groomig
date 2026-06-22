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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Databases\PurrFect\PurrFect.mdf;Integrated Security=True; Connect Timeout=30");

        int selectID = 0;
        public AdminPayment()
        {
            InitializeComponent();
        }
        void LoadPayments()
        {
            try
            {
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT PaymentID, BookingID, PaymentMethod, PaymentDate, Amount FROM Payment",
                    con);

                da.Fill(dt);

                dataGridViewPayment.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand com = new SqlCommand(
                    "INSERT INTO Payment (PaymentID,BookingID, PaymentMethod, PaymentDate, Amount) VALUES (@B, @PM, @PD, @A)",
                    con);

                com.Parameters.AddWithValue("@PI", textBoxPaymentID.Text);
                com.Parameters.AddWithValue("@BI", textBoxBookingID.Text);
                com.Parameters.AddWithValue("@PM", textBoxMethod.Text);
                com.Parameters.AddWithValue("@PD", textBoxDate.Text);
                com.Parameters.AddWithValue("@A", textBoxAmount.Text);

                com.ExecuteNonQuery();

                MessageBox.Show("Payment Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                LoadPayments();
            }
        }

        private void AdminPayment_Load(object sender, EventArgs e)
        {
            LoadPayments();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectID == 0)
            {
                MessageBox.Show("Select payments first");
                return;
            }

            try
            {
                con.Open();

                SqlCommand com = new SqlCommand(
                    "UPDATE Payment SET BookingID=@BI, PaymentMethod=@PM, PaymentDate=@PD, Amount=@A WHERE PaymentID=@PI",
                    con);

                com.Parameters.AddWithValue("@BI", textBoxBookingID.Text);
                com.Parameters.AddWithValue("@PM", textBoxMethod.Text);
                com.Parameters.AddWithValue("@PD", textBoxDate.Text);
                com.Parameters.AddWithValue("@A", textBoxAmount.Text);
                com.Parameters.AddWithValue("@PI", textBoxPaymentID.Text); 
                com.ExecuteNonQuery();

                MessageBox.Show("Payment Edited");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show("Select payment first");
                return;
            }

            if (MessageBox.Show("DELETE this payment?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Payment WHERE PaymentID=@id",
                        con);

                    cmd.Parameters.AddWithValue("@id", selectID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Payment Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    LoadPayments();
                }
            }
        }
    }
}
