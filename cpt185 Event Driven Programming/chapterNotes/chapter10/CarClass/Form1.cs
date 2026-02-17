using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car newCar = new Car();

            newCar.Year = 1994;
            newCar.Make = "Honda";
            newCar.Accelerate();

            Console.WriteLine(newCar.Speed);
        }
    }
}
