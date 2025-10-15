namespace sConboyLab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // declaring and filling arrays
            int size = 20;
            int count = 0;
            int correct = 0;
            int incorrect = 0;

            char[] correctAnswer = ['B', 'D', 'A', 'A', 'C',
                                    'A', 'B', 'A', 'C', 'D',
                                    'B', 'C', 'D', 'A', 'D',
                                    'C', 'C', 'B', 'D', 'A'];
            char[] userAnswer = new char[size];
            char[] incorrectAnswer = new char[size];

            // push correctAnswer elements into listbox
            for (int i = 0; i < correctAnswer.Length; i++)
            {
                correctAnswerListbox.Items.Add((i + 1) + ". " + correctAnswer[i]);
            }

            // create streamreader object to import files
            StreamReader inputFile;

            inputFile = File.OpenText("StudentAnswers.txt");

            // read the file and parse the data into the array
            while (count < userAnswer.Length && !inputFile.EndOfStream)
            {
                userAnswer[count] = char.Parse(inputFile.ReadLine());
                count++;
            }

            // add the newly imported answers to their own listbox
            for (int i = 0; i < userAnswer.Length; i++)
            {
                userAnswerListbox.Items.Add((i + 1) + ". " + userAnswer[i]);
            }

            // compare right from wrong
            for (int i = 0; i < userAnswer.Length; i++)
            {
                if (correctAnswer[i] == userAnswer[i])
                {
                    correct++;
                }
                else
                {
                    // add wrong to separate listbox
                    incorrect++;
                    incorrectAnswerListbox.Items.Add((i + 1) + ".");
                }
            }

            correctLabel.Text = correct.ToString();
            wrongLabel.Text = incorrect.ToString();

            if (correct >= 15)
            {
                MessageBox.Show("Congrats. You passed!");
            }
            else
            {
                MessageBox.Show("Try harder bud.");
            }

        }
    }
}
