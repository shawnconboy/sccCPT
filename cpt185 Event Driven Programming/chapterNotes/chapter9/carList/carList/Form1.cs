namespace carList
{
    struct Automobile
    {
        public string make;
        public int year;
        public double mileage;
    }
    public partial class Form1 : Form
    {
        private List<Automobile> carList = new List<Automobile>();
        public Form1()
        {
            InitializeComponent();
        }

        private void GetData(ref Automobile auto)
        {
            try
            {
                // get user data from textboxes
                auto.make = makeTextbox.Text;
                auto.year = int.Parse(yearTextbox.Text);
                auto.mileage = double.Parse(mileageTextbox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Automobile car = new Automobile();

            GetData(ref car);

            carList.Add(car);

            // clear the fields
            makeTextbox.Clear();
            yearTextbox.Clear();
            mileageTextbox.Clear();

            makeTextbox.Focus();

            PrintToList();

            
        }

        private void PrintToList()
        {

            carsListbox.Items.Clear();
            foreach (Automobile acar in carList)
            {
                string output = "";
                output = $"{acar.year} {acar.make} - Mileage : {acar.mileage}";
                carsListbox.Items.Add(output);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
