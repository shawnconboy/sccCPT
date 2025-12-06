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
    public partial class AddMember : UserControl
    {
        public AddMember()
        {
            InitializeComponent();
        }

        // wire this to addMemberButton's Click event in the designer
        private void addMemberButton_Click(object sender, EventArgs e)
        {
            // basic validation
            if (string.IsNullOrWhiteSpace(firstNameTextbox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextbox.Text) ||
                string.IsNullOrWhiteSpace(phoneTextbox.Text) ||
                string.IsNullOrWhiteSpace(emailTextbox.Text))
            {
                MessageBox.Show("Please fill in First Name, Last Name, Phone, and Email.");
                return;
            }

            string firstName = firstNameTextbox.Text.Trim();
            string lastName = lastNameTextbox.Text.Trim();
            string phone = phoneTextbox.Text.Trim();
            string email = emailTextbox.Text.Trim();

            string filePath = Path.Combine(Application.StartupPath, "members.txt");

            // determine next MemberID
            int nextMemberId = 1;

            if (File.Exists(filePath))
            {
                foreach (var line in File.ReadAllLines(filePath))
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] parts = line.Split('#');
                    if (parts.Length > 0 && int.TryParse(parts[0], out int id))
                    {
                        if (id >= nextMemberId)
                            nextMemberId = id + 1;
                    }
                }
            }

            string status = "Active";

            // MemberID#FirstName#LastName#Phone#Email#Active
            string newLine = nextMemberId + "#" +
                             firstName + "#" +
                             lastName + "#" +
                             phone + "#" +
                             email + "#" +
                             status;

            // append to file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(newLine);
            }

            MessageBox.Show("Member added!");

            // clear fields
            firstNameTextbox.Clear();
            lastNameTextbox.Clear();
            phoneTextbox.Clear();
            emailTextbox.Clear();

            // go back to Members screen and refresh list
            Form1 parent = this.FindForm() as Form1;
            if (parent != null)
            {
                parent.ShowMembersControl();
            }
        }
    }
}
