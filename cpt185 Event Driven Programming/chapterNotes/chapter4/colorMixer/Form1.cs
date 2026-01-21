namespace colorMixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            string firstColor = "";
            string secondColor = "";

            // Get first color
            if (redOne.Checked)
            {
                firstColor = "Red";
            }
            else if (blueOne.Checked)
            {
                firstColor = "Blue";
            }
            else if (yellowOne.Checked)
            {
                firstColor = "Yellow";
            }

            // Get second color
            if (redTwo.Checked)
            {
                secondColor = "Red";
            }
            else if (blueTwo.Checked)
            {
                secondColor = "Blue";
            }
            else if (yellowTwo.Checked)
            {
                secondColor = "Yellow";
            }

            // Mix them
            this.BackColor = MixColors(firstColor, secondColor);
        }

        private Color MixColors(string c1, string c2)
        {
            if (c1 == c2) // same color
            {
                return Color.FromName(c1);
            }

            if ((c1 == "Red" && c2 == "Blue") || (c1 == "Blue" && c2 == "Red"))
            {
                return Color.Purple;
            }

            if ((c1 == "Red" && c2 == "Yellow") || (c1 == "Yellow" && c2 == "Red"))
            {
                return Color.Orange;
            }

            if ((c1 == "Blue" && c2 == "Yellow") || (c1 == "Yellow" && c2 == "Blue"))
            {
                return Color.Green;
            }

            return Color.White; // fallback
        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
