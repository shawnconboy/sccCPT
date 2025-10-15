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

            char[] correctAnswer = ['B', 'D', 'A', 'A', 'C',
                                    'A', 'B', 'A', 'C', 'D',
                                    'B', 'C', 'D', 'A', 'D',
                                    'C', 'C', 'B', 'D', 'A'];
            char[] userAnswer = new char[size];

            // push correctAnswer elements into listbox
            for (int i = 0; i < correctAnswer.Length; i++)
            {
                correctAnswerListbox.Items.Add((i+1) + ". " + correctAnswer[i]);
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

        }
    }
}
