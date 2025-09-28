namespace changeForADollar
{
    public partial class Form1 : Form
    {

        //create a random object
        private Random rand = new Random();
        private int targetCents = 0;
        private int userCents = 0;

        public Form1()
        {
            InitializeComponent();
            gamePanel.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startPanel.Visible = false;
            gamePanel.Visible = true;

            targetCents = rand.Next(1, 100);
            userCents = 0;

            targetTextbox.BackColor = Color.White;
            targetTextbox.Text = (targetCents / 100.0).ToString("C2");
        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pennyImg_Click(object sender, EventArgs e)
        {
            userCents += 1;
        }

        private void nickelImg_Click(object sender, EventArgs e)
        {
            userCents += 5;
        }

        private void dimeImg_Click(object sender, EventArgs e)
        {
            userCents += 10;
        }

        private void quarterImg_Click(object sender, EventArgs e)
        {
            userCents += 25;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if(userCents == targetCents)
            {
                MessageBox.Show("Sweet. You Win!");
            }
            else if(userCents > targetCents)
            {
                MessageBox.Show("Too high. Take kindergarden again.");
            }
            else
            {
                MessageBox.Show("Nah. That's too low man. What are you smoking?");
            }
        }
    }
}
