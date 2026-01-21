namespace passArrayAsArgument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] people = ["Jill", "Jack", "Jamie", "Rich"];

            showArray(people);
        }
        

        // this method takes a string array and
        // returns it's elements one by one
        private void showArray(string[] strArray)
        {
            foreach (string str in strArray)
            {
                MessageBox.Show(str);
            }
        }
    }
}
