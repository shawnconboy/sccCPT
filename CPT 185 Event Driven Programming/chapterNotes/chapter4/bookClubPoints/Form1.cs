namespace bookClubPoints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //variables
            int booksPurchased = 0;
            int pointsTotal = 0;
            int pointsAwarded = 0;

            //parse data
            if (int.TryParse(purchasedTextbox.Text, out booksPurchased))
            {
                if (booksPurchased < 0)
                {
                    MessageBox.Show("Please enter a positive number.");
                    purchasedTextbox.Clear();
                    purchasedTextbox.Focus();
                }
                else
                {
                    switch (booksPurchased)
                    {
                        case 0:
                            pointsAwarded = 0;
                            break;
                        case 1:
                            pointsAwarded = 5;
                            break;
                        case 2:
                            pointsAwarded = 15;
                            break;
                        case 3:
                            pointsAwarded = 30;
                            break;
                        default:
                            pointsAwarded = 60;
                            break;
                    }

                    pointsLabel.Text = pointsAwarded.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please enter a number.");
                purchasedTextbox.Clear();
                purchasedTextbox.Focus();
            }               
         }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pointsLabel.Text = "";
            purchasedTextbox.Clear();
            purchasedTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
