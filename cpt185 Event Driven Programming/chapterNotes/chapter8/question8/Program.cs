using System;
using System.Reflection.Metadata;
class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Enter a string of numbers separated by commas.");

        string userString = Console.ReadLine();

        // tokenize and then add total

        userString.Trim();

        string[] token = userString.Split(',');

        int[] nums = new int[token.Length];

        int total = 0;
        for (int i = 0; i < token.Length; i++)
        {
            nums[i] = int.Parse(token[i]);
            total += nums[i];
        }

        Console.WriteLine("Total is : " + total.ToString());
    }
}