using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;      // <-- important
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sConboyTest3_
{
    public partial class Members : UserControl
    {
        public Members()
        {
            InitializeComponent();

            // optional: monospace so columns line up
            membersListbox.Font = new Font("Consolas", 9);
        }

        // load all members from members.txt into membersListbox
        public void LoadMembersFromFile()
        {
            membersListbox.Items.Clear();

            string filePath = Path.Combine(Application.StartupPath, "members.txt");

            if (!File.Exists(filePath))
            {
                return;
            }

            foreach (var line in File.ReadAllLines(filePath))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                // MemberID#FirstName#LastName#Phone#Email#Active
                string[] parts = line.Split('#');
                if (parts.Length < 6)
                    continue;

                string memberId = parts[0];
                string first = parts[1];
                string last = parts[2];
                string phone = parts[3];
                string email = parts[4];
                string status = parts[5];

                // clean UI: no ID shown, just name + details
                string display =
                    (first + " " + last).PadRight(24) + " " +
                    phone.PadRight(15) + " " +
                    email.PadRight(25) + " " +
                    status;

                membersListbox.Items.Add(display);


            }
        }

        // Add Member button on this control
            private void addMemberButton_Click(object sender, EventArgs e)
            {
                Form1 parent = this.FindForm() as Form1;
                if (parent != null)
                {
                    parent.ShowAddMemberControl();
                }
            }

        // Delete Member button
        private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            if (membersListbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a member to delete.");
                return;
            }

            int indexToRemove = membersListbox.SelectedIndex;

            string filePath = Path.Combine(Application.StartupPath, "members.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No members file found.");
                return;
            }

            var allLines = File.ReadAllLines(filePath).ToList();

            if (indexToRemove < 0 || indexToRemove >= allLines.Count)
            {
                MessageBox.Show("Could not remove that member.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this member?",
                                         "Confirm Delete",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            allLines.RemoveAt(indexToRemove);

            File.WriteAllLines(filePath, allLines);

            LoadMembersFromFile();
        }

        // Sort by name button (LastName then FirstName)
        private void nameSortButton_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "members.txt");

            if (!File.Exists(filePath))
                return;

            var sortedLines = File.ReadAllLines(filePath)
                                  .Where(line => !string.IsNullOrWhiteSpace(line))
                                  .OrderBy(line =>
                                  {
                                      var parts = line.Split('#');
                                      string last = parts.Length > 2 ? parts[2] : "";
                                      string first = parts.Length > 1 ? parts[1] : "";
                                      return last + "#" + first;   // sort primarily by last, then first
                                  })
                                  .ToList();

            File.WriteAllLines(filePath, sortedLines);

            LoadMembersFromFile();
        }
    }
}
