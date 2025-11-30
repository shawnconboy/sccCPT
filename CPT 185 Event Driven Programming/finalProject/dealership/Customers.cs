using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dealership
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Added!");
        }

        private void seeAllCustomersButton_Click(object sender, EventArgs e)
        {
            AllCustomers allCustomers = new AllCustomers();
            allCustomers.ShowDialog();
        }
    }
}
