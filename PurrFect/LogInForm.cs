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

                string query =
                    "SELECT * FROM Users " +
                    "WHERE Username=@Username " +
                    "AND Password=@Password " +
                    "AND Role=@Role";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@Role", role);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // 1. Ambil UserID dari akaun yang berjaya login
                    int currentUserId = Convert.ToInt32(dr["UserID"]);

                    // 2. Wajib tutup Reader (dr) dulu sebelum kita boleh buat query baru guna connection yang sama
                    dr.Close();

                    MessageBox.Show("Login Successful!");

                    // 3. Cari PetID berdasarkan UserID tadi (Hanya jika role ialah User)
                    if (role == "User")
                    {
                        try
                        {
                            string petQuery = "SELECT PetID FROM Pet WHERE UserID = @userid";
                            SqlCommand petCmd = new SqlCommand(petQuery, con);
                            petCmd.Parameters.AddWithValue("@userid", currentUserId);

                            object result = petCmd.ExecuteScalar();
                            if (result != null)
                            {
                                Booking.PetID = Convert.ToInt32(result); // Simpan ke global variable
                            }
                            else
                            {
                                Booking.PetID = 0; // Set 0 kalau user ni belum register pet
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading pet details: " + ex.Message);
                        }
                    }

                    // 4. Tukar ke form seterusnya ikut Role
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
                    MessageBox.Show("Invalid Username, Password or Role.");
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close(); // Pastikan connection sentiasa ditutup rapat
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
