namespace tut7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // create the array
            const int size = 5;
            int[] lotteryNumbers = new int[size];

            // create a random object
            Random rand = new Random();

            // assign the elements in the array a random number
            for (int i = 0; i < lotteryNumbers.Length; i++)
            {
                lotteryNumbers[i] = rand.Next(100);
            }

            // show the results
            label1.Text = lotteryNumbers[0].ToString();
            label2.Text = lotteryNumbers[1].ToString();
            label3.Text = lotteryNumbers[2].ToString();
            label4.Text = lotteryNumbers[3].ToString();
            label5.Text = lotteryNumbers[4].ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
