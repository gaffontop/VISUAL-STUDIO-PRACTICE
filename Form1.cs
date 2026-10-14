namespace _048_Baldonado_Cale_PACT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxmealPrice.Items.Add("Burger Meal- 120");
            comboBoxmealPrice.Items.Add("Chicken Meal- 150");
            comboBoxmealPrice.Items.Add("Spaghetti Meal- 130");
            comboBoxmealPrice.Items.Add("Pizza Meal- 250");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double mealPrice = 0;
            double drinkPrice = 0;
            double addOnPrice = 0;

            if (comboBoxmealPrice.SelectedItem != null)
            {
                string selectedMeal = comboBoxmealPrice.SelectedItem.ToString();
                if (selectedMeal.Contains("Burger"))
                {
                    mealPrice = 120;
                }
                else if (selectedMeal.Contains("Chicken"))
                {
                    mealPrice = 150;
                }
                else if (selectedMeal.Contains("Spaghetti"))
                {
                    mealPrice = 130;
                }
                else if (selectedMeal.Contains("Pizza"))
                {
                    mealPrice = 250;
                }
            }
            else
            {
                MessageBox.Show("Please select a main meal first.");
                return;
            }

            if (radioButtonMedium.Checked)
            {
                drinkPrice = 20;
            }
            else if (radioButtonLarge.Checked)
            {
                drinkPrice = 40;
            }

            if (checkBoxFries.Checked)
            {
                addOnPrice += 50;
            }
            if (checkBoxExtra.Checked)
            {
                addOnPrice += 25;
            }
            if (checkBoxDessert.Checked)
            {
                addOnPrice += 70;
            }

            double subttotal = mealPrice + drinkPrice + addOnPrice;
            double discount = 0;

            if (subttotal >= 400)
            {
                discount += subttotal * 0.10;
            }
            if (chkboxSenior.Checked && chkboxSenior != null)

            {
                discount += subttotal * 0.20;
            }
            double finaltotal = subttotal - discount;

            string summary = "=== ORDER SUMMARY ===\n" +
                             $"Meal Price: ₱{mealPrice}\n" +
                             $"Drink Price: ₱{drinkPrice}\n" +
                             $"Add-ons Total: ₱{addOnPrice}\n" +
                             $"-------------------------\n" +
                             $"Subtotal: ₱{subttotal:F2}\n" +
                             $"Discount Applied: ₱{discount:F2}\n" +
                             $"-------------------------\n" +
                             $"Total Amount Due: ₱{finaltotal:F2}";

            MessageBox.Show(summary, "FastBite Express");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            comboBoxmealPrice.SelectedIndex = -1;
            radioButtonSmall.Checked = true;
            radioButtonMedium.Checked = false;
            radioButtonLarge.Checked = false;

            checkBoxFries.Checked = false;
            checkBoxExtra.Checked = false;
            checkBoxDessert.Checked = false;
            chkboxSenior.Checked = false;
            
        }

    }
    }


