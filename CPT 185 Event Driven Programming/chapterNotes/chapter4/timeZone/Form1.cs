namespace timeZone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string city = "";

            //check if something's selected
            if (cityListbox.SelectedIndex != -1)
            {
                city = cityListbox.SelectedItem.ToString();

                switch (city)
                {
                    case "Honolulu":
                        resultLabel.Text = "Hawaii-Aleutian";
                        break;
                    case "San Francisco":
                        resultLabel.Text = "Pacfic";
                        break;
                    case "Denver":
                        resultLabel.Text = "Mountain";
                        break;
                    case "Minneapolis":
                        resultLabel.Text = "Central";
                        break;
                    case "New York":
                        resultLabel.Text = "Eastern";
                        break;
                }
            }
            else
            {
                //nothing was selected
                MessageBox.Show("Select a city.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            cityListbox.ClearSelected();
            cityListbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
