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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");
       
        public ManageGroomer()
        {
            InitializeComponent();
        }
        void LoadGroomer()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Groomer", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvGroomer.DataSource = dt;

            con.Close();
        }
        private void lbPhone_Click(object sender, EventArgs e)
        {

        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
        
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Groomer (GroomerName, Phone, Status, Salary) VALUES (@n,@p,@s,@sal)", con);

            cmd.Parameters.AddWithValue("@n", txtbxName.Text);
            cmd.Parameters.AddWithValue("@p", txtbxPhone.Text);
            cmd.Parameters.AddWithValue("@s", cbxStatus.Text);
            cmd.Parameters.AddWithValue("@sal", txtbxSalary.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Groomer Added!");
            LoadGroomer();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
      
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE Groomer SET GroomerName=@n, Phone=@p, Status=@s, Salary=@sal WHERE GroomerID=@id", con);

            cmd.Parameters.AddWithValue("@id", txtbxID.Text);
            cmd.Parameters.AddWithValue("@n", txtbxName.Text);
            cmd.Parameters.AddWithValue("@p", txtbxPhone.Text);
            cmd.Parameters.AddWithValue("@s", cbxStatus.Text);
            cmd.Parameters.AddWithValue("@sal", txtbxSalary.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated!");
            LoadGroomer();
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
    
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Groomer WHERE GroomerID=@id", con);

            cmd.Parameters.AddWithValue("@id", txtbxID.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted!");
            LoadGroomer();
        }
        private void dataGridViewGroomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbxID.Text = dgvGroomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbxName.Text = dgvGroomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbxPhone.Text = dgvGroomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxStatus.Text = dgvGroomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtbxSalary.Text = dgvGroomer.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void ManageGroomer_Load(object sender, EventArgs e)
        {

        }
    }
    
    
}
