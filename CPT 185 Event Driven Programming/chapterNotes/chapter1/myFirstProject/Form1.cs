using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            message_label.Text = "Would you like to place an order?";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the floorplan.");
        }
    }
}
