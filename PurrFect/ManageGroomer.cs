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
        // db connect
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");

        public ManageGroomer()
        {
            InitializeComponent();
        }

        private void ManageGroomer_Load(object sender, EventArgs e)
        {
            //prevent from change ID
            txtbxID.ReadOnly = true;
            txtbxID.BackColor = SystemColors.ControlLight;

            //Fill experience
            cbStatus.Items.Clear();
            for (int i = 0; i <= 10; i++)
            {
                if (i == 10) cbStatus.Items.Add("above 10");
                else cbStatus.Items.Add(i + " years");
            }

            LoadGroomer();
        }

        // list
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

        // (CREATE)
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
                g.Name = txtbxName.Text.Trim();
                g.Phone = txtbxPhone.Text.Trim();
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

        //  (UPDATE)
        private void bttnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxID.Text) || !int.TryParse(txtbxID.Text, out int groomerID))
            {
                MessageBox.Show("Please select a valid groomer from the table first to update!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtbxSalary.Text, out decimal checkedSalary) || checkedSalary <= 0)
            {
                MessageBox.Show("Salary must be a positive numeric value!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtbxName.Text) || string.IsNullOrWhiteSpace(txtbxPhone.Text) || string.IsNullOrWhiteSpace(cbStatus.Text))
            {
                MessageBox.Show("Fields cannot be left blank during an update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Groomer SET GroomerName=@n, Phone=@p, Salary=@sal, Experience=@exp WHERE GroomerID=@id", con);
                cmd.Parameters.AddWithValue("@id", groomerID);
                cmd.Parameters.AddWithValue("@n", txtbxName.Text.Trim());
                cmd.Parameters.AddWithValue("@p", txtbxPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@sal", checkedSalary);
                cmd.Parameters.AddWithValue("@exp", cbStatus.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Groomer details successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
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

        //  (DELETE)
        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxID.Text) || !int.TryParse(txtbxID.Text, out int groomerID))
            {
                MessageBox.Show("Please select a valid record from the table first to delete!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to permanently delete Groomer ID: " + txtbxID.Text + "?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    if (con.State == ConnectionState.Closed) con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Groomer WHERE GroomerID=@id", con);
                    cmd.Parameters.AddWithValue("@id", groomerID);

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

        // if cell cicked, dia akan bring the data to text input
        private void dgvGroomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGroomer.Rows[e.RowIndex];

                if (row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value)
                {
                    ClearFields();
                    this.Tag = null;
                    return;
                }

                txtbxID.Text = row.Cells[0].Value?.ToString() ?? "";
                txtbxName.Text = row.Cells[1].Value?.ToString() ?? "";
                txtbxPhone.Text = row.Cells[2].Value?.ToString() ?? "";

                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    decimal currentSalary = Convert.ToDecimal(row.Cells[3].Value);
                    txtbxSalary.Text = currentSalary.ToString("0.00");
                }
                else
                {
                    txtbxSalary.Text = "";
                }

                cbStatus.Text = row.Cells[4].Value?.ToString() ?? "";
                this.Tag = txtbxID.Text;
            }
        }

        // clear input
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