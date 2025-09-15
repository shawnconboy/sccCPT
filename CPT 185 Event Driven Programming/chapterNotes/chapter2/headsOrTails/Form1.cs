namespace headsOrTails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void headsButton_Click(object sender, EventArgs e)
        {
            tailsImage.Visible = false;
            headsImage.Visible = true;
        }

        private void tailsButton_Click(object sender, EventArgs e)
        {
            headsImage.Visible = false;
            tailsImage.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using.");
            this.Close();
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random(); //Creates a random object called rand

            if (rand.Next() % 2 == 0)
            {
                // divisible by 2 == even
                tailsImage.Visible = false;
                headsImage.Visible = true;
            }
            else
            {
                // odd numbers
                headsImage.Visible = false;
                tailsImage.Visible = true;
            }
        }
    }
}
