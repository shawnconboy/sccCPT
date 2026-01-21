//  Shawn Conboy
//  CPT 185 A01H
//  Lab 3 Stadium Seating

namespace sConboyLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateRevenueButton_Click(object sender, EventArgs e)
        {

            // ticket prices

            int classATicketPrice = 15;
            int classBTicketPrice = 12;
            int classCTicketPrice = 9;

            int classATicketsSold = 0;
            int classBTicketsSold = 0;
            int classCTicketsSold = 0;

            int classARevenue = 0;
            int classBRevenue = 0;
            int classCRevenue = 0;

            int totalRevenue = 0;


            try
            {
                classATicketsSold = int.Parse(classATicketsTextbox.Text);
                classBTicketsSold = int.Parse(classBTicketsTextbox.Text);
                classCTicketsSold = int.Parse(classCTicketsTextbox.Text);
            }
            catch
            {
                MessageBox.Show("You dumbass. Type in letters only.");
                classATicketsTextbox.Clear();
                classBTicketsTextbox.Clear();
                classCTicketsTextbox.Clear();

                classARevenueTotalLabel.Text = "$0.00";
                classBRevenueTotalLabel.Text = "$0.00";
                classCRevenueTotalLabel.Text = "$0.00";
                totalRevenueTotalLabel.Text = "$0.00";

                classATicketsTextbox.Focus();
            }


            classARevenue = classATicketsSold * classATicketPrice;
            classBRevenue = classBTicketsSold * classBTicketPrice;
            classCRevenue = classCTicketsSold * classCTicketPrice;


            classARevenueTotalLabel.Text = classARevenue.ToString("C");
            classBRevenueTotalLabel.Text = classBRevenue.ToString("C");
            classCRevenueTotalLabel.Text = classCRevenue.ToString("C");

            totalRevenue = classARevenue + classBRevenue + classCRevenue;

            totalRevenueTotalLabel.Text = totalRevenue.ToString("C"); 
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            classATicketsTextbox.Clear();
            classBTicketsTextbox.Clear();
            classCTicketsTextbox.Clear();

            classARevenueTotalLabel.Text = "$0.00";
            classBRevenueTotalLabel.Text = "$0.00";
            classCRevenueTotalLabel.Text = "$0.00";
            totalRevenueTotalLabel.Text = "$0.00";

            classATicketsTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
