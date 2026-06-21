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
    public partial class ManageGroomer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");

        public ManageGroomer()
        {
            InitializeComponent();
        }

        private void ManageGroomer_Load(object sender, EventArgs e)
        {
            // Mengisi data Experience ComboBox (0 years - above 10)
            cbStatus.Items.Clear();
            for (int i = 0; i <= 10; i++)
            {
                if (i == 10) cbStatus.Items.Add("above 10");
                else cbStatus.Items.Add(i + " years");
            }

            LoadGroomer();
        }

        void LoadGroomer()
        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT GroomerID, GroomerName, Phone, Salary, Experience FROM Groomer", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvGroomer.DataSource = dt;

                if (dgvGroomer.Columns["Salary"] != null)
                {
                    dgvGroomer.Columns["Salary"].DefaultCellStyle.Format = "N2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxName.Text) ||
                string.IsNullOrWhiteSpace(txtbxPhone.Text) ||
                string.IsNullOrWhiteSpace(cbStatus.Text) ||
                string.IsNullOrWhiteSpace(txtbxSalary.Text))
            {
                MessageBox.Show("Please fill in ALL fields before adding a new groomer!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtbxSalary.Text, out decimal parsedSalary) || parsedSalary <= 0)
            {
                MessageBox.Show("Please enter a valid numeric amount for Salary!", "Input Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Groomer g = new Groomer();
                g.Name = txtbxName.Text;
                g.Phone = txtbxPhone.Text;
                g.Status = cbStatus.Text;
                g.Salary = parsedSalary;

                Func<decimal, decimal> calculateBonus = s => s * 0.1m;
                decimal monthlyBonus = calculateBonus(g.Salary);
                decimal totalMonthlyEarn = g.Salary + monthlyBonus;
                decimal annualSalary = g.CalculateAnnualSalary(totalMonthlyEarn);

                MessageBox.Show($"Groomer calculations processed successfully!\n\n" +
                                $"Monthly Bonus (10%): RM {monthlyBonus:N2}\n" +
                                $"Total Annual Salary (Inc. Bonus): RM {annualSalary:N2}",
                                "Calculation Results", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (con.State == ConnectionState.Closed) con.Open();

                // GroomerID tidak dimasukkan di sini kerana ia AUTO-INCREMENT (IDENTITY) di database
                SqlCommand cmd = new SqlCommand("INSERT INTO Groomer (GroomerName, Phone, Salary, Experience) VALUES (@n, @p, @sal, @exp)", con);
                cmd.Parameters.AddWithValue("@n", g.Name);
                cmd.Parameters.AddWithValue("@p", g.Phone);
                cmd.Parameters.AddWithValue("@sal", g.Salary);
                cmd.Parameters.AddWithValue("@exp", g.Status);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New Groomer registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadGroomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database integration failed: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxID.Text))
            {
                MessageBox.Show("Please select a groomer from the table first to update!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtbxSalary.Text, out decimal checkedSalary))
            {
                MessageBox.Show("Salary must be a numeric value!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Groomer SET GroomerName=@n, Phone=@p, Salary=@sal, Experience=@exp WHERE GroomerID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtbxID.Text);
                cmd.Parameters.AddWithValue("@n", txtbxName.Text);
                cmd.Parameters.AddWithValue("@p", txtbxPhone.Text);
                cmd.Parameters.AddWithValue("@sal", checkedSalary);
                cmd.Parameters.AddWithValue("@exp", cbStatus.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Groomer details successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadGroomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update execution failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxID.Text))
            {
                MessageBox.Show("Please select a record from the table first to delete!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to permanently delete Groomer ID: " + txtbxID.Text + "?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    if (con.State == ConnectionState.Closed) con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Groomer WHERE GroomerID=@id", con);
                    cmd.Parameters.AddWithValue("@id", txtbxID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Groomer record deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                    LoadGroomer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deletion failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        // PERBAIKAN UTAMA: Penambahan logik pembersihan sekiranya Empty Cell diklik
        private void dgvGroomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGroomer.Rows[e.RowIndex];

                // Semak jika baris yang diklik adalah baris kosong (New/Empty row)
                if (row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value)
                {
                    ClearFields(); // Bersihkan semua kotak teks serta-merta
                    this.Tag = null;
                    return;
                }

                // 1. ISI INPUT FIELDS KELAS PERTAMA (Data wujud)
                txtbxID.Text = row.Cells[0].Value?.ToString() ?? "";
                txtbxName.Text = row.Cells[1].Value?.ToString() ?? "";
                txtbxPhone.Text = row.Cells[2].Value?.ToString() ?? "";

                decimal currentSalary = 0;
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    currentSalary = Convert.ToDecimal(row.Cells[3].Value);
                    txtbxSalary.Text = currentSalary.ToString("0.00");
                }
                else
                {
                    txtbxSalary.Text = "";
                }

                cbStatus.Text = row.Cells[4].Value?.ToString() ?? "";

                // 2. LIVE CALCULATION & DATA PASSING
                Func<decimal, decimal> calculateBonus = s => s * 0.1m;
                decimal liveAnnualSalary = (currentSalary + calculateBonus(currentSalary)) * 12;

                this.Tag = txtbxID.Text;

                List<string> info = new List<string>();
                info.Add("ID: " + txtbxID.Text);
                info.Add("Name: " + txtbxName.Text);
                info.Add("Phone: " + txtbxPhone.Text);
                info.Add("Experience: " + cbStatus.Text);
                info.Add("Salary: RM " + txtbxSalary.Text);
                info.Add("Est. Annual Salary: RM " + liveAnnualSalary.ToString("N2"));

                string summary = string.Join(Environment.NewLine, info);
                MessageBox.Show(summary, "Active Groomer Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void ClearFields()
        {
            txtbxID.Clear();
            txtbxName.Clear();
            txtbxPhone.Clear();
            txtbxSalary.Clear();
            cbStatus.SelectedIndex = -1;
            cbStatus.Text = "";
        }
    }
}