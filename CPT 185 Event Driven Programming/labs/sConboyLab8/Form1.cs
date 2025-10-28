// Shawn Conboy
// CPT 168 AO1H
// Lab 8 Morse Converter
namespace sConboyLab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {

            try
            {
                // need a data structure to hold normal letters and morse conversions
                // parallel array or dictionary. dictionary would probably be easier
                // but i've yet to really work with a dictionary in c#
                char[] normalCharacter =
                {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
                'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                '.', ',', '?', ' '
            };

                string[] morseCharacter =
                {
                ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..",
                ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.",
                "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..",
                "-----", ".----", "..---", "...--", "....-", ".....",
                "-....", "--...", "---..", "----.",
                ".-.-.-", "--..--", "..--..", "space"
            };

                // get user string from textbox
                string userString = userTextbox.Text.ToUpper();
                string result = "";

                // walk through user string and convert char to morse string.
                foreach (char c in userString)
                {
                    for (int i = 0; i < normalCharacter.Length; i++)
                    {
                        if (c == normalCharacter[i])
                        {
                            result += morseCharacter[i] + "   ";
                            break;
                        }
                    }
                }
                // clean up the result and push it to the label
                result = result.TrimEnd();
                resultLabel.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            
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
