namespace massAndWeight
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
            double mass = 0;
            double weight = 0;
            double result = 0;

            //parse data
            if (!(double.TryParse(userMassTextbox.Text, out mass)))
            {
                MessageBox.Show("Please enter a number.");
            }

            //conversion and specifics
            weight = mass * 9.8;

            if (weight > 1000)
            {
                resultLabel.Text = "Object is too heavy.";
            }
            else if (weight < 10)
            {
                resultLabel.Text = "Object is too light.";
            }
            else
            {
                resultLabel.Text = "Object weight (n) : " + weight;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userMassTextbox.Clear();
            resultLabel.Text = "Object weight (n) : ";
            userMassTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
