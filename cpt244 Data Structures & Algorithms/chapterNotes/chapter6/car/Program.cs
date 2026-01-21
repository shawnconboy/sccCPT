using System;

namespace Garage
{
    class Battery
    {
        public bool charged = true;
    }

    class Starter
    {
        public bool Engage(Battery battery)
        {
            if (battery.charged)
            {
                Console.WriteLine("Starter Engaged.");
                return true;
            }
            else
            {
                Console.WriteLine("Battery dead. Can't start.");
                return false;
            }
        }
    }

    class Car
    {
        public Battery battery = new Battery();
        public Starter starter = new Starter();

        public void Start()
        {
            Console.WriteLine("Attempting to start car...");
            bool started = starter.Engage(battery);

            if (started)
            {
                Console.WriteLine("Car is running.");
            }
            else
            {
                Console.WriteLine("Car failed to start.");
            }
        }
    }


    class Program
    {
        static void Main()
        {
            Console.Clear();
            Car myCar = new Car();

            myCar.battery.charged = false;
            myCar.Start();
        }
    }
}