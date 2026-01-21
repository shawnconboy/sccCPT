namespace dictionaryBirthday
{
    public partial class Form1 : Form
    {

        Dictionary<string, string> birthdayDictionary = new Dictionary<string, string>()
            {
                {"James", "10/24/1970" },
                {"Ricky", "03/5/1994" },
                {"Carol", "12/25/1992" },
                {"Jim", "02/14/2021" }
            };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var element in birthdayDictionary)
            {
                nameListBox.Items.Add(element.Key);
            }
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = nameListBox.SelectedItem.ToString();

            string birthday = birthdayDictionary[name];

            birthdayLabel.Text = birthday;
        }
    }
}
