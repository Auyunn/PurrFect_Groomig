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

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT Price FROM AddOn WHERE AddOnName=@name",
                    con);

                cmd.Parameters.AddWithValue("@name", addOnName);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    price = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return price;
        }

        private void summaryBTN_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                listBox3.Items.Clear();


                PriceCalculator calc = new PriceCalculator();
                decimal price = 0;

                if (KoreanCutRB.Checked)
                {
                    price = GetAddOnPrice("Korean Haircut");
                    PremiumService item = new PremiumService { ItemName = "Korean Haircut", FixedPrice = price };
                    calc.AddItem(item); 

                    listBox2.Items.Add(item.ItemName);
                    listBox3.Items.Add(item.GetPrice()); 
                }
                else if (LionCutRB.Checked)
                {
                    price = GetAddOnPrice("Lion Haircut");
                    PremiumService item = new PremiumService { ItemName = "Lion Haircut", FixedPrice = price };
                    calc.AddItem(item);

                    listBox2.Items.Add(item.ItemName);
                    listBox3.Items.Add(item.GetPrice());
                }
                else if (DinasourCutRB.Checked)
                {
                    price = GetAddOnPrice("Dinasour Haircut");
                    PremiumService item = new PremiumService { ItemName = "Dinasour Haircut", FixedPrice = price };
                    calc.AddItem(item);

                    listBox2.Items.Add(item.ItemName);
                    listBox3.Items.Add(item.GetPrice());
                }
                else if (BellyCutRB.Checked)
                {
                    price = GetAddOnPrice("Belly Haircut");
                    PremiumService item = new PremiumService { ItemName = "Belly Haircut", FixedPrice = price };
                    calc.AddItem(item);

                    listBox2.Items.Add(item.ItemName);
                    listBox3.Items.Add(item.GetPrice());
                }

                // SHAMPOO
                if (comboBox1.SelectedItem != null)
                {
                    string shampoo = comboBox1.SelectedItem.ToString();

                    if (shampoo != "None")
                    {
                        price = GetAddOnPrice(shampoo);
                        PremiumService item = new PremiumService { ItemName = shampoo, FixedPrice = price };
                        calc.AddItem(item);

                        listBox2.Items.Add(item.ItemName);
                        listBox3.Items.Add(item.GetPrice());
                    }
                }

                // FLEA
                if (listBox1.SelectedItem != null)
                {
                    string flea = listBox1.SelectedItem.ToString();

                    if (flea != "None")
                    {
                        price = GetAddOnPrice(flea);
                        PremiumService item = new PremiumService { ItemName = flea, FixedPrice = price };
                        calc.AddItem(item);

                        listBox2.Items.Add(item.ItemName);
                        listBox3.Items.Add(item.GetPrice());
                    }
                }

                // NAIL
                if (YesRB.Checked)
                {
                    price = GetAddOnPrice("Nail Clipping");
                    PremiumService item = new PremiumService { ItemName = "Nail Clipping", FixedPrice = price };
                    calc.AddItem(item);

                    listBox2.Items.Add(item.ItemName);
                    listBox3.Items.Add(item.GetPrice());
                }

                // TEETH
                if (Yes2RB.Checked)
                {
                    price = GetAddOnPrice("Teeth Cleaning");
                    PremiumService item = new PremiumService { ItemName = "Teeth Cleaning", FixedPrice = price };
                    calc.AddItem(item);

                    listBox2.Items.Add(item.ItemName);
                    listBox3.Items.Add(item.GetPrice());
                }


                decimal totalPrice = calc.CalculateTotal();

                Booking.TotalPrice = totalPrice;

                label1.Text = "RM " + totalPrice.ToString("0.00");

                int totalItems = listBox3.Items.Cast<object>().Count();

                int premiumItems = listBox3.Items.Cast<object>()
                    .Select(x => Convert.ToDecimal(x))
                    .Count(x => x >= 20);

                TotalItemLabel.Text = "Total Add Ons : " + totalItems;
                ExpensiveItemLabel.Text = "Premium Add Ons : " + premiumItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            // 1. Get data
            if (KoreanCutRB.Checked) HairCut = "Korean Haircut";
            else if (DinasourCutRB.Checked) HairCut = "Dinasour Haircut";
            else if (LionCutRB.Checked) HairCut = "Lion Haircut";
            else if (BellyCutRB.Checked) HairCut = "Belly Haircut";

            if (comboBox1.SelectedItem != null) Shampoo = comboBox1.SelectedItem.ToString();
            if (YesRB.Checked) NailClip = "Nail Clipping";
            if (Yes2RB.Checked) TeethCleaning = "Teeth Cleaning";
            if (listBox1.SelectedItem != null) FleaTreatment = listBox1.SelectedItem.ToString();

            // 2. Validation
            if (HairCut == "" || comboBox1.SelectedItem == null || listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please ensure all add-ons are selected.");
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

            // Save to global variables
            Booking.HairCut = HairCut;
            Booking.Shampoo = Shampoo;
            Booking.NailClip = NailClip;
            Booking.FleaTreatment = FleaTreatment;
            Booking.TeethCleaning = TeethCleaning;

            // if pet is 0
            if (Booking.PetID <= 0)
            {
                Booking.PetID = 1;
            }

            // 3. Database Operation
            try
            {
                con.Open();

                string query = "INSERT INTO Booking (PetID, GroomerID, ServiceID, BookingDate, BookingTime, Status, TotalPrice) " +
                               "VALUES (@pet, @groom, @service, @date, @time, @status, @total); " +
                               "SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, con);

                
                cmd.Parameters.AddWithValue("@pet", Booking.PetID <= 0 ? 1 : Booking.PetID);
                cmd.Parameters.AddWithValue("@groom", Booking.GroomerID);   
                cmd.Parameters.AddWithValue("@service", Booking.ServiceID);

                cmd.Parameters.AddWithValue("@date", Booking.BookingDate);
                cmd.Parameters.AddWithValue("@time", Booking.TimeSlot);
                cmd.Parameters.AddWithValue("@status", "Pending"); 
                cmd.Parameters.AddWithValue("@total", Booking.TotalPrice);

                object newId = cmd.ExecuteScalar();
                if (newId != null)
                {
                    Booking.BookingID = Convert.ToInt32(newId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Booking save error: " + ex.Message);
                return;
            }
            finally
            {
                con.Close();
            }

            // 4. Move to next form
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
