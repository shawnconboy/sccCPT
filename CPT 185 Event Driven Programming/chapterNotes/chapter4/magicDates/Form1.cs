namespace magicDates
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

        private void checkButton_Click(object sender, EventArgs e)
        {
            //parse user data

            if (!(int.TryParse(monthTextbox.Text, out int month)))
            {
                //bad data entered - conversion failed
                MessageBox.Show("Please enter a 2 digit month");
            }
            else
            {
                if (month > 0 && month < 13)
                {

                }
                else
                {
                    MessageBox.Show("Please enter a valid 2 digit month ( 1 - 12 )");
                }
            }

            if (!(int.TryParse(dayTextbox.Text, out int day)))
            {
                //bad data entered - conversion failed
                MessageBox.Show("Please enter a 2 digit day");
            }
            else
            {
                if (day < 0 && day > 32)
                {
                    MessageBox.Show("Please enter a valid day between 1 and 31");
                }
            }
            int year = 0;
            if (int.TryParse(yearTextbox.Text, out year))
            {
                // less than 3 digits
                // parse text
                if (year <= 0 || year >= 100)
                {
                    MessageBox.Show("Please enter a valid 2 digit year");
                }
            }
            else
            {
                // invalid entry
                MessageBox.Show("Please enter a 2 digit year");
            }

            int magicNumber = month * day;

            if (magicNumber == year)
            {
                resultLabel.Text = "Is it magic? Yes!";
            }
            else
            {
                resultLabel.Text = "Is it magic? No!";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayTextbox.Text = "";
            monthTextbox.Text = "";
            yearTextbox.Text = "";
            resultLabel.Text = "Is it magic?";
        }

      
    }
}
