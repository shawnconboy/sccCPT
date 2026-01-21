using System.Collections.Generic;

namespace retailItem
{
    public partial class Form1 : Form
    {
        List<RetailItem> items = new List<RetailItem>();

        public Form1()
        {
            InitializeComponent();
        }

        public void showItemsButton_Click(object sender, EventArgs e)
        {
            // clear items so no repeats
            itemsListbox.Items.Clear();

            // loop through list and put items in listbox
            foreach (RetailItem item in items)
            {
                itemsListbox.Items.Add(item);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            items.Add(new RetailItem("Jacket", 59.99m, 13));
            items.Add(new RetailItem("Hoodie", 29.99m, 10));
            items.Add(new RetailItem("Cardigan", 79.99m, 4));
        }


        private void addItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string description = descriptionTextbox.Text;
                decimal price = Decimal.Parse(priceTextbox.Text);
                int unitsOnHand = int.Parse(onHandTextbox.Text);

                RetailItem item = new RetailItem(description, price, unitsOnHand);
                items.Add(item);
                itemsListbox.Items.Add(item);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }

    public class RetailItem
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int UnitsOnHand { get; set; }

        public RetailItem(string description, decimal price, int unitsOnHand)
        {
            Description = description;
            Price = price;
            UnitsOnHand = unitsOnHand;
        }

        public override string ToString()
        {
            return $"{Description,-30} {Price.ToString("C"),-20} {UnitsOnHand,5}";
        }

    }
}
