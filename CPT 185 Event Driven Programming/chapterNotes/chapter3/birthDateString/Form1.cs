namespace birthDateString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string dayOfWeek, monthName, numericalDay, year;

            dayOfWeek = dayOfWeekTextbox.Text;

            resultLabel.Text = dayOfWeek;
        }
    }
}
