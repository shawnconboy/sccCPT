namespace fuelEconomyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double milesDriven = 0;
            double gasUsed = 0;
            double mpg = 0;

            milesDriven = double.Parse(milesDrivenTextbox.Text);
            gasUsed = double.Parse(gallonsUsedTextbox.Text);

            mpg = milesDriven / gasUsed;

            carMpgResultLabel.Text = mpg.ToString("n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
