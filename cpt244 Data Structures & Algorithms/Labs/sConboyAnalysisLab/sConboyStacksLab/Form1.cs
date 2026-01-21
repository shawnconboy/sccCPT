// Shawn Conboy
// CPT 244 A01H
// Stack Lab
using System.Security.Policy;

namespace sConboyStacksLab
{
    public partial class Form1 : Form
    {

        // make a stack        
        private Stack<string> siteHistory = new Stack<string>();                                                    //1

        // declare some variables to be used throughout
        string userURL = "";                                                                                        //1

        public Form1()                                                                                              //1 declares form class
        {
            InitializeComponent();                                                                                  //1
            urlTextbox.TabStop = false;                                                                             //1
            this.Shown += (s, e) => urlTextbox.TabStop = true;   // re-enable after shown                           //1
        }


        private void searchPicturebox_Click(object sender, EventArgs e)                                             //1
        {
            // add site to stack
            userURL = urlTextbox.Text;                                                                              //1
            
            if (userURL == "")                                                                                      //1 returns true or false
            {
                MessageBox.Show("Please enter a site.");                                                            //1
            }
            else                                                                                                    //1
            {
                siteHistory.Push(userURL);                                                                          //1
                urlTextbox.Clear();                                                                                 //1

                // simulate visiting site
                MessageBox.Show($"{siteHistory.Peek()} visited.");                                                  //1
            }
                
        }

        private void historyButton_Click(object sender, EventArgs e)                                                //1 declares a method
        {
            // show history if there is any.
            if (siteHistory.Count == 0)                                                                             //1 returns true or false
            {
                MessageBox.Show("No history stored.");                                                              //1
            }
            else                                                                                                    //1
            {
                // add sites to history listbox
                showHistory();                                                                                      //1

                // ensure that box is visible
                historyListbox.Visible = true;                                                                      //1
            }
        }

        private void backPicturebox_Click(object sender, EventArgs e)                                               //1
        {
            if (siteHistory.Count == 0)                                                                             //1 returns true or false
            {
                MessageBox.Show("No history stored.");                                                              //1
            }
            else                                                                                                    //1
            {
                historyListbox.Visible = true;                                                                      //1
                showHistory();                                                                                      //1
                string lastVisited = siteHistory.Peek();                                                            //1

                int placementForLastVisited = historyListbox.Items.IndexOf(lastVisited);                            //1

                historyListbox.SelectedIndex = placementForLastVisited;                                             //1
                historyListbox.TopIndex = placementForLastVisited;                                                  //1

                urlTextbox.Text = lastVisited;                                                                      //1
            }
                
        }

        private void showHistory()                                                                                  //1 declares method
        {
            historyListbox.Items.Clear();                                                                           //1
            foreach (string site in siteHistory)                                                                    //n for however many number of sites are in siteHistory
            {
                historyListbox.Items.Add(site);                                                                     //1
            }
        }

        private void clearButton_Click(object sender, EventArgs e)                                                  //1
        {
            siteHistory.Clear();                                                                                    //1
            showHistory();                                                                                          //1
            historyListbox.Visible = false;                                                                         //1
            MessageBox.Show("History has been cleared.");                                                           //1
            urlTextbox.Clear();                                                                                     //1
        }
    }
}


// once again. this was a very simple program.
// most statements are exaclty that. pass a reference or a value in one statement.

// there's one for loop. That will run in bigOof (n) for however many sites are in that siteHistory list.

// as far as performance and improvement. I think this is a pretty solid program. It's small. nothing major.