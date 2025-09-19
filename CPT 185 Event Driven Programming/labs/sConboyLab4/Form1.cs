namespace sConboyLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //variables
            double userEntry = 0;
            double convertedDistance = 0;

            //parse data

            if (!(double.TryParse(distanceTextbox.Text, out userEntry)))
            {
                MessageBox.Show("Please enter a valid numeric distance.");
            }
            else
            {

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
