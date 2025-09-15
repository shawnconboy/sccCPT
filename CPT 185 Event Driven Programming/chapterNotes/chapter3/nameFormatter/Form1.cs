namespace nameFormatter
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

        private void suffixFirstMiddleLastButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextbox.Text;
            string middleName = middleNameTextbox.Text;
            string lastName = lastNameTextbox.Text;
            string suffix = suffixTextbox.Text;

            resultLabel.Text = suffix + " " + firstName + " " + middleName + " " + lastName;
        }

        private void firstMiddleLastButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextbox.Text;
            string middleName = middleNameTextbox.Text;
            string lastName = lastNameTextbox.Text;

            resultLabel.Text = firstName + " " + middleName + " " + lastName;
        }

        private void firstLastButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextbox.Text;
            string lastName = lastNameTextbox.Text;

            resultLabel.Text = firstName + " " + lastName;

        }

        private void lastFirstMiddleSuffixButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextbox.Text;
            string middleName = middleNameTextbox.Text;
            string lastName = lastNameTextbox.Text;
            string suffix = suffixTextbox.Text;

            resultLabel.Text = lastName + ", " + firstName + ", " + middleName + ", " + suffix;
        }

        private void lastFirstMiddleButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextbox.Text;
            string middleName = middleNameTextbox.Text;
            string lastName = lastNameTextbox.Text;

            resultLabel.Text = lastName + ", " + firstName + ", " + middleName;
        }

        private void lastFirstButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextbox.Text;
            string lastName = lastNameTextbox.Text;

            resultLabel.Text = lastName + ", " + firstName;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            firstNameTextbox.Clear();
            middleNameTextbox.Clear();
            lastNameTextbox.Clear();
            suffixTextbox.Clear();

            firstNameTextbox.Focus();
        }
    }
}
