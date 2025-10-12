namespace writeArrayToFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] numbers = [10, 20, 30, 40, 50];

            StreamWriter outputFile;

            outputFile = File.CreateText("Values.txt");

            for (int i = 0; i < numbers.Length; i++)
            {
                outputFile.WriteLine(numbers[i]);
            }

            outputFile.Close();

            MessageBox.Show("File was written.");
        }
    }
}
