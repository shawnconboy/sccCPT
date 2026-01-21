namespace vowelsAndConsonants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // check how many vowels and consonants in string
            string userString = userEntryTextbox.Text.ToLower();

            int vowels = 0;
            int consanants = 0;

            char[] vowelList = { 'a', 'e', 'i', 'o', 'u' };

            // loop through the characters in userString
            foreach (char c in userString)
            {
                if (char.IsLetter(c))
                {
                    if (vowelList.Contains(c))
                    {
                        vowels++;
                    }
                    else
                    {
                        consanants++;
                    }
                }
            }

            vowelsLabel.Text = $"Vowels : {vowels}";
            consonantsLabel.Text = $"Consonants : {consanants}";

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userEntryTextbox.Clear();
            userEntryTextbox.Focus();
            vowelsLabel.Text = "Vowels : ";
            consonantsLabel.Text = "Consonants : ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
