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

            // display scores in listbox

            // find highest

            // find lowest

            // find average
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
