namespace changeForADollar
{
    public partial class Form1 : Form
    {

        //create a random object
        private Random rand = new Random();
        private double targetCents = 0;
        private double userCents = 0;

        private double requiredAmount = 0;

        private double penniesSelected = 0;
        private double nickelsSelected = 0;
        private double dimesSelected = 0;
        private double quartersSelected = 0;


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
            requiredAmount = 100 - targetCents;
            userCents = 0;

            targetTextbox.BackColor = Color.White;
            targetTextbox.Text = (targetCents / 100.0).ToString("C2");
        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello. The goal of this game is to\nenter the correct amount of change needed to\nreach $1.00\n\nClick a coin to begin counting.\nPress the Check button when you think you got it.\nGood Luck!");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //_______________________________________________________

        //game logic

        private void pennyImg_Click(object sender, EventArgs e)
        {
            userCents += 1;
            penniesSelected += 1;
            penniesSelectedLabel.Text = "Pennies : " + penniesSelected.ToString();
        }

        private void nickelImg_Click(object sender, EventArgs e)
        {
            userCents += 5;
            nickelsSelected += 1;
            nickelsSelectedLabel.Text = "Nickels : " + nickelsSelected.ToString();
        }

        private void dimeImg_Click(object sender, EventArgs e)
        {
            userCents += 10;
            dimesSelected += 1;
            dimesSelectedLabel.Text = "Dimes : " + dimesSelected.ToString();
        }

        private void quarterImg_Click(object sender, EventArgs e)
        {
            userCents += 25;
            quartersSelected += 1;
            quartersSelectedLabel.Text = "Quarters : " + quartersSelected.ToString();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {

            if(userCents == requiredAmount)
            {
                MessageBox.Show("Sweet. You Win!");
            }
            else if(userCents > requiredAmount)
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
