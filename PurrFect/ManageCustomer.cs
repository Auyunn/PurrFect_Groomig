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
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace PurrFect
{

    public partial class ManageCustomer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");
        int selectID = 0;
        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void CustomerChart_Click(object sender, EventArgs e)
        {
            
        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        void LoadCustomers()
        {
            try
            {
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT UserID, Username, Password, Role FROM Users",
                    con);

                da.Fill(dt);

                CustomerDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadChart()
        {
            try
            {
                DataTable dt = new DataTable();

                con.Open();

                SqlDataAdapter adt = new SqlDataAdapter(
                    "SELECT Role, COUNT(*) AS Total FROM Users GROUP BY Role",
                    con);

                adt.Fill(dt);

                con.Close();

                CustomerChart.Series.Clear();

                Series s = new Series("Users");
                s.ChartType = SeriesChartType.Pie;

                CustomerChart.Series.Add(s);

                // LINQ: convert table -> dictionary
                var roleData = dt.AsEnumerable()
                    .ToDictionary(
                        row => row["Role"].ToString(),
                        row => Convert.ToInt32(row["Total"])
                    );

                // LAMBDA usage
                roleData.ToList().ForEach(x =>
                {
                    s.Points.AddXY(x.Key, x.Value);
                });

                s.IsValueShownAsLabel = true;

                // SAFE LABEL UPDATE
                AdminCountLabel.Text =
                    "Total Admin: " + (roleData.ContainsKey("Admin") ? roleData["Admin"] : 0);

                CustomerCountLabel.Text =
                    "Total Customers: " + (roleData.ContainsKey("User") ? roleData["User"] : 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            LoadChart();
            LoadCustomers();

        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            if (selectID == 0)
            {
                MessageBox.Show("Select user first");
                return;
            }

            try
            {
                con.Open();

                SqlCommand com = new SqlCommand(
                    "UPDATE Users SET Username=@U, Password=@P, Role=@R WHERE UserID=@id",
                    con);

                com.Parameters.AddWithValue("@U", UsernameTB.Text.Trim());
                com.Parameters.AddWithValue("@P", PasswordTB.Text);
                com.Parameters.AddWithValue("@R", RoleCB.Text);
                com.Parameters.AddWithValue("@id", selectID);

                com.ExecuteNonQuery();

                MessageBox.Show("User Edited");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                LoadCustomers();
                LoadChart();
            }

        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand com = new SqlCommand(
                    "INSERT INTO Users (Username, Password, Role) VALUES (@U, @P, @R)",
                    con);

                com.Parameters.AddWithValue("@U", UsernameTB.Text.Trim());
                com.Parameters.AddWithValue("@P", PasswordTB.Text);
                com.Parameters.AddWithValue("@R", RoleCB.Text);

                com.ExecuteNonQuery();

                MessageBox.Show("User Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                LoadCustomers();
                LoadChart();
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (selectID == 0)
            {
                MessageBox.Show("Select user first");
                return;
            }

            if (MessageBox.Show("DELETE this user?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Users WHERE UserID=@id",
                        con);

                    cmd.Parameters.AddWithValue("@id", selectID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    LoadCustomers();
                    LoadChart();
                }
            }
        }
        

        private void CustomerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = CustomerDGV.Rows[e.RowIndex];

            // Ignore the special new row (editable empty row)
            if (row.IsNewRow) return;

            object idObj = row.Cells["UserID"].Value;
            if (idObj == null || idObj == DBNull.Value)
            {
                selectID = 0; // or return/notify user
            }
            else
            {
                selectID = Convert.ToInt32(idObj);
            }

            object u = row.Cells["Username"].Value;
            object p = row.Cells["Password"].Value;
            object r = row.Cells["Role"].Value;

            UsernameTB.Text = (u == null || u == DBNull.Value) ? string.Empty : u.ToString();
            PasswordTB.Text = (p == null || p == DBNull.Value) ? string.Empty : p.ToString();
            RoleCB.Text = (r == null || r == DBNull.Value) ? string.Empty : r.ToString();
        }

        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
