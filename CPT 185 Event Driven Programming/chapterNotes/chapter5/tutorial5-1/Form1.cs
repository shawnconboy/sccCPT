namespace tutorial5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //declare variables
            const decimal interestRate = 0.005m;
            decimal balance = 0;
            decimal months = 0;

            int count = 0;

            //parse data

            //gets starting balance
            if (decimal.TryParse(startingBalanceTextbox.Text, out balance))
            {
                //gets number of months
                if (decimal.TryParse(monthsTextbox.Text, out months))
                {

                    //loop per month
                    while (count <= months)
                    {
                        balance = balance + (interestRate * balance);

                        count++;
                    }

                    //show ending balance
                    endingBalanceLabel.Text = balance.ToString("c");
                }
                else
                {
                    MessageBox.Show("Invalid value for months.");
                }
            }
            else
            {
                MessageBox.Show("Invalid value for starting balance.");
            }

            

            

            

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            startingBalanceTextbox.Clear();
            monthsTextbox.Clear();
            endingBalanceLabel.Text = "";
            startingBalanceTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

