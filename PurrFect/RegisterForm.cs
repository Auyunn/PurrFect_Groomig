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
    public partial class RegisterForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;

            txtConfirmPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (chkFemale.Checked)
                gender = "Female";
            else if (chkMale.Checked)
                gender = "Male";

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                con.Open();

                // Check if username already exists
                string checkQuery =
                    "SELECT COUNT(*) FROM Customer WHERE Username=@Username";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@Username", txtUsername.Text);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Username already exists.");
                    return;
                }

                string query =
                @"INSERT INTO Users
        (FullName, Email, Phone, Username, Birthday, Address, Gender, Password, Role)
        VALUES
        (@FullName, @Email, @Phone, @Username, @Birthday, @Address, @Gender, @Password, @Role)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Birthday", dtpBirthday.Value);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Role", "User");

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account Registered Successfully!");

                LogInForm login = new LogInForm();
                login.Show();

                this.Hide();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LogInForm frm = new LogInForm();
            frm.Show();

            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemale.Checked)
                chkMale.Checked = false;
        }

        private void chkFemale_CheckedChanged(object sender, EventArgs e)
        {

            if (chkMale.Checked)
                chkFemale.Checked = false;
        }
    }
}
