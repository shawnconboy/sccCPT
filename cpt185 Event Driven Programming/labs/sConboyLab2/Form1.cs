//      Shawn Conboy
//      CPT 185 A01H
//      Lab 2 Card Identifier


namespace sConboyLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cardNameLabel.Text = "King Of Diamonds";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cardNameLabel.Text = "Two Of Spades";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cardNameLabel.Text = "Joker";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cardNameLabel.Text = "Ace Of Spades";

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cardNameLabel.Text = "Jack Of Hearts";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cardNameLabel.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
