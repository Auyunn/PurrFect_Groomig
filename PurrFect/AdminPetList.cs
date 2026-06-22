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
    public partial class AdminPetList : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");
        int selectID = 0;

        public AdminPetList()
        {
            InitializeComponent();
        }
        void LoadPets()
        {
            try
            {
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT PetID, Name, Breed, Age, Weight, Allergies, Vaccinated FROM Pets",
                    con);

                da.Fill(dt);

                dataGridViewPetList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand com = new SqlCommand(
                    "INSERT INTO Pets (Name, Breed, Age, Weight, Allergies, Vaccinated) VALUES (@N, @B, @A, @W, @All, @V)",
                    con);

                com.Parameters.AddWithValue("@N", textBoxPetName.Text.Trim());
                com.Parameters.AddWithValue("@B", textBoxBreed.Text);
                com.Parameters.AddWithValue("@A", textBoxAge.Text);
                com.Parameters.AddWithValue("@W", textBoxWeight.Text);
                com.Parameters.AddWithValue("@All", textBoxAllergies.Text);
                com.Parameters.AddWithValue("@V", textBoxVaccinated.Text);

                com.ExecuteNonQuery();

                MessageBox.Show("Pet Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                LoadPets();
            }
        }

        private void AdminPetList_Load(object sender, EventArgs e)
        {
            LoadPets();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectID == 0)
            {
                MessageBox.Show("Select pets first");
                return;
            }

            try
            {
                con.Open();

                SqlCommand com = new SqlCommand(
                    "UPDATE Pets SET Name=@N, Breed=@B, Age=@A, Weight=@W, Allergies=@All, Vaccinated=@V WHERE PetID=@id",
                    con);

                com.Parameters.AddWithValue("@N", textBoxPetName.Text.Trim());
                com.Parameters.AddWithValue("@B", textBoxBreed.Text);
                com.Parameters.AddWithValue("@A", textBoxAge.Text);
                com.Parameters.AddWithValue("@W", textBoxWeight.Text);
                com.Parameters.AddWithValue("@All", textBoxAllergies.Text);
                com.Parameters.AddWithValue("@V", textBoxVaccinated.Text);
                com.Parameters.AddWithValue("@id", selectID);

                com.ExecuteNonQuery();

                MessageBox.Show("Pet Edited");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                LoadPets();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectID == 0)
            {
                MessageBox.Show("Select pet first");
                return;
            }

            if (MessageBox.Show("DELETE this pet?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Pets WHERE PetID=@id",
                        con);

                    cmd.Parameters.AddWithValue("@id", selectID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pet Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    LoadPets();
                }
            }
        }

        private void dataGridViewPetList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridViewPetList.Rows[e.RowIndex];

            // Ignore the special new row (editable empty row)
            if (row.IsNewRow) return;

            object idObj = row.Cells["PetID"].Value;
            if (idObj == null || idObj == DBNull.Value)
            {
                selectID = 0; // or return/notify user
            }
            else
            {
                selectID = Convert.ToInt32(idObj);
            }

            object u = row.Cells["Name"].Value;
            object p = row.Cells["Breed"].Value;
            object r = row.Cells["Age"].Value;

            textBoxPetName.Text = (u == null || u == DBNull.Value) ? string.Empty : u.ToString();
            textBoxBreed.Text = (p == null || p == DBNull.Value) ? string.Empty : p.ToString();
            textBoxAge.Text = (r == null || r == DBNull.Value) ? string.Empty : r.ToString();
        }
    }
}
