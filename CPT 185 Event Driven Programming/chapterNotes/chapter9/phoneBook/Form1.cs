using System.IO;
namespace phoneBook
{

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
                // reads the file
                StreamReader inputFile;
                // variable "line" will hold a line from the inputFile
                string line;

                // create an instance of the PhoneBookEntry structure
                PhoneBookEntry entry = new PhoneBookEntry();
            }
        }
    }
}
