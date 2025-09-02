//  Shawn Conboy
//  CPT 185 A01H
//  LAB 1

// C            clears screen
// Enter        calculates grades
// ESC          closes application

namespace sConboyLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateScoresButton_Click(object sender, EventArgs e)
        {
            // declare variables
            int totalExamScores = 0;
            int totalLabScores = 0;
            int totalQuizScores = 0;
            double examAverage = 0;
            double labAverage = 0;
            double quizAverage = 0;
            double weightedExam = 0;
            double weightedLab = 0;
            double weightedQuiz = 0;
            double finalAverage = 0;
            char letterGrade = ' ';

            totalExamScores = int.Parse(exam1Textbox.Text) + int.Parse(exam2Textbox.Text) + int.Parse(exam3Textbox.Text) + int.Parse(exam4Textbox.Text);
            examTotalResultLabel.Text = totalExamScores.ToString();

            totalLabScores = int.Parse(lab1Textbox.Text) + int.Parse(lab2Textbox.Text) + int.Parse(lab3Textbox.Text) + int.Parse(lab4Textbox.Text) + int.Parse(lab5Textbox.Text);
            labTotalResultLabel.Text = totalLabScores.ToString();

            totalQuizScores = int.Parse(quiz1Textbox.Text) + int.Parse(quiz2Textbox.Text) + int.Parse(quiz3Textbox.Text) + int.Parse(quiz4Textbox.Text) + int.Parse(quiz5Textbox.Text);
            quizTotalResultLabel.Text = totalQuizScores.ToString();

            examAverage = (double)totalExamScores / 4;
            labAverage = (double)totalLabScores / 5;
            quizAverage = (double)totalQuizScores / 5;

            weightedExam = examAverage * 0.45;
            weightedLab = labAverage * 0.35;
            weightedQuiz = quizAverage * 0.2;

            finalAverage = weightedExam + weightedLab + weightedQuiz;

            if (finalAverage >= 90)
            {
                letterGrade = 'A';
            }
            else if (finalAverage >= 80)
            {
                letterGrade = 'B';
            }
            else if (finalAverage >= 70)
            {
                letterGrade = 'C';
            }
            else if (finalAverage >= 60)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            if (letterGrade == 'A' || letterGrade == 'B' || letterGrade == 'C')
            {
                finalLetterGradeResult.Text = letterGrade.ToString();
                finalLetterGradeResult.ForeColor = Color.Green;
            }
            else
            {
                finalLetterGradeResult.Text = letterGrade.ToString();
                finalLetterGradeResult.ForeColor = Color.Red;
            }
        }

        private void clearScoresButton_Click(object sender, EventArgs e)
        {
            exam1Textbox.Text = "";
            exam2Textbox.Text = "";
            exam3Textbox.Text = "";
            exam4Textbox.Text = "";

            lab1Textbox.Text = "";
            lab2Textbox.Text = "";
            lab3Textbox.Text = "";
            lab4Textbox.Text = "";
            lab5Textbox.Text = "";

            quiz1Textbox.Text = "";
            quiz2Textbox.Text = "";
            quiz3Textbox.Text = "";
            quiz4Textbox.Text = "";
            quiz5Textbox.Text = "";

            examTotalResultLabel.Text = "";
            labTotalResultLabel.Text = "";
            quizTotalResultLabel.Text = "";
            finalLetterGradeResult.Text = "";

            exam1Textbox.Focus();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
