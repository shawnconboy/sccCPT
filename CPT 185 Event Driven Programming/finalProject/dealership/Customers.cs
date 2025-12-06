using dealership.DealershipDataSetTableAdapters;
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

        // close papi
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // add buttttttttoon
        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Added!");

            // validate inputs
            string firstName = firstNameTextbox.Text;
            string lastName = lastNameTextbox.Text;
            string email = emailTextbox.Text;
            string phone = phoneTextbox.Text;
            
            // add data to row in table
            using (CustomerTableAdapter customerAdapter = new CustomerTableAdapter())
            {
                customerAdapter.Insert(firstName, lastName, email, phone);
            }

        }

        private void seeAllCustomersButton_Click(object sender, EventArgs e)
        {
            // open all customers form
            AllCustomers allCustomers = new AllCustomers();
            allCustomers.ShowDialog();
        }
    }
}
