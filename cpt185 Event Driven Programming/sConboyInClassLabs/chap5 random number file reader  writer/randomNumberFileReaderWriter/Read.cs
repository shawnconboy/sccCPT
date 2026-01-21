using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomNumberFileReaderWriter
{
    public partial class Read : UserControl
    {
        public Read()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("File Found!");
                // set path
                string path = openFile.FileName;
                try
                {
                    // read them bitties in
                    string[] lines = File.ReadAllLines(path);

                    // add them to the listbox and get sum                   
                    int sum = 0;
                    readNumberListbox.Items.Clear();
                    for (int i = 0; i < lines.Length; i++)
                    {
                        int number = int.Parse(lines[i]);
                        readNumberListbox.Items.Add(number);
                        sum += number;
                    }

                    // display
                    totalNumsTextbox.Text = lines.Length.ToString();
                    sumOfNumsTextbox.Text = sum.ToString();
                }
                catch
                {
                    MessageBox.Show("Something went wrong, shawty.");
                }
            }
        }
    }
}
