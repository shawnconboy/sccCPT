using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dealership.DealershipDataSetTableAdapters;


namespace dealership
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            int year = int.Parse(yearTextbox.Text);
            string make = makeTextbox.Text;
            string model = modelTextbox.Text;
            int mileage = int.Parse(mileageTextbox.Text);
            string color = colorTextbox.Text;
            decimal purchasePrice = decimal.Parse(purchaseTextbox.Text);
            decimal listPrice = decimal.Parse(listTextbox.Text);
        }
    }
}
