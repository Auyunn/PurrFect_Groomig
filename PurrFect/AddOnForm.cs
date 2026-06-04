using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PurrFect
{
    public partial class AddOnForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nur Auyunn\OneDrive\Documents\PROJECT\PurrFect\PurrFect\PurrFect.mdf;Integrated Security=True");
        public AddOnForm()
        {
            InitializeComponent();
        }


        decimal GetAddOnPrice(string addOnName)
        {
            decimal price = 0;

            con.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT Price FROM AddOn WHERE AddOnName=@name", con);

            cmd.Parameters.AddWithValue("@name", addOnName);

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                price = Convert.ToDecimal(result);
            }

            con.Close();

            return price;
        }

        private void summaryBTN_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            decimal totalPrice = 0;
            decimal price = 0;

            // HAIRCUT
            if (KoreanCutRB.Checked)
            { price = GetAddOnPrice("Korean Haircut");
              listBox2.Items.Add("Korean Haircut");
              listBox3.Items.Add("RM " + price);
              totalPrice += price;
            }


            else if (LionCutRB.Checked)
            {
                price = GetAddOnPrice("Lion Haircut");
                listBox2.Items.Add("Lion Haircut");
                listBox3.Items.Add("RM " + price);
                totalPrice += price;
            }

            else if (DinasourCutRB.Checked)
            {
                price = GetAddOnPrice("Dinasour Haircut");
                listBox2.Items.Add("Dinasour Haircut");
                listBox3.Items.Add("RM " + price);
                totalPrice += price;
            }

            else if (BellyCutRB.Checked)
            {
                price = GetAddOnPrice("Belly Haircut");
                listBox2.Items.Add("Belly Haircut");
                listBox3.Items.Add("RM " + price);
                totalPrice += price;
            }

            // SHAMPOO
            if (comboBox1.SelectedItem != null &&
                comboBox1.SelectedItem.ToString() != "None")
            {
                string shampoo = comboBox1.SelectedItem.ToString();
                price = GetAddOnPrice(shampoo);
                listBox2.Items.Add(shampoo);
                listBox3.Items.Add("RM " + price);
                totalPrice += price;
            }

            // FLEA
            if (listBox1.SelectedItem != null &&
                listBox1.SelectedItem.ToString() != "None")
            {
                string flea = listBox1.SelectedItem.ToString();
                price = GetAddOnPrice(flea);
                listBox2.Items.Add(flea);
                listBox3.Items.Add("RM " + price);
                totalPrice += price;
            }

            // YES / NO
            if (YesRB.Checked)
            {   price = GetAddOnPrice("Nail Clipping");
                listBox2.Items.Add("Nail Clipping");
                listBox3.Items.Add("RM " + price);
                totalPrice += price;
            }


            if (Yes2RB.Checked)
            {
                price = GetAddOnPrice("Teeth Cleaning");
                listBox2.Items.Add("Teeth Cleaning");
                listBox3.Items.Add("RM " + price);
                totalPrice += price;
            }

            label1.Text = "RM " + totalPrice.ToString("0.00");
            Booking.TotalPrice = totalPrice;


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void No2RB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Yes2RB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void NoRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void YesRB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void AddOnP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BellyCutRB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void DinasourCutRB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void LionCutRB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void KoreanCutRB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TeethL_Click(object sender, EventArgs e)
        {

        }

        private void FleaL_Click(object sender, EventArgs e)
        {

        }

        private void NailL_Click(object sender, EventArgs e)
        {

        }

        private void ShampooTypeL_Click(object sender, EventArgs e)
        {

        }

        private void HaircutLbl_Click(object sender, EventArgs e)
        {

        }

        private void SummaryP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NextBTN_Click(object sender, EventArgs e)
        {
            string HairCut = "";
            string Shampoo = "";
            string NailClip = "";
            string FleaTreatment = "";
            string TeethCleaning = "";

            //get haircut
            if (KoreanCutRB.Checked)
            {
                HairCut = "Korean Haircut";
            }
            else if (DinasourCutRB.Checked)
            {
                HairCut = "Dinasour Haircut";
            }
            else if (LionCutRB.Checked)
            {
                HairCut = "Lion Haircut";
            }
            else if (BellyCutRB.Checked)
            {
                HairCut = "Belly Haircut";
            }

            //get shampoo
            if (comboBox1.SelectedItem != null)
            {
                Shampoo = comboBox1.SelectedItem.ToString();
            }

            //get nail trim
            if (YesRB.Checked)
            {
                NailClip = "Nail Clipping";
            }

            if (Yes2RB.Checked)
            {
                TeethCleaning = "Teeth Cleaning";
            }

            if (listBox1.SelectedItem != null)
            {
                FleaTreatment = listBox1.SelectedItem.ToString();
            }

            //check
            if (HairCut == "")
            {
                MessageBox.Show("Please select haircut.");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select shampoo type.");
                return;
            }

         
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select flea treatment.");
                return;
            }

            if (!YesRB.Checked && !NoRB.Checked)
            {
                MessageBox.Show("Please select nail clipping.");
                return;
            }

            if (!Yes2RB.Checked && !No2RB.Checked)
            {
                MessageBox.Show("Please select teeth cleaning.");
                return;
            }

            Booking.HairCut = HairCut;
            Booking.Shampoo = Shampoo;
            Booking.NailClip = NailClip;
            Booking.FleaTreatment = FleaTreatment;
            Booking.TeethCleaning = TeethCleaning;

            PaymentForm pay = new PaymentForm();
            pay.Show();
            this.Hide();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            string HairCut = "";
            string Shampoo = "";
            string NailClip = "";
            string FleaTreatment = "";
            string TeethCleaning = "";

            //get haircut
            if (KoreanCutRB.Checked)
            {
                HairCut = "Korean Haircut";
            }
            else if (DinasourCutRB.Checked)
            {
                HairCut = "Dinasour Haircut";
            }
            else if (LionCutRB.Checked)
            {
                HairCut = "Lion Haircut";
            }
            else if (BellyCutRB.Checked)
            {
                HairCut = "Belly Haircut";
            }

            //get shampoo
            if (comboBox1.SelectedItem != null)
            {
                Shampoo = comboBox1.SelectedItem.ToString();
            }

            //get nail trim
            if (YesRB.Checked)
            {
                NailClip = "Nail Clipping";
            }
            else if(NoRB.Checked)
            {
                NailClip = "No";
            }

            if (Yes2RB.Checked)
            {
                TeethCleaning = "Teeth Cleaning";
            }
            else if (No2RB.Checked)
            {
                TeethCleaning = "No";
            }

            if (listBox1.SelectedItem != null)
            {
                FleaTreatment = listBox1.SelectedItem.ToString();
            }

            //check
            if (HairCut == "")
            {
                MessageBox.Show("Please select haircut.");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select shampoo type.");
                return;
            }

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select flea treatment.");
                return;
            }

            if (!YesRB.Checked && !NoRB.Checked)
            {
                MessageBox.Show("Please select nail clipping.");
                return;
            }

            if (!Yes2RB.Checked && !No2RB.Checked)
            {
                MessageBox.Show("Please select teeth cleaning.");
                return;
            }

            Booking.HairCut = HairCut;
            Booking.Shampoo = Shampoo;
            Booking.NailClip = NailClip;
            Booking.FleaTreatment = FleaTreatment;
            Booking.TeethCleaning = TeethCleaning;

            BookingForm book = new BookingForm();
            book.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RMTagL_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddOnForm_Load(object sender, EventArgs e)
        {
            if (Booking.HairCut == "Korean Haircut") KoreanCutRB.Checked = true;
            else if (Booking.HairCut == "Dinasour Haircut") DinasourCutRB.Checked = true;
            else if (Booking.HairCut == "Lion Haircut") LionCutRB.Checked = true;
            else if (Booking.HairCut == "Belly Haircut") BellyCutRB.Checked = true;

            if (!string.IsNullOrEmpty(Booking.Shampoo))
            {
                comboBox1.SelectedItem = Booking.Shampoo;
            }

            if (!string.IsNullOrEmpty(Booking.FleaTreatment))
            {
                listBox1.SelectedItem = Booking.FleaTreatment;
            }

            if (Booking.NailClip == "Nail Clipping") YesRB.Checked = true;
            else if (Booking.NailClip == "No") NoRB.Checked = true;

            if (Booking.TeethCleaning == "Teeth Cleaning") Yes2RB.Checked = true;
            else if (Booking.TeethCleaning == "No") No2RB.Checked = true;
        }
    }
}
