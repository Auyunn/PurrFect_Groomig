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
    public partial class RegisterPetForm : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True";

        public RegisterPetForm()
        {
            InitializeComponent();
        }

        private void RegisterPetForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxName;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxBreed.Text))
            {
                MessageBox.Show("Please fill in the pet's required details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxAge.Text, out int age) || !decimal.TryParse(textBoxWeight.Text, out decimal weight))
            {
                MessageBox.Show("Please enter valid age and weight.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Pet (UserID, PetName, Breed, Age, Weight, Allergies, Vaccinated) " +
                                   "OUTPUT INSERTED.PetID VALUES (@userId, @name, @breed, @age, @weight, @allergies, @vaccinated)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userId", Booking.UserID); 
                    cmd.Parameters.AddWithValue("@name", textBoxName.Text.Trim());
                    cmd.Parameters.AddWithValue("@breed", textBoxBreed.Text.Trim());
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.Parameters.AddWithValue("@allergies", string.IsNullOrWhiteSpace(textBoxAllergies.Text) ? "None" : textBoxAllergies.Text.Trim());
                    cmd.Parameters.AddWithValue("@vaccinated", textBoxVaccinated.Text.Trim());

                    object newPetId = cmd.ExecuteScalar();

                    if (newPetId != null)
                    {
                        Booking.PetID = Convert.ToInt32(newPetId);
                        MessageBox.Show("Pet successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                        BookingForm booking = new BookingForm();
                        booking.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving pet to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxBreed.Clear();
            textBoxAge.Clear();
            textBoxWeight.Clear();
            textBoxVaccinated.Clear();
            textBoxAllergies.Clear();
            textBoxName.Focus();
        }
    }
}