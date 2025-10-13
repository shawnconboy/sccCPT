//Shawn Conboy
//CPT 244 A01H
//DS Problem 1

namespace sConboyArraysLab
{
    public partial class Form1 : Form
    {
        // declare variables
        private string[] names = new string[99];
        private int[] grades = new int[99];
        private int count = 0;
        private double average = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // pre fill form
            string[] initialNames = { "David", "Lamelo", "Cordelius", "Arielle", "Brianna", "Jimmy", "Warren" };
            int[] initialGrades = { 88, 92, 27, 78, 90, 100, 76 };

            for (int i = 0; i < initialNames.Length; i++)
            {
                names[i] = initialNames[i];
                grades[i] = initialGrades[i];
                studentListbox.Items.Add(names[i] + "\t\t" + grades[i]);
                count++;
            }

            // update averages and lists
            updateAverages();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            // grab new student info from textboxes
            string newName = nameTextbox.Text;
            int newGrade;

            if (int.TryParse(gradeTextbox.Text, out newGrade))
            {
                // validate the grade thingymabob so that it's
                // accurate. no extra credit
                if (newGrade > 100 || newGrade < 0)
                {
                    MessageBox.Show("Grade is not valid. Enter a number from 0 - 100.");
                    gradeTextbox.Clear();
                    gradeTextbox.Focus();
                    return;
                }
                else
                {
                    names[count] = newName;
                    grades[count] = newGrade;
                    count++;

                    // add to listbox
                    studentListbox.Items.Add(newName + "\t\t" + newGrade);

                    // update averages and lists
                    updateAverages();

                    // clear fields
                    nameTextbox.Clear();
                    gradeTextbox.Clear();
                    nameTextbox.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Please enter a valid grade.");
            }
        }

        // self explanatory. get's average of grades array
        private double getAverage()
        {
            int total = 0;

            for (int i = 0; i < count; i++)
            {
                total += grades[i];
            }

            if (count > 0)
            {
                average = (double)total / count;
            }
            else
            {
                average = 0;
            }

            return average;
        }

        // self explanatory as well. adds students who are above
        // the average to the listbox, cooresponding.
        private void getAboveAverage()
        {
            for (int i = 0; i < count; i++)
            {
                if (grades[i] > average)
                {
                    aboveAverageListbox.Items.Add(names[i] + "\t\t" + grades[i]);
                }
            }
        }

        private void getBelowAverage()
        {
            for (int i = 0; i < count; i++)
            {
                if (grades[i] < average)
                {
                    belowAverageListbox.Items.Add(names[i] + "\t\t" + grades[i]);
                }
            }
        }

        private void updateAverages()
        {
            average = getAverage();
            averageLabel.Text = average.ToString("F2");

            aboveAverageListbox.Items.Clear();
            belowAverageListbox.Items.Clear();

            getAboveAverage();
            getBelowAverage();
        }
    }
}
