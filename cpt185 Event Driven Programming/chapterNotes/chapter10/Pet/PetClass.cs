using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    internal class PetClass
    {
    // fields
        
        private string Name { get; set; }
        private string Type { get; set; }
        private int Age { get; set; }

    // constructors
        
        // default constructor
        public PetClass()
        {
            Name = "";
            Type = "";
            Age = 0;
        }

        // parameterized constructor
        public PetClass(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }

    // methods

        public string displayPetInfo()
        {
            string petInfo = this.Name + ", " + this.Type + ", " + this.Age;

            return petInfo;
        }


    }
}
