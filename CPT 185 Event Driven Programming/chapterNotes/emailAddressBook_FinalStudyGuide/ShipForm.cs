using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emailAddressBook_FinalStudyGuide
{
    public partial class ShipForm : Form
    {

        List<Ship> fleet = new List<Ship>();

        public ShipForm()
        {
            InitializeComponent();
        }

        private void addShipButton_Click(object sender, EventArgs e)
        {
            fleet.Add(new Ship(nameTextbox.Text, yearBuiltTextbox.Text));
        }

        private void addCruiseButton_Click(object sender, EventArgs e)
        {
            int.TryParse(capacityTextbox.Text, out int passengers);

            fleet.Add(new CruiseShip(nameTextbox.Text, yearBuiltTextbox.Text, passengers));
        }

        private void addCargoButton_Click(object sender, EventArgs e)
        {
            int.TryParse(tonnageTextbox.Text, out int weight);
            
        }
    }

    
}
