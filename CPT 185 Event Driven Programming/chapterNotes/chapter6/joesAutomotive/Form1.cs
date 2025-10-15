//Shawn Conboy
//CPT 185 A01H
//Lab 6 Joes Automotive
namespace joesAutomotive
{
    public partial class Form1 : Form
    {

        private double time = 0;
        private double salesTax = 0.06;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            time = 0;

            double partsTotal = partsCharges();
            double taxes = taxCharges();
            double laborCharges = time * 20;
            double grandTotal = totalCharges(partsTotal, taxes, laborCharges);

            serviceAndLaborlabel.Text = laborCharges.ToString("C");
            partsLabel.Text = partsTotal.ToString("C");
            taxOnPartsLabel.Text = taxes.ToString("c");
            totalFeesLabel.Text = grandTotal.ToString("c");
        }

        private double oilLubeCharges()
        {
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

            if (radiatorCheckbox.Checked)
            {
                total += radiator;
                time += 1;
            }

            if (transmissionCheckbox.Checked)
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

            if (inspectionCheckbox.Checked)
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
            double parts = 0;
            double labor = 0;
            double total = 0;

            double.TryParse(partsTextbox.Text, out parts);
            double.TryParse(laborTextbox.Text, out labor);

            time += labor;
            total += parts;

            return total;
        }

        private double taxCharges()
        {
            double totalPartsCost = 0;
            double.TryParse(partsTextbox.Text, out totalPartsCost);

            double total = 0;
            total = totalPartsCost * salesTax;

            return total;
        }

        private double partsCharges()
        {
            double partsTotal = oilLubeCharges()
                                + flushCharges()
                                + miscCharges()
                                + otherCharges();

            return partsTotal;
        }

        private double totalCharges(double partsTotal, double taxes, double laborCharges)
        {
            double finalTotal = partsTotal + taxes + laborCharges;

            return finalTotal;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearFluids();
            clearFlushes();
            clearMisc();
            clearOther();
            clearFees();
        }

        private void clearFluids()
        {
            oilChangeCheckbox.Checked = false;
            lubeJobCheckbox.Checked = false;
        }

        private void clearFlushes()
        {
            radiatorCheckbox.Checked = false;
            transmissionCheckbox.Checked = false;
        }

        private void clearMisc()
        {
            inspectionCheckbox.Checked = false;
            replaceMufflerCheckbox.Checked = false;
            tireRotationCheckbox.Checked = false;
        }

        private void clearOther()
        {
            partsTextbox.Clear();
            laborTextbox.Clear();
        }

        private void clearFees()
        {
            serviceAndLaborlabel.Text = "$0.00";
            partsLabel.Text = "$0.00";
            taxOnPartsLabel.Text = "$0.00";
            totalFeesLabel.Text = "$0.00";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
