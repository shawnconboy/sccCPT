using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sConboyTest3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ================== BOOKS ==================

        // displays book control
        private void booksButton_Click(object sender, EventArgs e)
        {
            // refresh the list from the text file
            booksControl1.LoadBooksFromFile();
            booksControl1.BringToFront();
        }

        // displays add book control
        public void ShowAddBookControl()
        {
            addBookControl1.BringToFront();
        }

        // called from AddBookControl after saving a book
        public void ShowBooksControl()
        {
            booksControl1.LoadBooksFromFile();
            booksControl1.BringToFront();
        }

        // ================== MEMBERS ==================

        // displays member control from main nav button
        private void membersButton_Click(object sender, EventArgs e)
        {
            members1.LoadMembersFromFile();
            members1.BringToFront();
        }

        // called from Members control when "Add Member" is clicked
        public void ShowAddMemberControl()
        {
            addMember1.BringToFront();   // change addMember1 if your instance has a different name
        }

        // called from AddMember control after saving a member
        public void ShowMembersControl()
        {
            members1.LoadMembersFromFile();
            members1.BringToFront();
        }

        // ================== HOME / CLOSE ==================

        // displays home control
        private void homeButton_Click(object sender, EventArgs e)
        {
            homeControl1.BringToFront();
        }

        // closes form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
