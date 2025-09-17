using System.Diagnostics.Tracing;

namespace salePriceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // variables

            decimal originalPrice = 0;
            decimal discountPercent = 0;
            decimal discountAmount = 0;
            decimal salePrice = 0;

            originalPrice = decimal.Parse(originalPriceTextbox.Text);
            discountPercent = decimal.Parse(discountTextbox.Text);

            discountPercent = discountPercent / 100;

            discountAmount = originalPrice * discountPercent;

            salePrice = originalPrice - discountAmount;

            salePriceTextbox.Text = salePrice.ToString("c");
            salePriceTextbox.BackColor = Color.White;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
