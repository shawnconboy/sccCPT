using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        List<string> items = new List<string>();

        items.Add("Coffee");
        items.Add("Donuts");
        items.Add("Napkins");

        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}