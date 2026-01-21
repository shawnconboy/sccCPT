namespace tuitionIncrease
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            double startingTuition = 6000;
            double rate = 0.02;
            double increase = 0;
            double currentTuition = 0;


            currentTuition = startingTuition;

            for (int i = 0; i < 5; i++)
            {
                increase = currentTuition * rate;
                currentTuition = currentTuition + increase;

                resultsListbox.Items.Add("Year " + (i + 1) + " tuition costs : " + currentTuition.ToString("F2"));
            }
        }
    }
}
