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
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string role = "";

            if (radioButton1.Checked)
                role = "User";
            else if (radioButton2.Checked)
                role = "Admin";

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all blanks.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                string checkUser = "SELECT COUNT(1) FROM Users WHERE Username=@user";
                SqlCommand checkCmd = new SqlCommand(checkUser, con);
                checkCmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("Username already exists. Please choose another one.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO Users (Username, Password, Role) " +
                               "OUTPUT INSERTED.UserID VALUES (@user, @pass, @role)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@role", role);

                int newUserID = Convert.ToInt32(cmd.ExecuteScalar());
                Booking.UserID = newUserID;

                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (role == "User")
                {
                    RegisterPetForm petForm = new RegisterPetForm();
                    petForm.Show();
                }
                else if (role == "Admin")
                {
                    AdminDashboard adminForm = new AdminDashboard();
                    adminForm.Show();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e) { }
        private void chkFemale_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
    }
}