namespace totalSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // read from sales.txt into new array

            try
            {
                const int SIZE = 7;
                double[] sales = new double[SIZE];

                int index = 0;

                StreamReader inputFile;

                inputFile = File.OpenText("Sales.txt");

                while (index < sales.Length && !inputFile.EndOfStream)
                {
                    sales[index] = double.Parse(inputFile.ReadLine());
                    index++;
                }

                inputFile.Close();

                foreach (int value in sales)
                {
                    salesListbox.Items.Add(value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            // calculate total for all elements in array

            // display total to user
        }
    }
}
