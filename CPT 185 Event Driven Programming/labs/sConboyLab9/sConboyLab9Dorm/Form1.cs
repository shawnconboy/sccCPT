//    Shawn Conboy
//    CPT 168 A01H
//    Lab 9 Dorm

namespace sConboyLab9Dorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allenButton.Checked = true;
        }

        private void displayTotalButton_Click(object sender, EventArgs e)
        {
            double dormTotal = 0;
            double mealTotal = 0;
            double finalTotal = 0;

            if (allenButton.Checked)
            {
                dormTotal += 1500;
            }
            else if (pikeButton.Checked)
            {
                dormTotal += 1600;
            }
            else if (farthingButton.Checked)
            {
                dormTotal += 1800;
            }
            else if (suitesButton.Checked)
            {
                dormTotal += 2500;
            }
            else
            {
                MessageBox.Show("Please make a selection.");
            }

            if (mealOption1Buton.Checked)
            {
                mealTotal += 600;
            }
            else if (mealOption2Button.Checked)
            {
                mealTotal += 1200;
            }
            else if (unlimitedMealOption.Checked)
            {
                mealTotal += 1700;
            }
            else
            {
                MessageBox.Show("Pleas make a selection.");
            }

            finalTotal = mealTotal + dormTotal;

            Form2 totalsForm = new Form2();
            totalsForm.ShowTotals(dormTotal, mealTotal);
            totalsForm.ShowDialog();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    foreach (Control innerControl in groupBox.Controls)
                    {
                        if (innerControl is RadioButton radioButton)
                        {
                            radioButton.Checked = false;
                        }
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
