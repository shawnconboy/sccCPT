using System.Security.Policy;

namespace sConboyStacksLab
{
    public partial class Form1 : Form
    {

        // make a stack        
        private Stack<string> siteHistory = new Stack<string>();

        // declare some variables to be used throughout
        string userURL = "";

        public Form1()
        {
            InitializeComponent();
            urlTextbox.TabStop = false;
            this.Shown += (s, e) => urlTextbox.TabStop = true;   // re-enable after shown
        }


        private void searchPicturebox_Click(object sender, EventArgs e)
        {
            // add site to stack
            userURL = urlTextbox.Text;
            siteHistory.Push(userURL);
            urlTextbox.Clear();

            // simulate visiting site
            MessageBox.Show($"{siteHistory.Peek()} visited.");
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            // add sites to history listbox
            showHistory();

            // ensure that box is visible
            historyListbox.Visible = true;
        }

        private void backPicturebox_Click(object sender, EventArgs e)
        {
            historyListbox.Visible = true;
            showHistory();
            string lastVisited = siteHistory.Peek();

            int placementForLastVisited = historyListbox.Items.IndexOf(lastVisited);

            historyListbox.SelectedIndex = placementForLastVisited;
            historyListbox.TopIndex = placementForLastVisited;
        }

        private void showHistory()
        {
            historyListbox.Items.Clear();
            foreach (string site in siteHistory)
            {
                historyListbox.Items.Add(site);
            }
        }
    }
}
