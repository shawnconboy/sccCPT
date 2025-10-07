//Shawn Conboy
//CPT 185 A01H
//Lab 5

namespace sConboyLab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showResultsButton_Click(object sender, EventArgs e)
        {
            // what does the program do?
            // predicts total organism size after
            // calculations

            // variables
            double startingNum = 0;
            double averageIncrease = 0;
            double numDaysToMultiply = 0;
            double currentPop = 0;


            // parse the starting number
            if (!(double.TryParse(startingNumTextbox.Text, out startingNum)))
            {
                MessageBox.Show("Please enter a valid number of organisms.");
            }
            else
            {
                // parse the average
                if (!(double.TryParse(averageTextbox.Text, out averageIncrease)))
                {
                    MessageBox.Show("Please enter a valid average daily increase percentage.");
                }
                else
                {
                    resultsListbox.Items.Clear();

                    averageIncrease = averageIncrease / 100;

                    // parse the number of days to multiply by
                    if (!(double.TryParse(numDaysTextbox.Text, out numDaysToMultiply)))
                    {
                        MessageBox.Show("Please enter a valid number of days to multiply.");
                    }
                    else
                    {
                        currentPop = startingNum;
                        resultsListbox.Items.Add("Day 0 population : " + currentPop.ToString("F2"));

                        // do calculations and print to the list.
                        for (int i = 1; i <= numDaysToMultiply; i++)
                        {
                            currentPop = currentPop + (currentPop * averageIncrease);
                            resultsListbox.Items.Add("Day " + i + " population : " + currentPop.ToString("N2"));
                        }
                    }
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            startingNumTextbox.Clear();
            averageTextbox.Clear();
            numDaysTextbox.Clear();
            resultsListbox.Items.Clear();

            startingNumTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
