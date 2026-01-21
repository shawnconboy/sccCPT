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
    public partial class Write : UserControl
    {
        Random rand = new Random();

        public Write()
        {
            InitializeComponent();
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {

            try
            {
                // get user input
                if (!int.TryParse(numbersTextbox.Text, out int userNum))
                {
                    MessageBox.Show("Enter a valid number, please, shawty.");
                }

                // create list of random nums from 0 to user input
                int[] nums = new int[userNum];

                for (int i = 0; i < userNum; i++)
                {
                    nums[i] = rand.Next(0, userNum);
                }

                // create file, write number to that thang
                SaveFileDialog newFile = new SaveFileDialog();

                // open the bish
                if (newFile.ShowDialog() == DialogResult.OK)
                {
                    string path = newFile.FileName;

                    using (StreamWriter write = new StreamWriter(path))
                    {
                        foreach (int i in nums)
                        {
                            write.WriteLine(i);
                        }
                    }
                    MessageBox.Show("File written successfully.");
                }
                else
                {
                    MessageBox.Show("File no bueno shawty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
