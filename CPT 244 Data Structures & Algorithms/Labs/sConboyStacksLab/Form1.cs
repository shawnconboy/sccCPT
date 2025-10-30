// Shawn Conboy
// CPT 244 A01H
// Stack Lab
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
            
            if (userURL == "")
            {
                MessageBox.Show("Please enter a site.");
            }
            else
            {
                siteHistory.Push(userURL);
                urlTextbox.Clear();

                // simulate visiting site
                MessageBox.Show($"{siteHistory.Peek()} visited.");
            }
                
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            // show history if there is any.
            if (siteHistory.Count == 0)
            {
                MessageBox.Show("No history stored.");
            }
            else
            {
                // add sites to history listbox
                showHistory();

                // ensure that box is visible
                historyListbox.Visible = true;
            }
        }

        private void backPicturebox_Click(object sender, EventArgs e)
        {
            if (siteHistory.Count == 0)
            {
                MessageBox.Show("No history stored.");
            }
            else
            {
                historyListbox.Visible = true;
                showHistory();
                string lastVisited = siteHistory.Peek();

                int placementForLastVisited = historyListbox.Items.IndexOf(lastVisited);

                historyListbox.SelectedIndex = placementForLastVisited;
                historyListbox.TopIndex = placementForLastVisited;

                urlTextbox.Text = lastVisited;
            }
                
        }

        private void showHistory()
        {
            historyListbox.Items.Clear();
            foreach (string site in siteHistory)
            {
                historyListbox.Items.Add(site);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            siteHistory.Clear();
            showHistory();
            historyListbox.Visible = false;
            MessageBox.Show("History has been cleared.");
            urlTextbox.Clear();
        }
    }
}
