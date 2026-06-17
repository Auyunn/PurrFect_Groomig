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
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PurrFect
{
    public partial class ManageBooking : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");
      
        public ManageBooking()
        {
            InitializeComponent();
        }
        void LoadBooking()
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Booking", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                var expensiveBooking = dt.AsEnumerable()
                    .Where(row => Convert.ToDecimal(row["TotalPrice"]) > 50)
                    .ToList();

                dgvBooking.DataSource = dt;

               
                MessageBox.Show("Expensive booking (>RM50): " + expensiveBooking.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        private void bttnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Booking (Customer, Package, Groomer, BookingDate, TimeSlot) " +
                    "VALUES (@c,@p,@g,@d,@t)", con);

                cmd.Parameters.AddWithValue("@c", txtbxName.Text);
                cmd.Parameters.AddWithValue("@p", cbxPackage.Text);
                cmd.Parameters.AddWithValue("@g", cbxGroomer.Text);
                cmd.Parameters.AddWithValue("@d", dtpDatee.Value);
                cmd.Parameters.AddWithValue("@t", cbxTimee.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Booking Added!");
                LoadBooking();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Booking SET Customer=@c, Package=@p, Groomer=@g, BookingDate=@d, TimeSlot=@t " +
                    "WHERE BookingID=@id", con);

                cmd.Parameters.AddWithValue("@id", txtbxID.Text);
                cmd.Parameters.AddWithValue("@c", txtbxName.Text);
                cmd.Parameters.AddWithValue("@p", cbxPackage.Text);
                cmd.Parameters.AddWithValue("@g", cbxGroomer.Text);
                cmd.Parameters.AddWithValue("@d", dtpDatee.Value);
                cmd.Parameters.AddWithValue("@t", cbxTimee.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Updated!");
                LoadBooking();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void bttnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Booking WHERE BookingID=@id", con);

                cmd.Parameters.AddWithValue("@id", txtbxID.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted!");
                LoadBooking();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void dgvBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvBooking.Rows[e.RowIndex];

                txtbxID.Text = row.Cells[0].Value.ToString();
                txtbxName.Text = row.Cells[1].Value.ToString();
                cbxPackage.Text = row.Cells[2].Value.ToString();
                cbxGroomer.Text = row.Cells[3].Value.ToString();

                
                ShowSummaryFromGrid(row);
            }
        }
        private void ManageBooking_Load(object sender, EventArgs e)
        {
            LoadBooking();



            Func<decimal, decimal, decimal> addTotal = (a, b) => a + b;
            decimal total = addTotal(20, 30);


            Console.WriteLine("Lambda Result: " + total);
        }


        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void ShowSummaryFromGrid(DataGridViewRow row)
        {
            List<string> addons = new List<string>();

            addons.Add("Haircut: " + row.Cells["HairCut"].Value.ToString());
            addons.Add("Shampoo: " + row.Cells["Shampoo"].Value.ToString());
            addons.Add("Flea: " + row.Cells["FleaTreatment"].Value.ToString());
            addons.Add("Nail: " + row.Cells["NailClip"].Value.ToString());
            addons.Add("Teeth: " + row.Cells["TeethCleaning"].Value.ToString());

            
            string summary = string.Join(Environment.NewLine, addons);

            summary += Environment.NewLine + "------------------------" + Environment.NewLine +
                       "Total: RM " + row.Cells["TotalPrice"].Value.ToString();

            txtbxSummary.Text = summary;
        }


    }
}
    
    

