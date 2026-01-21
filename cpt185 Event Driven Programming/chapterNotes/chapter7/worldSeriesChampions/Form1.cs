namespace worldSeriesChampions
{
    public partial class Form1 : Form
    {
        // Declare arrays in higher scope
        private string[] teams = new string[29];
        private string[] seriesWinners = new string[108];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int count = 0;
            int winCount = 0;

            // create streamreader objects
            StreamReader inputTeams = File.OpenText("Teams.txt");
            StreamReader inputWins = File.OpenText("WorldSeriesWinners.txt");

            // read data into arrays
            while (count < teams.Length && !inputTeams.EndOfStream)
            {
                teams[count] = inputTeams.ReadLine();
                count++;
            }

            while (winCount < seriesWinners.Length && !inputWins.EndOfStream)
            {
                seriesWinners[winCount] = inputWins.ReadLine();
                winCount++;
            }

            // close the files
            inputTeams.Close();
            inputWins.Close();

            // add teams to listbox
            teamsListbox.Items.AddRange(teams);

            // sets a value in the listbox on load
            teamsListbox.SelectedIndex = 0;
        }

        private void teamsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the index, pass it to get team name in string
            int selectedIndex = teamsListbox.SelectedIndex;
            string selectedTeam = teams[selectedIndex];
            int winCount = 0;

            // go through array after each click
            for (int i = 0; i < seriesWinners.Length; i++)
            {
                if (selectedTeam == seriesWinners[i])
                {
                    winCount++;
                }

                // show data to users
                teamNameLabel.Text = selectedTeam;
                championshipsWonLabel.Text = winCount.ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // grab what’s currently shown
                string team = teamNameLabel.Text;
                string wins = championshipsWonLabel.Text;

                if (string.IsNullOrWhiteSpace(team) || string.IsNullOrWhiteSpace(wins))
                {
                    MessageBox.Show("No team selected to save.");
                    return;
                }

                // write the result to a new file
                using (StreamWriter output = new StreamWriter("TeamWins.txt", false))
                {
                    output.WriteLine("Team Name:\t" + team);
                    output.WriteLine("Championships Won:\t" + wins);
                    output.WriteLine("Date Saved:\t" + DateTime.Now.ToString());
                }

                MessageBox.Show("Result written to TeamWins.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
