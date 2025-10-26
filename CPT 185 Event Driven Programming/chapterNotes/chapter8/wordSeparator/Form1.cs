namespace wordSeparator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // take user string (ex: StopAndSmellTheRoses)
            string userString = userTextbox.Text;

            // create an empty string that will hold our new spaced words
            string result = "";

            // walk through each character in the string
            foreach (char c in userString)
            {
                // if the letter is uppercase and it's NOT the first letter
                // we want to add a space before it
                if (char.IsUpper(c) && result.Length > 0)
                {
                    result += " ";
                }

                // add the lowercase version of the current letter
                result += char.ToLower(c);
            }

            // show the final spaced-out version
            resultLabel.Text = result;
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            userTextbox.Clear();
            userTextbox.Focus();
            resultLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
