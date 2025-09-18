namespace loanQualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {

            try
            {
                //variables
                double salary = 0;
                int yearsWorked = 0;

                //parse data

                salary = double.Parse(salaryTextbox.Text);
                yearsWorked = int.Parse(yearsWorkedTextbox.Text);

                if (salary >= 40000 && yearsWorked >= 2)
                {
                    resultLabel.Text = "You qualify for the loan.";
                }
                else
                {
                    resultLabel.Text = "You did not qualify for the loan. Sorry.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            salaryTextbox.Clear();
            yearsWorkedTextbox.Clear();
            resultLabel.Text = "";
            salaryTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
