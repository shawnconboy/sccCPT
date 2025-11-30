using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventoryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    // define the class
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        // constructor
        public Item(int itemID, string name, int quantity, int price)
        {
            ItemID = itemID;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
