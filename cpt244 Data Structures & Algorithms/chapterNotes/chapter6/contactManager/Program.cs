// create a contact manager console application

// delete contact
// sort contacts
// search contacts by name
// file saving (save contacts to a file)

using System;
using System.Transactions;
using System.Linq;

class Program
{
    class Contact
    {
        // declares top level variables but not really
        // declares them so that they can be utilized in
        // the "contact" method that assigns them...?
        public string Name { get; set; }
        public string Phone { get; set; }

        public Contact(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }
    static void Main()
    {
        Console.Clear();
        // create a list to hold all new contact objects
        List<Contact> contacts = new List<Contact>();
        contacts.Add(new Contact("Barney", "888-888-0000"));

        // menu
        int userChoice = 0;

        while (userChoice != 4)
        {
            Console.Clear();
            Console.WriteLine("1    See All Contacts");
            Console.WriteLine("2    Add a Contact");
            Console.WriteLine("3    Delete a Contact");
            Console.WriteLine("4    Exit");

            Console.Write("What would you like to do?  ");
            userChoice = int.Parse(Console.ReadLine());

            // see all contacts
            if (userChoice == 1)
            {
                Console.Clear();
                // print header
                Console.WriteLine($"{"Name",-15}{"Number"}");
                Console.WriteLine(new string('-', 30));

                // print list of contacts
                foreach (Contact person in contacts)
                {
                    Console.WriteLine($"{person.Name,-15}{person.Phone}");
                }

                Console.WriteLine("\n\nPress enter to go back to menu.");
                Console.Read();
            }

            // add a contact
            if (userChoice == 2)
            {
                Console.Clear();
                Console.WriteLine("Enter new contact name");
                string nameAdd = Console.ReadLine();
                Console.WriteLine("Enter new contact number");
                string numberAdd = Console.ReadLine();

                contacts.Add(new Contact(nameAdd, numberAdd));
            }

            // delete a contact
            // delete a contact
            if (userChoice == 3)
            {
                Console.Clear();
                Console.WriteLine("Enter the name of the contact to delete:");
                string contactToBeDeleted = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < contacts.Count; i++)
                {
                    if (contacts[i].Name == contactToBeDeleted)
                    {
                        contacts.RemoveAt(i);
                        Console.WriteLine("Contact deleted.");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Contact not found.");
                }

                Console.WriteLine("Press enter to return to menu.");
                Console.ReadLine();
            }

            Console.WriteLine("\n\nProgram exited. Thank You.");
        }
    }
}




