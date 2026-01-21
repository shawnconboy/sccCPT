using System;

namespace pigLatin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string userEntry = userTextbox.Text;
            string result = "";

            // convert each word to pig latin
            string[] words = userEntry.Split(null);

            foreach (string word in words)
            {
                // remove first letter
                // place letter at end of words
                // append "ay" to word
                char firstLetter = word[0];
                string wordWithoutFirstLetter = word.Substring(1);
                result += $"{wordWithoutFirstLetter}{firstLetter}ay ";
            }
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
