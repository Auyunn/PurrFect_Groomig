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
using System.Xml.Linq;

namespace PurrFect
{
    public partial class ManageGroomer : Form
    {
        SqlConnection con = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PurrFect;Integrated Security=True");
        public ManageGroomer()
        {
            InitializeComponent();
        }

        private void ManageGroomer_Load(object sender, EventArgs e)
        {
            LoadGroomer();

            // ✅ Lambda
            Func<decimal, decimal> bonus = s => s * 0.1m;

            decimal sample = bonus(1000);

            Console.WriteLine("Sample Bonus: " + sample);
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Inheritance + Interface
                GroomerClass g = new GroomerClass();

                g.Name = txtbxName.Text;
                g.Phone = txtbxPhone.Text;
                g.Status = cbStatus.Text;
                g.Salary = Convert.ToDecimal(txtbxSalary.Text);

                decimal annualSalary = g.CalculateAnnualSalary(g.Salary);

                MessageBox.Show("Annual Salary: RM " + annualSalary);

                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Groomer (GroomerName, Phone, Status, Salary) VALUES (@n,@p,@s,@sal)", con);

                cmd.Parameters.AddWithValue("@n", g.Name);
                cmd.Parameters.AddWithValue("@p", g.Phone);
                cmd.Parameters.AddWithValue("@s", g.Status);
                cmd.Parameters.AddWithValue("@sal", g.Salary);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Groomer Added!");
                LoadGroomer();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        

        void LoadGroomer()
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Groomer", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvGroomer.DataSource = dt;

                // ✅ LINQ (filter salary tinggi)
                var highSalary = dt.AsEnumerable()
                    .Where(row => Convert.ToDecimal(row["Salary"]) > 2000)
                    .ToList();

                Console.WriteLine("High Salary Groomer: " + highSalary.Count);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // ✅ FORM LOAD + LAMBDA
       
       
   

        private void bttnEdit_Click(object sender, EventArgs e)
        {


            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Groomer SET GroomerName=@n, Phone=@p, Status=@s, Salary=@sal WHERE GroomerID=@id", con);

                    cmd.Parameters.AddWithValue("@id", txtbxID.Text);
                    cmd.Parameters.AddWithValue("@n", txtbxName.Text);
                    cmd.Parameters.AddWithValue("@p", txtbxPhone.Text);
                    cmd.Parameters.AddWithValue("@s", cbStatus.Text);
                    cmd.Parameters.AddWithValue("@sal", txtbxSalary.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Updated!");
                    LoadGroomer();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }


        private void bttnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Groomer WHERE GroomerID=@id", con);

                cmd.Parameters.AddWithValue("@id", txtbxID.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted!");
                LoadGroomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dgvGroomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvGroomer.Rows[e.RowIndex];

                txtbxID.Text = row.Cells[0].Value.ToString();
                txtbxName.Text = row.Cells[1].Value.ToString();
                txtbxPhone.Text = row.Cells[2].Value.ToString();
                cbStatus.Text = row.Cells[3].Value.ToString();
                txtbxSalary.Text = row.Cells[4].Value.ToString();

                
                List<string> info = new List<string>();

                info.Add("Name: " + row.Cells[1].Value.ToString());
                info.Add("Phone: " + row.Cells[2].Value.ToString());
                info.Add("Status: " + row.Cells[3].Value.ToString());
                info.Add("Salary: RM " + row.Cells[4].Value.ToString());


                string summary = string.Join(Environment.NewLine, info);

                MessageBox.Show(summary);
            }
        }
    }

}
