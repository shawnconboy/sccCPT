namespace dateTimePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selected = dateTimePicker.Value;

            resultLabel.Text = selected.ToString("F");
        }

        struct Person
        {
            public string name;
            public DateTime birthdate;
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {
       

            // create a person

            Person person1 = new Person();
            person1.name = "Emily";
            person1.birthdate = new DateTime(1998, 7, 7);

            Person person2 = new Person();
            person2.name = "Brynley";
            person2.birthdate = new DateTime(1993, 10, 10);

            if (person1.birthdate < person2.birthdate)
            {
                MessageBox.Show($"{person1.name} is older than {person2.name}");
            }
            else if (person1.birthdate > person2.birthdate)
            {
                MessageBox.Show($"{person1.name} is younger than {person2.name}");
            }
            else
            {
                MessageBox.Show("They're the same age.");
            }
        }

        
    }
}
