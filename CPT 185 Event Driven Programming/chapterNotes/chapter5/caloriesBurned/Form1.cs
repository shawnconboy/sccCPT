namespace caloriesBurned
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double caloriesPerMinute = 3.9;

            for (int i = 0; i <= 30; i += 5)
            {
                resultsListbox.Items.Add("For " + i + " minutes on the treadmill, you burn " + (caloriesPerMinute * i) + " calories.");
            }
        }
    }
}
