// Shawn Conboy
// CPT 185 A01H
// Test 2

namespace sConboy_185_Test_2
{
    public partial class Form1 : Form
    {

        // create year array
        private int[] years = new int[124];
        private double[] salaries = new double[10];

        // method to add years to combo box
        private void showYears()
        {
            int currentYear = 1900;
            for (int i = 0; i <= years.Length; i++)
            {
                yearComboBox.Items.Add(currentYear);
                currentYear++;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        // call method to seed combo box
        private void Form1_Load(object sender, EventArgs e)
        {
            showYears();
            yearComboBox.SelectedIndex = 0;
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            StreamReader inputSalaries;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // open salaries from file

                inputSalaries = File.OpenText(openFile.FileName);

                // read lines into array
                int count = 0;
                while (count < salaries.Length && !inputSalaries.EndOfStream)
                {
                    salaries[count] = double.Parse(inputSalaries.ReadLine());
                    count++;
                }

                // push salaries to textbox

                for (int i = 0; i < salaries.Length; i++)
                {
                    salariesListbox.Items.Add(salaries[i]);
                }

                // show data to user
                totalSalaries();
                totalRecords();
                average();
                largest();
                smallest();
                bonusAmount();
            }
            else
            {
                MessageBox.Show("Canceled");
            }
        }


        // the following methods are self explanatory,
        // minimal comments made below.
        private int totalRecords()
        {
            int totalRecords = 0;

            totalRecords = salaries.Length;

            recordsLabel.Text = "The number of records : " + totalRecords.ToString();

            return totalRecords;
        }

        private double totalSalaries()
        {
            double total = 0;

            for (int i = 0; i < salaries.Length; i++)
            {
                total += salaries[i];
            }
            totalSalariesLabel.Text = "The total salaries : " + total.ToString("C");

            return total;
        }

        private double average()
        {
            double total = totalSalaries();
            double average = 0;
            int arraySize = salaries.Length;

            average = total / arraySize;
            averageLabel.Text = "The average : " + average.ToString("C");

            return average;
        }

        private double largest()
        {
            double largest = salaries[0];
            for (int i = 0; i < salaries.Length; i++)
            {
                if (largest < salaries[i])
                {
                    largest = salaries[i];
                }
            }
            largestSalaryLabel.Text = "The largest salary : " + largest.ToString("c");

            return largest;
        }

        private double smallest()
        {
            double smallest = salaries[0];

            for (int i = 0; i < salaries.Length; i++)
            {
                if (smallest > salaries[i])
                {
                    smallest = salaries[i];
                }
            }

            smallestSalaryLabel.Text = "The smallest salary : " + smallest.ToString("c");

            return smallest;
        }

        private double bonusPercent()
        {
            string year = "";
            int yearConverted = 0;
            double bonusPercent = 0;

            // see what year is selected
            year = yearComboBox.SelectedItem.ToString();
            yearConverted = int.Parse(year);

            if (yearConverted < 2000)
            {
                bonusPercent = 0.1;
            }
            else if (yearConverted < 2009)
            {
                bonusPercent = 0.2;
            }
            else
            {
                bonusPercent = 0;
            }

            return bonusPercent;
        }

        private double bonusAmount()
        {
            double bonusAmount = 0;
            double bonusPercentTotal = bonusPercent();
            double averageTotal = average();

            bonusAmount = averageTotal * bonusPercentTotal;
            bonusLabel.Text = "The bonus amount is : " + bonusAmount.ToString("C");

            return bonusAmount;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            salariesListbox.Items.Clear();
            yearComboBox.SelectedItem = null;

            totalSalariesLabel.Text = "The total salaries : $0.00";
            recordsLabel.Text = "The number of records : 0";
            averageLabel.Text = "The average : $0.00";
            largestSalaryLabel.Text = "The largest salary : $0.00";
            smallestSalaryLabel.Text = "The smallest salary : $0.00";
            bonusLabel.Text = "The bonus amount is : $0.00";

            yearComboBox.SelectedIndex = 0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
