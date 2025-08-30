// Shawn Conboy
// CPT 185 A01H
// In Class Lab

namespace SConboyLab6Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // nothing
        }

        private void calculateBonusButton_Click(object sender, EventArgs e)
        {
            // this prints to the user.

            int yearsWorked = 0;
            double grossPay = 0;
            double bonus = 0;

            yearsWorked = int.Parse(yearsWorkedTextbox.Text);
            grossPay = double.Parse(grossPayTextbox.Text);

            if (yearsWorked >= 6)
            {
                bonus = grossPay * 0.02;
            }
            else if (yearsWorked > 0)
            {
                bonus = grossPay * 0.01;
            }
            else
            {
                // no bonus
                // error message
                MessageBox.Show("Error. Years worked can not be negative.");
                grossPayTextbox.Clear();
                yearsWorkedTextbox.Text = "";
            }

            // Output to the bonus
            bonusResultLabel.Text = $"Bonus : ${bonus}";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            grossPayTextbox.Clear();
            yearsWorkedTextbox.Clear();
            bonusResultLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
