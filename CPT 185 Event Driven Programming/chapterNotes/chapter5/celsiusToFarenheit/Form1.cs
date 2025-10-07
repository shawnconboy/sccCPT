using System.IO.IsolatedStorage;

namespace celsiusToFarenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //what does the program need to do?
            //create a list from 0 to 20 converted
            //from celsius to farenheit

            double numberF = 0;
            double numberC = 0;

            for (double i = 0; i <= 20; i++)
            {
                numberF = (9 / 5) * i + 32;

                convertedListbox.Items.Add(i + " degrees celsius is " + numberF + " degrees farenheit.");
            }
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            //if list is showing farenheit, swap the values.......

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
