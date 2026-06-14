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
            txtPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            chkUser.Checked = false;
            chkAdmin.Checked = false;

            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string role = "";

            if (chkUser.Checked)
                role = "User";
            else if (chkAdmin.Checked)
                role = "Admin";
            else
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Please enter username.");
                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter password.");
                return;
            }

            try
            {
                con.Open();

                string query = "SELECT * FROM Customer WHERE Username=@Username AND Password=@Password AND Role=@Role";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Role", role);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Login Successful");

                    BookingForm frm = new BookingForm();
                    frm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username, Password or Role.");
                }

                dr.Close();
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

        private void chkUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUser.Checked)
                chkAdmin.Checked = false;
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdmin.Checked)
                chkUser.Checked = false;
        }
    }
}
