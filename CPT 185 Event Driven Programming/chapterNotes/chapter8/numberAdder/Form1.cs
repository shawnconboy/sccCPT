using System.Globalization;
using System.Numerics;

namespace numberAdder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // user enters string of numbers
            string userEntry = userTextbox.Text;
            // separate the numbers
            string[] numbers = userEntry.Split(',');
            int total = 0;

            foreach (string number in numbers)
            {
                total += int.Parse(number);
            }
            // add them together
            // show total

            resultLabel.Text = $"{total}";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userTextbox.Clear();
            userTextbox.Focus();

            resultLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showFormButton_Click(object sender, EventArgs e)
        {
            ErrorForm errorForm = new ErrorForm();
            errorForm.ShowDialog();
            errorForm.label1.Text = "Hello. Bitches";
        }
    }
}
