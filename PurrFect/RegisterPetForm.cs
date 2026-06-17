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

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            openFileDialogUpload.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialogUpload.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPet.Image = Image.FromFile(openFileDialogUpload.FileName);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Please enter the pet's name.");
                return;
            }

            if (comboBoxType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the pet's type.");
                return;
            }

            if (textBoxBreed.Text == "")
            {
                MessageBox.Show("Please enter the pet's breed.");
                return;
            }

            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                MessageBox.Show("Please select gender.");
                return;
            }

            if (dateTimePicker1.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Please select a valid birth date.");
                return;
            }

            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Please enter a valid weight.");
                numericUpDown1.Focus();
                return;
            }

            if (textBoxColor.Text == "")
            {
                MessageBox.Show("Please enter the pet's color.");
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
            textBoxColor.Clear();

            comboBoxType.SelectedIndex = -1;

            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;

            dateTimePicker1.Value = DateTime.Today;

            numericUpDown1.Value = 0;

            pictureBoxPet.Image = null;

            textBoxName.Focus();
        }
    }
}
