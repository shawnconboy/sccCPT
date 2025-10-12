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


                // _______________________________________________________
                // pull data from file

                StreamReader inputFile;

                inputFile = File.OpenText("Sales.txt");

                while (index < sales.Length && !inputFile.EndOfStream)
                {
                    sales[index] = double.Parse(inputFile.ReadLine());
                    index++;
                }

                inputFile.Close();

                // _______________________________________________________


                // for each element in the "sales" array, do code in block
                foreach (double value in sales)
                {
                    salesListbox.Items.Add(value);
                }


                // add all elements to find total of all sales
                double totalSales = 0;

                for (int i = 0; i < sales.Length; i++)
                {
                    totalSales += sales[i];
                }

                salesTotalLabel.Text = totalSales.ToString("c");

                // create average of all values in array

                double average = totalSales / salesListbox.Items.Count;

                averageLabel.Text = average.ToString("c");

                // find the largest value

                double largest = sales[0];

                for (int i = 0; i < sales.Length; i++)
                {
                    if (sales[i] > largest)
                    {
                        largest = sales[i];
                    }
                }

                largestLabel.Text = largest.ToString("c");

                // find the smallest value

                double smallest = sales[0];

                for (int i = 0; i < sales.Length; i++)
                {
                    if (sales[i] < smallest)
                    {
                        smallest = sales[i];
                    }
                }
                
                smallestLabel.Text = smallest.ToString("c");
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
