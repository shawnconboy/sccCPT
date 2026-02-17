using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class Car
    {

        // fields

        public int Year { get; set; }
        public string Make { get; set; }
        public int Speed { get; set; }

        // constructors

        public Car()
        {
            Year = 0000;
            Make = "";
            Speed = 0;
        }

        public Car(int year, string make)
        {
            Year = year;
            Make = make;
            Speed = 0;
        }

        // methods

        public void Accelerate()
        {
            Speed += 5;
        }

        public void Decelerate()
        {
            Speed -= 5;
        }

    }
}
