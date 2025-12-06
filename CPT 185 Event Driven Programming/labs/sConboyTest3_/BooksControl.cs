using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sConboyTest3_
{
    public partial class BooksControl : UserControl
    {
        // remember last sort state
        private int lastSortFieldIndex = -1;   // -1 = none yet
        private bool lastSortAscending = true; // last direction

        public BooksControl()
        {
            InitializeComponent();

            // optional: monospace font so columns line up nicer
            booksListbox.Font = new Font("Consolas", 9);
        }

        // Loads all books from books.txt into booksListbox
        public void LoadBooksFromFile()
        {
            booksListbox.Items.Clear();  // make sure it's empty first

            string filePath = Path.Combine(Application.StartupPath, "books.txt");

            if (!File.Exists(filePath))
            {
                return;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    // Format: Title#Author#Genre#Isbn
                    string[] parts = line.Split('#');

                    if (parts.Length >= 4)
                    {
                        string title = parts[0];
                        string author = parts[1];
                        string genre = parts[2];
                        string isbn = parts[3];

                        string displayText =
                            title.PadRight(45) + " " +
                            author.PadRight(35) + " " +
                            genre.PadRight(20) + " " +
                            isbn.PadRight(20);

                        booksListbox.Items.Add(displayText);
                    }
                }
            }
        }

        // "Add A Book" button on this control
        private void addBookButton_Click(object sender, EventArgs e)
        {
            Form1 parent = this.FindForm() as Form1;

            if (parent != null)
            {
                parent.ShowAddBookControl();
            }
        }

        // Delete Selected button
        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            if (booksListbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }

            int indexToRemove = booksListbox.SelectedIndex;

            string filePath = Path.Combine(Application.StartupPath, "books.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No books file found.");
                return;
            }

            var allLines = File.ReadAllLines(filePath).ToList();

            if (indexToRemove < 0 || indexToRemove >= allLines.Count)
            {
                MessageBox.Show("Could not remove that book.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this book?",
                                         "Confirm Delete",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            allLines.RemoveAt(indexToRemove);

            File.WriteAllLines(filePath, allLines);

            LoadBooksFromFile();
        }

        // ===== SORT BUTTONS =====

        private void titleSortButton_Click(object sender, EventArgs e)
        {
            SortBooksByField(0); // Title
        }

        private void authorSortButton_Click(object sender, EventArgs e)
        {
            SortBooksByField(1); // Author
        }

        private void genreSortButton_Click(object sender, EventArgs e)
        {
            SortBooksByField(2); // Genre
        }

        private void isbnSortButton_Click(object sender, EventArgs e)
        {
            SortBooksByField(3); // ISBN
        }

        // Helper: sorts by given field index, toggling asc/desc on repeated clicks
        private void SortBooksByField(int fieldIndex)
        {
            string filePath = Path.Combine(Application.StartupPath, "books.txt");

            if (!File.Exists(filePath))
                return;

            var lines = File.ReadAllLines(filePath)
                            .Where(line => !string.IsNullOrWhiteSpace(line));

            // figure out if this click should be ascending or descending
            bool ascending;

            if (fieldIndex == lastSortFieldIndex)
            {
                // same column as last time → flip direction
                ascending = !lastSortAscending;
            }
            else
            {
                // new column → start with ascending
                ascending = true;
            }

            // key selector: get the correct part (Title, Author, etc.)
            Func<string, string> getKey = line =>
            {
                string[] parts = line.Split('#');
                if (parts.Length > fieldIndex)
                    return parts[fieldIndex];
                return "";
            };

            IOrderedEnumerable<string> sorted;

            if (ascending)
                sorted = lines.OrderBy(getKey);
            else
                sorted = lines.OrderByDescending(getKey);

            var sortedLines = sorted.ToList();

            // save new order back to file
            File.WriteAllLines(filePath, sortedLines);

            // remember last sort state
            lastSortFieldIndex = fieldIndex;
            lastSortAscending = ascending;

            // refresh UI
            LoadBooksFromFile();
        }
    }
}
