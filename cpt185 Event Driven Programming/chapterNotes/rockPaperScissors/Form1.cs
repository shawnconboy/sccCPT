namespace rockPaperScissors
{
    public partial class Form1 : Form
    {
        int computerSelection = 0;
        int playerSelection = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // method to create and get a random number
            computerSelection = computerChoice();
        }

        private int computerChoice()
        {
            Random rand = new Random();
            int computer = rand.Next(0, 3);
            return computer;
        }

        private void rockPicture_Click(object sender, EventArgs e)
        {
            playerSelection = 0;
            decideWinner();

        }

        private void paperPicture_Click(object sender, EventArgs e)
        {
            playerSelection = 2;
            decideWinner();
        }

        private void scissorsPicture_Click(object sender, EventArgs e)
        {
            playerSelection = 3;
            decideWinner();
        }

        private void decideWinner()
        {
            if (playerSelection == computerSelection)
            {
                MessageBox.Show("Tie");
            }
            else if (playerSelection == 1 && computerSelection == 1 ||    playerSelection == 1 && computerSelection == 2 || playerSelection == 2 && computerSelection == 0)
            {
                MessageBox.Show("Computer Wins");
            }
            else
            {
                MessageBox.Show("Player Wins");
            }
        }
    }
}
