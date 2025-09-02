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
            double originalPrice, discountPercent, salePrice;

            originalPrice = double.Parse(originalPriceTextbox.Text);
            discountPercent = double.Parse(discoutPercentTextbox.Text);

            discountPercent = discountPercent / 100;

            salePrice = originalPrice - (originalPrice * discountPercent);

            salePriceLabel.Text = salePrice.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            originalPriceTextbox.Clear();
            discoutPercentTextbox.Clear();
            salePriceLabel.Text = "";
            originalPriceTextbox.Focus();
        }
    }
}
