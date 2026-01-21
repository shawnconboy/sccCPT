using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ships
{
    public class Ship
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }

        // parameterless constructor
        public Ship()
        {
            Name = string.Empty;
            Year = string.Empty;
            Description = string.Empty;
        }
        // normal constructor
        public Ship(string name, string year)
        {
            Name = name;
            Year = year;
            Description = "This is a shippy ship.";
        }

        public override string ToString()
        {
            return Name + " " + Description + " Built in " + Year;
        }
    }

    public class CargoShip : Ship
    {
        public int TonnageCapacity { get; set; }

        public CargoShip()
        {
            TonnageCapacity = 0;
        }

        public CargoShip(string name, int tennageCapacity, string year)
        {
            Name = name;
            TonnageCapacity = tennageCapacity;
            Year = year;
            Description = "This is a ship that holds stuff.";
        }

        public override string ToString()
        {
            return Name + " " + Description + " Capacity : " + TonnageCapacity;
        }
    }

    public class CruiseShip : Ship
    {
        public int  PassengerCapacity { get; set; }
        public CruiseShip()
        {
            PassengerCapacity = 0;
        }
        public CruiseShip(string name, int passengerCapacity, string year)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
            Year = year;
            Description = "This is a ship that holds people.";
        }

        public override string ToString()
        {
            return Name + " " + Description + " Capacity : " + PassengerCapacity;
        }
    }
}
