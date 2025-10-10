namespace hospitalCharges
{
    public partial class Form1 : Form
    {

        // variables
        private int dailyFee = 350;
        private double grandTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // reset total to 0 before calculating
            grandTotal = 0;
            int stayFee = stayCharges();
            double miscFee = miscCharges();
            grandTotal = grandTotal + miscCharges() + stayCharges();

            stayFeeLabel.Text = "Stay Fee : " + stayFee.ToString("C");
            miscFeeLabel.Text = "Misc Fee : " + miscFee.ToString("C");
            grandTotalLabel.Text = "Grand Total : " + grandTotal.ToString("C");

        }

        private int stayCharges()
        {
            int daysSpent;
            int total;

            int.TryParse(daysSpentTextbox.Text, out daysSpent);

            total = dailyFee * daysSpent;
            return total;
        }

        private double miscCharges()
        {
            double medicationCharges, surgicalCharges, labFees, rehabCharges, total;

            double.TryParse(medicationTextbox.Text, out medicationCharges);
            double.TryParse(surgicalTextbox.Text, out surgicalCharges);
            double.TryParse(labFeesTextbox.Text, out labFees);
            double.TryParse(rehabTextbox.Text, out rehabCharges);

            total = medicationCharges + surgicalCharges + labFees + rehabCharges;

            return total;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            daysSpentTextbox.Clear();
            medicationTextbox.Clear();
            surgicalTextbox.Clear();
            labFeesTextbox.Clear();
            rehabTextbox.Clear();

            daysSpentTextbox.Focus();

            stayFeeLabel.Text = "Stay Fee : $0.00";
            miscFeeLabel.Text = "Misc Fee : $0.00";
            grandTotalLabel.Text = "Grand Total : $0.00";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
