namespace randomNumberFileReaderWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            // bring control to front
            read1.BringToFront();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            // bring control to front
            write1.BringToFront();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close the form shawty
            this.Close();
        }
    }
}
