namespace softwareSales
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
            int amountPurchased = 0;
            double discountAmount = 0;
            double discountTotal = 0;
            double total = 0;
            int softwarePrice = 99;

            //parse data

            if (!(int.TryParse(amountPurchasedTextbox.Text, out amountPurchased)))
            { 
                MessageBox.Show("Please enter a valid number.");
                amountPurchasedTextbox.Clear();
                amountPurchasedTextbox.Focus();
            }
            else
            {
                if (amountPurchased >= 100)
                {
                    discountAmount = 0.50;
                }
                else if (amountPurchased >= 50)
                {
                    discountAmount = 0.40;
                }
                else if (amountPurchased >= 20)
                {
                    discountAmount = 0.30;
                }
                else if (amountPurchased >= 10)
                {
                    discountAmount = 0.20;
                }
                else
                {
                    discountAmount = 0.00;
                    discountLabel.Text = "Discount : Sorry. No discount.";
                }

                

                total = amountPurchased * softwarePrice;

                discountTotal = total * discountAmount;

                if (discountAmount > 0)
                {
                    discountLabel.Text = "Discount : " + discountTotal.ToString("c");
                }

                total = total - discountTotal;

                totalLabel.Text = "Total : " + total.ToString("c");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            amountPurchasedTextbox.Clear();
            discountLabel.Text = "Discount :";
            totalLabel.Text = "Total :";
            amountPurchasedTextbox.Focus();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
