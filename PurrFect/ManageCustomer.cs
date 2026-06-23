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
using System.Windows.Forms.DataVisualization.Charting;

namespace PurrFect
{
    public partial class ManageCustomer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");
        int selectID = 0; //global variable to store id chosen

        public ManageCustomer()
        {
            InitializeComponent();
        }

        void LoadCustomers()
        {
            try
            {
                DataTable dt = new DataTable();//build ttable
                SqlDataAdapter da = new SqlDataAdapter("SELECT UserID, Username, Password, Role FROM Users", con);
                da.Fill(dt);//execute and store in table data 
                CustomerDGV.DataSource = dt;//table data to chart
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadChart()
        {
            try
            {
                //similiar to above
                DataTable dt = new DataTable();
                if (con.State == ConnectionState.Closed) con.Open();

                SqlDataAdapter adt = new SqlDataAdapter("SELECT Role, COUNT(*) AS Total FROM Users GROUP BY Role", con);
                adt.Fill(dt);
                con.Close();

                CustomerChart.Series.Clear(); //clear chart before add new data


                Series s = new Series("Users") //set series to user 
                {
                    ChartType = SeriesChartType.Pie// set type to pie
                };
                CustomerChart.Series.Add(s);//ad new serirs

                //change data dari datable to dict format 
                var roleData = dt.AsEnumerable()
                    .ToDictionary(
                        row => row["Role"].ToString().Trim(),//make role as key
                        row => Convert.ToInt32(row["Total"])//kira jumlah
                    );

                //masuk kan data 
                roleData.ToList().ForEach(x => //x role, xvalue jumlah
                {
                    s.Points.AddXY(x.Key, x.Value);
                });

                s.IsValueShownAsLabel = true;//display untuk display total

                //count admin n user
                AdminCountLabel.Text = "Total Admin: " + (roleData.ContainsKey("Admin") ? roleData["Admin"] : 0);
                CustomerCountLabel.Text = "Total Customers: " + (roleData.ContainsKey("User") ? roleData["User"] : 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart: " + ex.Message, "Chart Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            LoadChart();
            LoadCustomers();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(UsernameTB.Text) || string.IsNullOrWhiteSpace(PasswordTB.Text) || string.IsNullOrWhiteSpace(RoleCB.Text))
            {
                MessageBox.Show("Please fill in all fields (Username, Password, and Role) before adding a user.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                SqlCommand com = new SqlCommand("INSERT INTO Users (Username, Password, Role) VALUES (@U, @P, @R)", con);
                com.Parameters.AddWithValue("@U", UsernameTB.Text.Trim());
                com.Parameters.AddWithValue("@P", PasswordTB.Text);
                com.Parameters.AddWithValue("@R", RoleCB.Text.Trim()); 

                com.ExecuteNonQuery();
                MessageBox.Show("User successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add user: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                LoadCustomers();
                LoadChart();
            }
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            if (selectID == 0)
            {
                MessageBox.Show("Please select a user from the table first to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(UsernameTB.Text) || string.IsNullOrWhiteSpace(PasswordTB.Text) || string.IsNullOrWhiteSpace(RoleCB.Text))
            {
                MessageBox.Show("Fields cannot be left blank during an update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                SqlCommand com = new SqlCommand("UPDATE Users SET Username=@U, Password=@P, Role=@R WHERE UserID=@id", con);
                com.Parameters.AddWithValue("@U", UsernameTB.Text.Trim());
                com.Parameters.AddWithValue("@P", PasswordTB.Text);
                com.Parameters.AddWithValue("@R", RoleCB.Text.Trim());
                com.Parameters.AddWithValue("@id", selectID);

                com.ExecuteNonQuery();
                MessageBox.Show("User details successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update user: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please select a user from the table first to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to permanently DELETE this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (con.State == ConnectionState.Closed) con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID=@id", con);
                    cmd.Parameters.AddWithValue("@id", selectID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete user. Ensure this user is not linked to any active pet records.", "Constraint Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (e.RowIndex < 0) return; //ignore if admin click header

            var row = CustomerDGV.Rows[e.RowIndex]; //take data clicked
            if (row.IsNewRow) return;//ignore if admin click empty roler

            object idObj = row.Cells["UserID"].Value; //take value from row user id
            if (idObj == null || idObj == DBNull.Value)//if id is empty 
            {
                selectID = 0;//set global id to 0
                ClearFields();//clear the field
            }
            else
            {   //if valid
                selectID = Convert.ToInt32(idObj);
                UsernameTB.Text = row.Cells["Username"].Value?.ToString() ?? string.Empty;//fill text with value from table
                PasswordTB.Text = row.Cells["Password"].Value?.ToString() ?? string.Empty;
                RoleCB.Text = row.Cells["Role"].Value?.ToString() ?? string.Empty;
            }
        }

        void ClearFields()
        {
            selectID = 0;
            UsernameTB.Clear();
            PasswordTB.Clear();
            RoleCB.SelectedIndex = -1;
        }

        
        private void CustomerChart_Click(object sender, EventArgs e) { }
        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void UsernameTB_TextChanged(object sender, EventArgs e) { }
    }
}