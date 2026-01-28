using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace libraryDemo
{
    internal class Person
    {
        // fields
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public List<Person> Children = new List<Person>();

        // readonly
        public readonly DateTime Instantiated;

        // constructor
        public Person(string name)
        {
            Name = name;
            DateOfBirth = null;
            Instantiated = DateTime.Now;           
        }

        // methods
        public void addStuff()
        {

        }
    }
}
