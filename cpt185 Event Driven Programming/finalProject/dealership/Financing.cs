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
    public partial class Financing : Form
    {
        public Financing()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dealershipDataSet);

        }

        private void Financing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dealershipDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.dealershipDataSet.Sales);
            // TODO: This line of code loads data into the 'dealershipDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dealershipDataSet.Customer);

        }
    }
}
