// gives access to console tools like WriteLine, ReadLine, Clear
using System;

// gives access to List<T> which lets us store multiple Contact objects
using System.Collections.Generic;

class Program
{
    // this class describes what a single contact looks like
    public class Contact
    {
        // this makes a public Name variable we can read or change
        public string Name { get; set; }

        // this makes a public Phone variable we can read or change
        public string Phone { get; set; }

        // this runs when we create a new Contact and sets up Name + Phone
        public Contact(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }

    static void Main()
    {
        // clears anything already on the console screen
        Console.Clear();

        // make a new list that will hold all of our Contact objects
        List<Contact> contacts = new List<Contact>();

        // add a few sample contacts to the list
        contacts.Add(new Contact("Brielle", "864-444-5555"));
        contacts.Add(new Contact("Miley", "864-888-9988"));
        contacts.Add(new Contact("Dominique", "888-333-4444"));

        // print the table header with "Name" and "Number"
        // the -15 keeps the names lined up evenly
        Console.WriteLine($"{"Name",-15}{"Number"}");

        // print a row of dashes underneath the header
        Console.WriteLine(new string('-', 30));

        // go through every contact in the list, one at a time
        foreach (Contact contact in contacts)
        {
            // print the contact’s name and phone side by side, spaced evenly
            Console.WriteLine($"{contact.Name,-15}{contact.Phone}");
        }

        // keep the console window open until Enter is pressed
        Console.ReadLine();
    }
}
