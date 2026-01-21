using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sConboyLab9Dorm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // This method lets Form1 send the numbers over
        public void ShowTotals(double dormTotal, double mealTotal)
        {
            double total = dormTotal + mealTotal;

            dormChargesLabel.Text = dormTotal.ToString("C2");
            mealChargesLabel.Text = mealTotal.ToString("C2");
            totalChargesLabel.Text = total.ToString("C2");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
