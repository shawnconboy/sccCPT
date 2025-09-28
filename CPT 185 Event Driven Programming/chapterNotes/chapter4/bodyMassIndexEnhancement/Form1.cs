namespace bodyMassIndexEnhancement
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
            double height = 0;
            double weight = 0;
            double bmi = 0;

            //parse data

            if(!(double.TryParse(heightTextbox.Text, out height)))
            {
                MessageBox.Show("Please enter a number in the height box.");
            }

            if(!(double.TryParse(weightTextbox.Text, out weight)))
            {
                MessageBox.Show("Please enter a number in the weight box.");
            }

            bmi = weight * 703 / (height * height);

            bmiTextbox.Text = bmi.ToString("F2");

            if (bmi >= 25)
            {
                resultLabel.Text = "You are overweight.";
            }
            else if (bmi >= 18.5)
            {
                resultLabel.Text = "Your BMI is optimal.";
            }
            else
            {
                resultLabel.Text = "You are underweight.";
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            heightTextbox.Clear();
            weightTextbox.Clear();
            bmiTextbox.Clear();

            resultLabel.Text = "";
            heightTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
