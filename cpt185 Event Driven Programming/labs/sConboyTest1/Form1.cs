//Shawn Conboy
//CPT 185 A01H
//Test 1

namespace sConboyTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //variables
            decimal price = 0;
            decimal transmissionCost = 0;
            decimal taxRate = 0;
            decimal subtotal = 0;
            decimal taxes = 0;
            decimal total = 0;
            decimal hybridRate = 0.02m;

            //Cost
            if (manufacturerListbox.SelectedIndex != -1 && transmissionListbox.SelectedIndex != -1)
            {
                if (manufacturerListbox.SelectedItem == "Lamborghini")
                {
                    price = 250000;
                }
                else if (manufacturerListbox.SelectedItem == "Ferrari")
                {
                    price = 150000;
                }
                else if (manufacturerListbox.SelectedItem == "Corvette")
                {
                    price = 75000;
                }
                else if (manufacturerListbox.SelectedItem == "Tesla")
                {
                    price = 90000;
                }
                else if (manufacturerListbox.SelectedItem == "Bentley")
                {
                    price = 500000;
                }

                priceTextbox.Text = price.ToString("c");

                if (transmissionListbox.SelectedItem == "Manual")
                {
                    transmissionCost = 0;
                }
                else if (transmissionListbox.SelectedItem == "Automatic")
                {
                    transmissionCost = 5000;
                }
                else if (transmissionListbox.SelectedItem == "Hybrid")
                {
                    transmissionCost = price * hybridRate;
                }

                carChoiceLabel.Text = manufacturerListbox.SelectedItem.ToString();

                transmissionLabel.Text = transmissionListbox.SelectedItem.ToString();

                transmissionTypeTextbox.Text = transmissionCost.ToString("c");

                // Taxes
                if (taxRateTextbox.Text == "")
                {
                    MessageBox.Show("Please ensure tax rate is entered.");
                    taxRateTextbox.Focus();
                }
                else
                {
                    if (decimal.TryParse(taxRateTextbox.Text, out taxRate))
                    {
                        subtotal = price + transmissionCost;
                        subTotalTextbox.Text = subtotal.ToString("c");

                        taxesLabel.Text = taxRate + "% tax";
                        taxRate = taxRate / 100;

                        taxes = taxRate * subtotal;
                        taxesTextbox.Text = taxes.ToString("c");

                        total = subtotal + taxes;
                        totalTextbox.Text = total.ToString("c");
                    }
                    else
                    {
                        MessageBox.Show("Plese enter a real number for the tax rate (0-100)");
                        taxRateTextbox.Text = "";
                        taxRateTextbox.Focus();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Please ensure you've selected a car and transmission type.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            manufacturerListbox.SelectedIndex = -1;
            transmissionListbox.SelectedIndex = -1;
            priceTextbox.Clear();
            transmissionTypeTextbox.Clear();
            subTotalTextbox.Clear();
            taxesTextbox.Clear();
            totalTextbox.Clear();
            taxRateTextbox.Clear();
            taxRateTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
