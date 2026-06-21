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
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PurrFect;Integrated Security=True");
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
        private void ManageBooking_Load(object sender, EventArgs e)
        {
            LoadBooking();


            Func<int, int, int> add = (a, b) => a + b;
            int result = add(2, 3);

            Console.WriteLine("Lambda Result: " + result);
        }
        private void bttnAdd_Click(object sender, EventArgs e)
        {
             
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Booking (Customer, Package, Groomer, BookingDate, TimeSlot) " +
                    "VALUES (@c,@p,@g,@d,@t)", con);

                cmd.Parameters.AddWithValue("@c", txtbxCustomer.Text); 
                cmd.Parameters.AddWithValue("@p", cbPackage.Text);
                cmd.Parameters.AddWithValue("@g", cbGroomer.Text);
                cmd.Parameters.AddWithValue("@d", dtpDate.Value);
                cmd.Parameters.AddWithValue("@t", cbTime.Text);

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
                    "UPDATE Booking SET Customer=@c, Package=@p, Groomer=@g, " +
                    "BookingDate=@d, TimeSlot=@t WHERE BookingID=@id", con);

                cmd.Parameters.AddWithValue("@id", txtbxID.Text);
                cmd.Parameters.AddWithValue("@c", txtbxCustomer.Text);
                cmd.Parameters.AddWithValue("@p", cbPackage.Text);
                cmd.Parameters.AddWithValue("@g", cbGroomer.Text);
                cmd.Parameters.AddWithValue("@d", dtpDate.Value);
                cmd.Parameters.AddWithValue("@t", cbTime.Text);

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
                txtbxCustomer.Text = row.Cells[1].Value.ToString();
                cbPackage.Text = row.Cells[2].Value.ToString();
                cbGroomer.Text = row.Cells[3].Value.ToString();

                ShowSummaryFromGrid(row);
            }
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

            summary += "\n------------------------\nTotal: RM " + row.Cells["TotalPrice"].Value.ToString();

            txtbxSummary.Text = summary;
        }
    }
}







    


    
