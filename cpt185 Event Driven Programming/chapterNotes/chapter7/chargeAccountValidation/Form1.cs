namespace chargeAccountValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                // create array
                int[] accounts = new int[18];
                int count = 0;

                // open the file
                StreamReader inputFile;
                inputFile = File.OpenText("ChargeAccounts.txt");

                // read values into array
                while (count < accounts.Length && !inputFile.EndOfStream)
                {
                    accounts[count] = int.Parse(inputFile.ReadLine());
                    count++;
                }

                inputFile.Close();

                // get user entry
                int userEntry = int.Parse(userEntryTextbox.Text);
                bool found = false;

                // search array
                for (int i = 0; i < count; i++)
                {
                    if (accounts[i] == userEntry)
                    {
                        found = true;
                        break;
                    }
                }

                // display message once, after search
                if (found)
                {
                    MessageBox.Show("Account " + userEntry + " found.");
                }
                else
                {
                    MessageBox.Show("Account not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userEntryTextbox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
