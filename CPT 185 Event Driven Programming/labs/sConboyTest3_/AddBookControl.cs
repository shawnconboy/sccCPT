using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;             // <-- IMPORTANT
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sConboyTest3_
{
    public partial class AddBookControl : UserControl
    {
        public AddBookControl()
        {
            InitializeComponent();
        }

        // wired to your Add Book button (addBookButton_Click_1)
        private void addBookButton_Click_1(object sender, EventArgs e)
        {
            // check if textboxes are filled out
            if (string.IsNullOrWhiteSpace(titleTextbox.Text) ||
                string.IsNullOrWhiteSpace(authorTextbox.Text) ||
                string.IsNullOrWhiteSpace(genreTextbox.Text) ||
                string.IsNullOrWhiteSpace(isbnTextbox.Text))
            {
                MessageBox.Show("Please fill in Title, Author, Genre, and ISBN.");
                return;
            }

            string title = titleTextbox.Text.Trim();
            string author = authorTextbox.Text.Trim();
            string genre = genreTextbox.Text.Trim();
            string isbn = isbnTextbox.Text.Trim();

            // new books start as Available
            string isAvailable = "Available";

            // Format in file: Title#Author#Genre#Isbn#IsAvailable
            string line = title + "#" + author + "#" + genre + "#" + isbn + "#" + isAvailable;

            string filePath = Path.Combine(Application.StartupPath, "books.txt");

            // append to the file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(line);
            }

            // added message
            MessageBox.Show("Book added!");

            // clear fields
            titleTextbox.Clear();
            authorTextbox.Clear();
            genreTextbox.Clear();
            isbnTextbox.Clear();

            // go back to Books screen and refresh list
            Form1 parent = this.FindForm() as Form1;
            if (parent != null)
            {
                parent.ShowBooksControl();
            }
        }
    }
}
