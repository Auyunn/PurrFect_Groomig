using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurrFect
{
    public partial class RegisterPetForm : Form
    {
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
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Please enter the pet's name.");
                return;
            }

            if (textBoxBreed.Text == "")
            {
                MessageBox.Show("Please enter the pet's breed.");
                return;
            }


            if (textBoxAge.Text == "")
            {
                MessageBox.Show("Please enter the pet's age.");
                return;
            }

            if (textBoxWeight.Text == "")
            {
                MessageBox.Show("Please enter the pet's weight.");
                return;
            }

            if (textBoxAllergies.Text == "")
            {
                MessageBox.Show("Please enter the pet's allergies.");
                return;
            }

            if (textBoxVaccinated.Text == "")
            {
                MessageBox.Show("Please enter the pet's vaccination status.");
                return;
            }


        MessageBox.Show("Pet Registered!", "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
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

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            this.Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            BookingForm bf = new BookingForm();
            this.Show();
        }
    }
}
