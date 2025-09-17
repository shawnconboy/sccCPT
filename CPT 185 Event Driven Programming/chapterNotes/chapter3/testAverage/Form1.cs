namespace testAverage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //variables
                double test1 = 0;
                double test2 = 0;
                double test3 = 0;
                double testTotal = 0;
                double average = 0;

                //parse data
                test1 = double.Parse(test1Textbox.Text);
                test2 = double.Parse(test2Textbox.Text);
                test3 = double.Parse(test3Textbox.Text);

                //calculate
                testTotal = test1 + test2 + test3;
                average = testTotal / 3;

                //return data
                resultLabel.Text = average.ToString();

                if (average > 70)
                {
                    MessageBox.Show("Congratulations! You passed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear fields
            test1Textbox.Clear();
            test2Textbox.Clear();
            test3Textbox.Clear();
            resultLabel.Text = "";

            test1Textbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close application
            this.Close();
        }
    }
}
