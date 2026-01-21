using System;

namespace ships
{
    public partial class Form1 : Form
    {

        List<Ship> fleet = new List<Ship>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addShipButton_Click(object sender, EventArgs e)
        {

            try
            {
                fleet.Add(new Ship(shipNameTextbox.Text, yearBuiltTextbox.Text));
                updateListbox();
                clearTextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addCruiserButton_Click(object sender, EventArgs e)
        {
            int.TryParse(occupantCapacityTextbox.Text, out int capacity);
            fleet.Add(new CruiseShip(shipNameTextbox.Text, capacity, yearBuiltTextbox.Text));
            updateListbox();
            clearTextboxes();

        }

        private void addCargoButton_Click(object sender, EventArgs e)
        {
            int.TryParse(cargoCapacityTextbox.Text, out int capacity);
            fleet.Add(new CargoShip(shipNameTextbox.Text, capacity, yearBuiltTextbox.Text));
            updateListbox();
            clearTextboxes();


        }

        private void viewShipsButton_Click(object sender, EventArgs e)
        {

            updateListbox();
        }

        private void updateListbox()
        {
            shipListbox.Items.Clear();
            foreach (Ship ship in fleet)
            {
                shipListbox.Items.Add(ship.ToString());
            }
        }

        private void clearTextboxes()
        {
            cargoCapacityTextbox.Clear();
            occupantCapacityTextbox.Clear();
            shipNameTextbox.Clear();
            yearBuiltTextbox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
