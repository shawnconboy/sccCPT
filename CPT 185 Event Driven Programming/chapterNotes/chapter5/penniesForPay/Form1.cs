namespace penniesForPay
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
            int daysWorked = 0;
            int pay = 1;
            int payDoubled = 0;
            int totalPay = 0;

            if (!(int.TryParse(numDaysTextbox.Text, out daysWorked)))
            {
                MessageBox.Show("Please enter valid number of days worked.");
            }
            else
            {

                if (daysWorked == 1)
                {
                    totalPay = 1;
                }
                else
                {
                    for (int i = 1; i < daysWorked; i++)
                    {
                        payDoubled = pay * 2;
                        totalPay += payDoubled;
                        pay = payDoubled;
                    }
                }
                    

                resultLabel.Text = "Total Pay is " + totalPay.ToString();
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numDaysTextbox.Clear();
            numDaysTextbox.Focus();
            resultLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
