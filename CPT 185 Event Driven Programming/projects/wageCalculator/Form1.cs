namespace wageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculatePayButton_Click(object sender, EventArgs e)
        {
            double hoursWorked = 0;
            double hourlyRate = 0;
            double gross = 0;
            double afterTaxes = 0;

            hoursWorked = double.Parse(hoursWorkedTextbox.Text);
            hourlyRate = double.Parse(payRateTextbox.Text);

            gross = hoursWorked * hourlyRate;

            totalPayResultLabel.Text = gross.ToString();

            afterTaxes = gross * 0.7;
            afterTaxesResultLabel.Text = afterTaxes.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
