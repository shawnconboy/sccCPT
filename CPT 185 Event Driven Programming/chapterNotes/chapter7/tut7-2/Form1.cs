using System.Reflection;

namespace tut7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            // get scores and put them into array

            StreamReader inputFile;

            inputFile = File.OpenText("TestScores.txt");

            int size = 5;
            double[] testScores = new double[size];
            int count = 0;

            while (count < testScores.Length && !inputFile.EndOfStream)
            {
                testScores[count] = double.Parse(inputFile.ReadLine());
                count++;
            }

            // display scores in listbox

            foreach (double score in testScores)
            {
                testScoresListbox.Items.Add(score);
            }

            // find highest

            double highest = testScores[0];

            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] > highest)
                {
                    highest = testScores[i];
                }
            }

            highScoreLabel.Text = highest.ToString();

            // find lowest

            double lowest = testScores[0];

            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] < lowest)
                {
                    lowest = testScores[i];
                }
            }

            lowScoreLabel.Text = lowest.ToString();

            // find average

            double total = 0;
            double average = 0;

            for (int i = 0; i < testScores.Length; i++)
            {
                total += testScores[i];
            }

            average = total / testScores.Length;

            averageScoreLabel.Text = average.ToString("F2");

            inputFile.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
