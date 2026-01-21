namespace sConboyLab6
{
    public partial class Form1 : Form
    {

        private double time = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // reset time so hours don't accumulate across clicks
            time = 0;

            double totalFluidCharges = oilLubeCharges();
            double totalFlushCharges = flushCharges();
            double totalMiscCharges = miscCharges();
            double totalOtherCharges = otherCharges();
            double salesTax = 0;
            double finalTotal = 0;
            double hourlyRate = 20;
            double totalLabor = 0;

            if (totalOtherCharges > 0)
            {
                salesTax = taxCharges();
            }
            else
            {
                salesTax = 0;
            }

            totalLabor = hourlyRate * time;


            serviceAndLaborLabel.Text = totalLabor.ToString("c");

            taxOnPartsLabel.Text = salesTax.ToString("c");

            
            finalTotal = totalCharges(totalFluidCharges, totalFlushCharges, totalMiscCharges, totalOtherCharges, salesTax);
            finalTotal += totalLabor;

            totalFeesLabel.Text = finalTotal.ToString("c");
        }


        private double oilLubeCharges()
        {
            // variables
            double oilChange = 26;
            double lubeJob = 18;
            double total = 0;

            if (oilChangeCheckbox.Checked)
            {
                total += oilChange;
                time += 1;
            }

            if (lubeJobCheckbox.Checked)
            {
                total += lubeJob;
                time += 1;
            }

            return total;
        }

        private double flushCharges()
        {
            double radiator = 30;
            double transmission = 80;
            double total = 0;

            if (radiatorFlushCheckbox.Checked)
            {
                total += radiator;
                time += 1;
            }

            if (transmissionFlushCheckbox.Checked)
            {
                total += transmission;
                time += 1;
            }

            return total;
        }

        private double miscCharges()
        {
            double inspection = 15;
            double replaceMuffler = 100;
            double tireRotation = 20;
            double total = 0;

            if (inspectionsCheckbox.Checked)
            {
                total += inspection;
                time += 1;
            }

            if (replaceMufflerCheckbox.Checked)
            {
                total += replaceMuffler;
                time += 1;
            }

            if (tireRotationCheckbox.Checked)
            {
                total += tireRotation;
                time += 1;
            }

            return total;
        }

        private double otherCharges()
        {
            double total = 0;
            double parts = 0;
            double labor = 0;
            bool formFilled = false;

            if (double.TryParse(partsTextbox.Text, out parts))
            {
                if (double.TryParse(laborTextbox.Text, out labor))
                {
                    formFilled = true;
                }
            }

            time += labor;

            if (formFilled)
            {
                total = parts;
                partsLabel.Text = parts.ToString("C");
            }

            return total;
        }

        private double taxCharges()
        {
            double parts = 0;
            double taxRate = 0.06;
            double total = 0;

            double.TryParse(partsTextbox.Text, out parts);

            total = parts * taxRate;

            return total;
        }

        // keep a totalCharges method; this one just adds the precomputed values
        private double totalCharges(double totalFluidCharges, double totalFlushCharges, double totalMiscCharges, double totalOtherCharges, double salesTax)
        {
            double total = totalFluidCharges + totalFlushCharges + totalMiscCharges + totalOtherCharges + salesTax;
            return total;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
