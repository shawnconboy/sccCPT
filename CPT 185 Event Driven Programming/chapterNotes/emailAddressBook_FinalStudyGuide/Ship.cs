using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emailAddressBook_FinalStudyGuide
{
    public class Ship
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }

        public Ship()
        {
            Name = "";
            Description = string.Empty;
            Year = string.Empty;
        }

        public Ship(string name, string year)
        {
            Name = name;
            Description = "This is a shippy ship.";
            Year = year;
        }

        public override string ToString()
        {
            return Name + " " + Description + "Built In : " + Year;
        }
    }

    public class CargoShip : Ship
    {
        public int TonnageCapacity { get; set; }
        
        public CargoShip()
        {
            TonnageCapacity = 0;
        }

        public CargoShip(string name, string year, int tonnage)
        {
            Name = name;
            Year = year;
            Description = "This is a cargo holding ship.";
            TonnageCapacity = tonnage;
        }

        public override string ToString()
        {
            return Name + " " + Description + "Capacity " + TonnageCapacity;
        }
    }

    public class CruiseShip : Ship
    {
        public int PassengerCapacity { get; set; }
        public CruiseShip()
        {
            PassengerCapacity = 0;
        }

        public CruiseShip(string name, string year, int passengerCapacity)
        {
            Name = name;
            Year = year;
            Description = "This is a person holding ship";
            PassengerCapacity = passengerCapacity;
        }

        public override string ToString()
        {
            return Name + " " + Description + "Capacity " + PassengerCapacity;
        }

    }
}
