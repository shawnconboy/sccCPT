using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flagSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Argentina";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Canada";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "America";
        }
    }
}
