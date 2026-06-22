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
            string role = "";

            if (radioButton1.Checked)
            {
                role = "User";
            }
            else if (radioButton2.Checked)
            {
                role = "Admin";
            }

            // Validation
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter username.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please confirm password.");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (role == "")
            {
                MessageBox.Show("Please select role.");
                return;
            }

            try
            {
                con.Open();

                // Check username
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE Username=@Username",
                    con);

                checkCmd.Parameters.AddWithValue(
                    "@Username",
                    txtUsername.Text.Trim());

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Username already exists.");
                    return;
                }

                // Insert user/admin
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Users (Username, Password, Role) " +
                    "VALUES (@Username, @Password, @Role)",
                    con);

                cmd.Parameters.AddWithValue(
                    "@Username",
                    txtUsername.Text.Trim());

                cmd.Parameters.AddWithValue(
                    "@Password",
                    txtPassword.Text);

                cmd.Parameters.AddWithValue(
                    "@Role",
                    role);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account Registered Successfully!");

                RegisterPetForm login = new RegisterPetForm();
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
        }

        private void chkFemale_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
