namespace passwordValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string password = passwordTextbox.Text;

            int uppercase = checkUppercase(password);
            int lowercase = checkLower(password);
            int numeric = checkNumeric(password);
            int length = password.Length;
            int minLength = 8;

            MessageBox.Show($"Uppercase letter(s) : {uppercase.ToString()}\nLowercase letter(s) : {lowercase.ToString()}\nNumeric Digits : {numeric.ToString()}");

            if (length >= minLength &&
                uppercase >= 1 &&
                lowercase >= 1 &&
                numeric   >= 1)
            {
                MessageBox.Show("Valid password.");
            }
            else
            {
                MessageBox.Show("Invalid password.");
            }
        }

        private int checkUppercase(string password)
        {
            int upper = 0;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    upper++;
                }
            }

            return upper;
        }

        private int checkLower(string password)
        {
            int lower = 0;

            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    lower++;
                }
            }
            return lower;
        }

        private int checkNumeric(string password)
        {
            int numeric = 0;

            foreach(char c in password)
            {
                if (char.IsDigit(c))
                {
                    numeric++;
                }
            }
            return numeric;
        }

        private int totalLength(string password)
        {
            int length = password.Length;

            return length;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
