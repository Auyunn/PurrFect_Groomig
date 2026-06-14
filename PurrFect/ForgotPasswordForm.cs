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
    public partial class ForgotPasswordForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            txtNewPassword.Visible = false;
            txtConfirmPassword.Visible = false;

            chkShowPassword.Visible = false;

            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;

            txtConfirmPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;
        }

        private bool isVerified = false;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                if (!isVerified)
                {
                    string query = "SELECT * FROM Customer WHERE Username=@Username AND Email=@Email";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        isVerified = true;

                        txtNewPassword.Visible = true;
                        txtConfirmPassword.Visible = true;
                        chkShowPassword.Visible = true;

                        btnConfirm.Text = "Reset Password";

                        MessageBox.Show("Verification Successful.");
                    }
                    else
                    {
                        MessageBox.Show("Username or Email not found.");
                    }

                    dr.Close();
                }
                else
                {
                    if (txtNewPassword.Text != txtConfirmPassword.Text)
                    {
                        MessageBox.Show("Passwords do not match.");
                        return;
                    }

                    string updateQuery = @"UPDATE Customer SET Password=@Password WHERE Username=@Username AND Email=@Email";

                    SqlCommand updateCmd =
                        new SqlCommand(updateQuery, con);

                    updateCmd.Parameters.AddWithValue("@Password", txtNewPassword.Text);
                    updateCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    updateCmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    int rows = updateCmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Password Reset Successful!");

                        LogInForm login = new LogInForm();
                        login.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password reset failed.");
                    }
                }
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

        private void lblreturn_Click(object sender, EventArgs e)
        {
            LogInForm frm = new LogInForm();
            frm.Show();

            this.Hide();
        }
    }
}
