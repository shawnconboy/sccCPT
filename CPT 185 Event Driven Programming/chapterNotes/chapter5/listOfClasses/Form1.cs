namespace listOfClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                StreamWriter outputFile;
                outputFile = File.AppendText("class.txt");       
                outputFile.WriteLine(classNameTextbox.Text);
                outputFile.Close();

                MessageBox.Show("Class was added.");
                classNameTextbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            classNameTextbox.Clear();
            classNameTextbox.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
