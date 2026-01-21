namespace romanNumeralConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //variables
            int userNumber = 0;
            string convertedNumber = "";
            string roman = "";

            //parse the data
            if (int.TryParse(userNumberTextbox.Text, out userNumber))
            {
                if (!(userNumber < 1 || userNumber > 10))
                {
                    switch (userNumber)
                    {
                        case 1:
                            roman = "I";
                            break;
                        case 2:
                            roman = "II";
                            break;
                        case 3:
                            roman = "III";
                            break;
                        case 4:
                            roman = "IV";
                            break;
                        case 5:
                            roman = "V";
                            break;
                        case 6:
                            roman = "VI";
                            break;
                        case 7:
                            roman = "VII";
                            break;
                        case 8:
                            roman = "VIII";
                            break;
                        case 9:
                            roman = "IX";
                            break;
                        case 10:
                            roman = "X";
                            break;
                    }
                    conversionLabel.Text = "Converted : " + roman;
                }
                else
                {
                    MessageBox.Show("Please enter a number between 1 and 10.");
                }
            }
            else
            {
                MessageBox.Show("You must enter a number between 1 and 10.");
            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userNumberTextbox.Clear();
            conversionLabel.Text = "Converted : ";
            userNumberTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
