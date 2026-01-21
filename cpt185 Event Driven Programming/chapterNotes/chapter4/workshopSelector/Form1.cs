using System.Numerics;

namespace workshopSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int numDays = 0;
            decimal fee = 0.0m;
            decimal lodging = 0.0m;
            decimal total = 0.0m;

            if (workshopListbox.SelectedIndex != -1 && locationListbox.SelectedIndex != -1)
            {

                switch (workshopListbox.SelectedItem.ToString())
                {
                    case "Handling Stress":
                        numDays = 3;
                        fee = 1000.00m;
                        break;

                    case "Time Management":
                        numDays = 3;
                        fee = 800.00m;
                        break;

                    case "Supervision Skills":
                        numDays = 3;
                        fee = 1500.00m;
                        break;

                    case "Negotiation":
                        numDays = 5;
                        fee = 1300.00m;
                        break;

                    case "How to Interview":
                        numDays = 1;
                        fee = 500.00m;
                        break;

                }

                switch (locationListbox.SelectedItem.ToString())
                {
                    case "Austin":
                        lodging = 150.00m;
                        break;

                    case "Chicago":
                        lodging = 225.00m;
                        break;

                    case "Dallas":
                        lodging = 175.00m;
                        break;

                    case "Orlando":
                        lodging = 300.00m;
                        break;

                    case "Phoenix":
                        lodging = 175.00m;
                        break;

                    case "Raleigh":
                        lodging = 150.00m;
                        break;

                }

                total = (numDays * lodging) + fee;
            }
            else
            {
                MessageBox.Show("Both boxes must be selected.");
                return;
            }

            outputLabel.Text = "Registration: " + fee.ToString("c") + "\nLodging: " + lodging.ToString("c") + " x " + numDays + " days = " + (lodging * numDays).ToString("c") + "\nTotal: " + total.ToString("c");



        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            locationListbox.SelectedIndex = -1;
            workshopListbox.SelectedIndex = -1;

            outputLabel.Text = "";
        }
    }
}
