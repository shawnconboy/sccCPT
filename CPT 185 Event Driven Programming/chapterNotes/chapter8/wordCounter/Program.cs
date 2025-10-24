using System;

class Program
{
    static void Main()
    {

        int count = 0;
        string userString = "Larry the lobster eats crab daily.";

        string[] tokens = userString.Split(null);

        foreach (string s in tokens)
        {
            count++;
        }

        Console.WriteLine($"Total words in string : {count}");
    }
}