using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sConboyTest3Resubmission
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDataSet.Book);

        }

        private void closePicture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (titleTextbox.Text == "")
            {
                MessageBox.Show("Please enter a title for the book.", "Missing Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (authorTextbox.Text == "")
            {
                MessageBox.Show("Please enter an author for the book.", "Missing Author", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DataRow newBook = libraryDataSet.Book.NewRow();

                    newBook["Title"] = titleTextbox.Text;
                    newBook["Author"] = authorTextbox.Text;
                    newBook["ISBN"] = isbnTextbox.Text;

                    newBook["IsAvailable"] = true;


                    libraryDataSet.Book.Rows.Add(newBook);

                    this.bookTableAdapter.Update(this.libraryDataSet.Book);

                    MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
