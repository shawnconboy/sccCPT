namespace distanceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // variables
            int speed = 0;
            int hoursTraveled = 0;
            int distance = 0;

            // parse data

            if (int.TryParse(speedTextbox.Text, out speed))
            {
                if (int.TryParse(hoursTextbox.Text, out hoursTraveled))
                {
                    for (int i = 1; i <= hoursTraveled; i++)
                    {
                        distanceListbox.Items.Add("After " + i + " hour(s) traveled, the distance is " + (speed * i) + " miles.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid time traveled.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid speed.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            speedTextbox.Clear();
            hoursTextbox.Clear();
            distanceListbox.Items.Clear();
            speedTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
