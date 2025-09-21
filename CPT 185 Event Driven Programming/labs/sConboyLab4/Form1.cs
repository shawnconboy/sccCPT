//Shawn Conboy
//CPT 185 A01H
//Lab 4

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
                //cheks if something was left unselected
                if (fromListbox.SelectedIndex != -1 && toListbox.SelectedIndex != -1)
                {
                    if (fromListbox.SelectedItem == "Inches")
                    {
                        if (toListbox.SelectedItem == "Inches")
                        {
                            convertedDistance = userEntry;
                        }
                        else if (toListbox.SelectedItem == "Feet")
                        {
                            convertedDistance = userEntry / 12;
                        }
                        else if (toListbox.SelectedItem == "Yards")
                        {
                            convertedDistance = userEntry / 36;
                        }

                        convertedLabel.Text = convertedDistance.ToString("#,##0.00");
                    }
                    else if (fromListbox.SelectedItem == "Feet")
                    {
                        if (toListbox.SelectedItem == "Inches")
                        {
                            convertedDistance = userEntry * 12;
                        }
                        else if (toListbox.SelectedItem == "Feet")
                        {
                            convertedDistance = userEntry;
                        }
                        else if (toListbox.SelectedItem == "Yards")
                        {
                            convertedDistance = userEntry / 3;
                        }

                        convertedLabel.Text = convertedDistance.ToString("#,##0.00");
                    }
                    else if (fromListbox.SelectedItem == "Yards")
                    {
                        if (toListbox.SelectedItem == "Inches")
                        {
                            convertedDistance = userEntry * 36;
                        }
                        else if (toListbox.SelectedItem == "Feet")
                        {
                            convertedDistance = userEntry * 3;
                        }
                        else if (toListbox.SelectedItem == "Yards")
                        {
                            convertedDistance = userEntry;
                        }

                        convertedLabel.Text = convertedDistance.ToString("#,##0.00");
                    }
                }
                else
                {
                    MessageBox.Show("Please ensure you've selected from each list.");
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fromListbox.SelectedIndex = -1;
            toListbox.SelectedIndex = -1;
            distanceTextbox.Text = "";
            convertedLabel.Text = "";
            distanceTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
