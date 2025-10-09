namespace tuitionCalculator
{
    public partial class Form1 : Form
    {
        // variables
        private int total = 0;
        private int skipped = 0;
        private int correct = 0;
        private int wrong = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generateNumbers();
        }

        private void generateNumbers()
        {
            Random rand = new Random();

            int num1 = rand.Next(1, 10);
            int num2 = rand.Next(1, 30);

            problemLabel.Text = num1.ToString() + "  + " + num2.ToString() + "  = ";

            total = num1 + num2;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int userAnswer = 0;
            int.TryParse(userAnswerTextbox.Text, out userAnswer);

            if (userAnswer != total)
            {
                MessageBox.Show("Sorry. Wrong Answer.");
                userAnswerTextbox.Clear();
                userAnswerTextbox.Focus();
                wrong++;
            }
            else
            {
                MessageBox.Show("Correct!");
                userAnswerTextbox.Clear();
                userAnswerTextbox.Focus();
                generateNumbers();
                correct++;
            }
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            generateNumbers();
            skipped++;
            userAnswerTextbox.Clear();
            userAnswerTextbox.Focus();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (correct > skipped)
            {
                MessageBox.Show("Congratulations, you did great!");
            }
            else
            {
                MessageBox.Show("Sorry. You need to practice more.");
            }
            this.Close();
        }
    }
}
