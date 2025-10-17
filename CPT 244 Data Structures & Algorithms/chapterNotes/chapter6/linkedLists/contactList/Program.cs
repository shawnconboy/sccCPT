using System;

class Program
{

    public class Contact
    {
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
        List<Contact> contacts = new List<Contact>();

        contacts.Add(new Contact("Brielle", "864-444-5555"));
        contacts.Add(new Contact("Miley", "864-888-9988"));

        foreach (Contact c in contacts)
        {
            Console.WriteLine($"{c.Name} - {c.Phone}");
        }
    }
}