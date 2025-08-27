namespace SConboyLab0Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateGradesButton_Click(object sender, EventArgs e)
        {
            int examGradesTotal = 0;
            int labGradesTotal = 0;
            int quizGradesTotal = 0;

            examGradesTotal = int.Parse(exam1Textbox.Text) + int.Parse(exam2Textbox.Text) + int.Parse(exam3Textbox.Text) + int.Parse(exam4Textbox.Text) + int.Parse(exam5Textbox.Text);

            double examGradesAverage = (double)examGradesTotal / 5;
            examAverageResultsLabel.Text = examGradesAverage.ToString();

            labGradesTotal = int.Parse(lab1Textbox.Text) + int.Parse(lab2Textbox.Text) + int.Parse(lab3Textbox.Text) + int.Parse(lab4Textbox.Text) + int.Parse(lab5Textbox.Text);

            double labGradesAverage = (double)labGradesTotal / 5;
            labAverageResultsLabel.Text = labGradesAverage.ToString();

            quizGradesTotal = int.Parse(quiz1Textbox.Text) + int.Parse(quiz2Textbox.Text) + int.Parse(quiz3Textbox.Text) + int.Parse(quiz4Textbox.Text) + int.Parse(quiz5Textbox.Text);

            double quizGradesAverage = (double)quizGradesTotal / 5;
            quizAverageResultsLabel.Text = quizGradesAverage.ToString();

            double weightedExam = examGradesAverage * 0.45;
            double weightedLab = labGradesAverage * 0.35;
            double weightedQuiz = quizGradesAverage * 0.2;

            double finalAverage = weightedExam + weightedLab + weightedQuiz;

            overallGradeResultsLabel.Text = finalAverage.ToString();

        }
    }
}
