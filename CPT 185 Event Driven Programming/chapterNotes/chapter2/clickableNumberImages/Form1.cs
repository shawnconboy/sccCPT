namespace clickableNumberImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            numberLabel.Text = "One";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            numberLabel.Text = "Two";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            numberLabel.Text = "Three";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            numberLabel.Text = "Four";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            numberLabel.Text = "Five";
        }
    }
}
