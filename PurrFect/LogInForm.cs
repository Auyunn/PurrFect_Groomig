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
    public partial class LogInForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");

        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string role = "";

            if (radioButton1.Checked)
                role = "User";
            else if (radioButton2.Checked)
                role = "Admin";

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields and select your role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();
                string query = "SELECT UserID, Role FROM Users WHERE Username=@user AND Password=@pass AND Role=@role";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@role", role);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                   
                    Booking.UserID = Convert.ToInt32(dr["UserID"]);
                    dr.Close();

                    if (role == "Admin")
                    {
                        AdminDashboard admin = new AdminDashboard();
                        admin.Show();
                    }
                    else
                    {
                        
                        BookingForm booking = new BookingForm();
                        booking.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username, Password or Role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); }

        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.Show();
            this.Hide();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm frm = new ForgotPasswordForm();
            frm.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
    }
}