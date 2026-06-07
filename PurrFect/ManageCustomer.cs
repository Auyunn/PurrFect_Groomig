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
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT UserID, Username, Password, Role FROM Users",
                con);

            da.Fill(dt);

            CustomerDGV.DataSource = dt;
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            con.Open();

            SqlDataAdapter adt = new SqlDataAdapter(
                "SELECT Role, COUNT(*) AS Total " +
                "FROM Users " +
                "GROUP BY Role",
                con);

            adt.Fill(dt);

            con.Close();

            CustomerChart.Series.Clear();

            Series s = new Series("Users");
            s.ChartType = SeriesChartType.Pie;

            CustomerChart.Series.Add(s);

            int adminCount = 0;
            int customerCount = 0;

            foreach (DataRow row in dt.Rows)
            {
                string role = row["Role"].ToString();
                int total = Convert.ToInt32(row["Total"]);

                s.Points.AddXY(role, total);

                if (role == "Admin")
                    adminCount = total;

                else if (role == "User")
                    customerCount = total;
            }

            s.IsValueShownAsLabel = true;

            AdminCountLabel.Text = "Total Admin: " + adminCount;
            CustomerCountLabel.Text = "Total Customers: " + customerCount;

            LoadCustomers();

        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("UPDATE Users "+"SET Username = @U, Password = @P, Role = @R " + "WHERE UserID=@id", con);
            com.Parameters.Add("@U", SqlDbType.NVarChar, 100).Value = UsernameTB.Text.Trim();
            com.Parameters.Add("@P", SqlDbType.NVarChar, 200).Value = PasswordTB.Text; // store hashed value instead
            com.Parameters.Add("@R", SqlDbType.NVarChar, 50).Value = RoleCB.Text;
            com.Parameters.Add("@id", SqlDbType.Int).Value = selectID;

            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Edited");
            LoadCustomers();

        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            using (var com = new SqlCommand(
            "INSERT INTO Users (Username, Password, Role) VALUES (@U, @P, @R)",
            con))
            {
                com.Parameters.Add("@U", SqlDbType.NVarChar, 100).Value = UsernameTB.Text.Trim();
                com.Parameters.Add("@P", SqlDbType.NVarChar, 200).Value = PasswordTB.Text;
                com.Parameters.Add("@R", SqlDbType.NVarChar, 50).Value = RoleCB.Text;

                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("User Added");
            LoadCustomers();
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (selectID == 0)
            {
                MessageBox.Show("Select user first");
                return;
            }

            if (MessageBox.Show(
                "DELETE this user?", "Confirm", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Users WHERE UserID=@id",
                    con);

                cmd.Parameters.AddWithValue("@id", selectID);
                cmd.ExecuteNonQuery();
                con.Close() ;
                MessageBox.Show("User Deleted");
                LoadCustomers();
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
    }
}
