namespace latinTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            translatedLabel.Text = "Left";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            translatedLabel.Text = "Medium";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            translatedLabel.Text = "Right";

        }
    }
}
