using System.IO;
using System.Linq.Expressions;
namespace phoneBook
{
    // create an entry struct
    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    public partial class Form1 : Form
    {
        // field to hold a list of PhoneBookEntry objects
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();
        public Form1()
        {
            InitializeComponent();
        }

        // the ReadFile method reads the contents of the
        // PhoneList.txt file and stores it as PhoneBookEntry
        // objects in the phoneList

        private void ReadFile()
        {
            try
            {
                StreamReader inputFile;         // reads the file
                string line;                    // variable "line" will hold a line from the inputFile

                // create an instance of the PhoneBookEntry structure
                PhoneBookEntry entry = new PhoneBookEntry();

                // create a delimeter
                char[] delimeter = { ',' };

                // open the file
                inputFile = File.OpenText("PhoneList.txt");

                // read from the file
                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();

                    // tokenize the line
                    string[] tokens = line.Split(delimeter);

                    // store tokens in the entry object
                    entry.name = tokens[0];
                    entry.phone = tokens[1];

                    // add entry object to list
                    phoneList.Add(entry);
                }
            }
            catch (Exception ex)
            {
                // display error message
                MessageBox.Show(ex.Message);
            }
        }

        // display list of names in listbox
        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListbox.Items.Add(entry.name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();

            DisplayNames();
        }

        private void nameListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListbox.SelectedIndex;

            phoneLabel.Text = phoneList[index].phone;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
