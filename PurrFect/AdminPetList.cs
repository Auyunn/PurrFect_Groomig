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
    // INHERITENCE
    public partial class AdminPetList : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True";

        int selectID = 0;
        int currentUserID = 0;

        public AdminPetList()
        {
            InitializeComponent();
            //DELEGATES
            this.Load += new System.EventHandler(this.AdminPetList_Load);
        }

        void FillUserComboBox()
        {
            // EXCEPTION HANDLING
            try
            {
                // INTERFACE
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT UserID FROM Users";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            // COLLECTIONS
                            comboBoxUserID.Items.Clear();
                            while (dr.Read())
                            {
                                comboBoxUserID.Items.Add(dr["UserID"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users to dropdown: " + ex.Message);
            }
        }

        void LoadPets()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    DataTable dt = new DataTable();
                    string query = "SELECT PetID, UserID, PetName, Breed, Age, Weight, Allergies, Vaccinated FROM Pet";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                    }

                    dataGridViewPetList.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void AdminPetList_Load(object sender, EventArgs e)
        {
            LoadPets();
            FillUserComboBox(); 

            textBoxPetID.ReadOnly = true;
            textBoxPetID.BackColor = SystemColors.InactiveCaption;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(textBoxPetID.Text))
            {
                MessageBox.Show("ID is auto assign! Please clear the fields (click table empty area or reset) before adding a new pet.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxUserID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a User ID from the dropdown list!", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int targetUserID = Convert.ToInt32(comboBoxUserID.SelectedItem);

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "INSERT INTO Pet (UserID, PetName, Breed, Age, Weight, Allergies, Vaccinated) VALUES (@UID, @N, @B, @A, @W, @All, @V)";

                    using (SqlCommand com = new SqlCommand(query, con))
                    {
                        // COLLECTIONS
                        com.Parameters.AddWithValue("@UID", targetUserID);
                        com.Parameters.AddWithValue("@N", textBoxPetName.Text.Trim());
                        com.Parameters.AddWithValue("@B", textBoxBreed.Text.Trim());
                        com.Parameters.AddWithValue("@A", string.IsNullOrWhiteSpace(textBoxAge.Text) ? DBNull.Value : (object)Convert.ToInt32(textBoxAge.Text));
                        com.Parameters.AddWithValue("@W", string.IsNullOrWhiteSpace(textBoxWeight.Text) ? DBNull.Value : (object)Convert.ToDouble(textBoxWeight.Text));
                        com.Parameters.AddWithValue("@All", textBoxAllergies.Text.Trim());
                        com.Parameters.AddWithValue("@V", textBoxVaccinated.Text.Trim());

                        com.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pet Added Successfully! ID was auto assigned by system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding pet: " + ex.Message);
            }
            finally
            {
                LoadPets();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectID == 0)
            {
                MessageBox.Show("Please select a pet from the table first.");
                return;
            }

            int inputPetID;
            int.TryParse(textBoxPetID.Text.Trim(), out inputPetID);

            if (inputPetID != selectID)
            {
                MessageBox.Show("You cannot alter the Pet ID! It is a locked system assignment.", "Action Stopped", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxPetID.Text = selectID.ToString();
                return;
            }

            if (comboBoxUserID.SelectedItem == null || Convert.ToInt32(comboBoxUserID.SelectedItem) != currentUserID)
            {
                MessageBox.Show("ID is auto assign! You are not allowed to change or re-assign the Owner (User ID) of an existing pet.", "Action Stopped", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                comboBoxUserID.SelectedItem = currentUserID.ToString(); 
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "UPDATE Pet SET PetName=@N, Breed=@B, Age=@A, Weight=@W, Allergies=@All, Vaccinated=@V WHERE PetID=@id";

                    using (SqlCommand com = new SqlCommand(query, con))
                    {
                        com.Parameters.AddWithValue("@N", textBoxPetName.Text.Trim());
                        com.Parameters.AddWithValue("@B", textBoxBreed.Text.Trim());
                        com.Parameters.AddWithValue("@A", string.IsNullOrWhiteSpace(textBoxAge.Text) ? DBNull.Value : (object)Convert.ToInt32(textBoxAge.Text));
                        com.Parameters.AddWithValue("@W", string.IsNullOrWhiteSpace(textBoxWeight.Text) ? DBNull.Value : (object)Convert.ToDouble(textBoxWeight.Text));
                        com.Parameters.AddWithValue("@All", textBoxAllergies.Text.Trim());
                        com.Parameters.AddWithValue("@V", textBoxVaccinated.Text.Trim());
                        com.Parameters.AddWithValue("@id", selectID);

                        com.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pet Updated Successfully. (IDs remained locked)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating pet: " + ex.Message);
            }
            finally
            {
                LoadPets();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectID == 0)
            {
                MessageBox.Show("Please select a pet from the table first.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to DELETE this pet?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (MessageBox.Show("WARNING: Deleting this pet will permanently DELETE ALL ASSOCIATED BOOKINGS! Proceed?", "Critical Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();

                           
                            string deleteBookingQuery = "DELETE FROM Booking WHERE PetID=@id";
                            using (SqlCommand cmdBooking = new SqlCommand(deleteBookingQuery, con))
                            {
                                cmdBooking.Parameters.AddWithValue("@id", selectID);
                                cmdBooking.ExecuteNonQuery();
                            }

                           
                            string deletePetQuery = "DELETE FROM Pet WHERE PetID=@id";
                            using (SqlCommand cmdPet = new SqlCommand(deletePetQuery, con))
                            {
                                cmdPet.Parameters.AddWithValue("@id", selectID);
                                cmdPet.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Pet and all linked booking records successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error executing delete transaction: " + ex.Message);
                    }
                    finally
                    {
                        LoadPets();
                    }
                }
            }
        }

        private void dataGridViewPetList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridViewPetList.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            if (row.Cells[0].Value != null && row.Cells[0].Value != DBNull.Value)
            {
                selectID = Convert.ToInt32(row.Cells[0].Value);
                textBoxPetID.Text = selectID.ToString();
            }
            else
            {
                selectID = 0;
                textBoxPetID.Text = string.Empty;
            }

            if (row.Cells[1].Value != null && row.Cells[1].Value != DBNull.Value)
            {
                currentUserID = Convert.ToInt32(row.Cells[1].Value);
                comboBoxUserID.SelectedItem = currentUserID.ToString();
            }
            else
            {
                currentUserID = 0;
                comboBoxUserID.SelectedIndex = -1;
            }

            textBoxPetName.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
            textBoxBreed.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
            textBoxAge.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
            textBoxWeight.Text = row.Cells[5].Value?.ToString() ?? string.Empty;
            textBoxAllergies.Text = row.Cells[6].Value?.ToString() ?? string.Empty;
            textBoxVaccinated.Text = row.Cells[7].Value?.ToString() ?? string.Empty;
        }

        private void ClearInputs()
        {
            selectID = 0;
            currentUserID = 0;
            textBoxPetID.Text = string.Empty;
            comboBoxUserID.SelectedIndex = -1; 
            textBoxPetName.Text = string.Empty;
            textBoxBreed.Text = string.Empty;
            textBoxAge.Text = string.Empty;
            textBoxWeight.Text = string.Empty;
            textBoxAllergies.Text = string.Empty;
            textBoxVaccinated.Text = string.Empty;
        }
    }
}