namespace question12_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {

                //file object
                StreamWriter randomOutput;

                //run the show dialog
                if (saveFileDialogRandom.ShowDialog() == DialogResult.OK)
                {
                    //user selected a file and clicked ok
                    randomOutput = File.CreateText(saveFileDialogRandom.FileName);
                }
                else
                {
                    MessageBox.Show("You did not select a file.");
                    return;
                }



                Random rand = new Random();

                //parse data
                int userInput = int.Parse(userTextbox.Text);

                for (int i = 0; i < userInput; i++)
                {
                    //print random numbers
                    randomOutput.WriteLine(rand.Next(101).ToString());
                }

                MessageBox.Show("File was created.");
                userTextbox.Clear();
                userTextbox.Focus();

                //close file
                randomOutput.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userTextbox.Clear();
            userTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            string num = "";
            int randomNum = 0;

            double total = 0.0;
            int count = 0;
            double average = 0;

            try
            {
                StreamReader inputFile;

           

                if (OpenFileDialogRandom.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(OpenFileDialogRandom.FileName);

                    while (!inputFile.EndOfStream)
                    {
                        num = inputFile.ReadLine();
                        randomNum = int.Parse(num);
                        randomNumbersListbox.Items.Add(num);
                        count++;
                    }
                    MessageBox.Show("Read: " + count + " numbers.");
                }
            }
            catch
            {

            }
        }
    }
}
