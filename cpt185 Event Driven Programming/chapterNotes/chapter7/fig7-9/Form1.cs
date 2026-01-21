namespace fig7_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getNamesButton_Click(object sender, EventArgs e)
        {
            const int size = 3;
            string[] names = new string[size];

            names[0] = textBox1.Text;
            names[1] = textBox2.Text;
            names[2] = textBox3.Text;

            MessageBox.Show(names[0]);
            MessageBox.Show(names[1]);
            MessageBox.Show(names[2]);


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
