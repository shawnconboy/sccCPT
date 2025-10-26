namespace frequentCharacter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // take user string. check what character appears the most
            string userString = userTextbox.Text;
            char mostFrequent = ' ';
            int highestCount = 0;

            // dictionary to hold character and it's appearance count
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            // loop through each and add a count
            foreach (char c in userString)
            {
                if (c == ' ')
                {
                    continue;
                }
                if (characterCount.ContainsKey(c))
                {
                    characterCount[c]++;
                }
                else
                {
                    characterCount[c] = 1;
                }
            }

            // check the dictionary for which character appeared the most
            // assign values to winner
            foreach (var pair in characterCount)
            {
                if (pair.Value > highestCount)
                {
                    mostFrequent = pair.Key;
                    highestCount = pair.Value;
                }
            }

            // print data to user
            resultLabel.Text = $"{mostFrequent}";
            quantityLabel.Text = $"{highestCount}";
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
