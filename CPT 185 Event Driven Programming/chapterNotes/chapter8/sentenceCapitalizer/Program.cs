using System;

class Program
{
    static void Main()
    {
        // take user string and return a new string with
        // the first letter of each sentence capitalized

        string userString;
        Console.WriteLine("Enter text : ");
        userString = Console.ReadLine();

        string[] sentences = userString.Split('.');
        string result = "";

        foreach (string sentence in sentences)
        {
            string trimmed = sentence.Trim();

            if (trimmed.Length > 0)
            {
                string capitalized = char.ToUpper(trimmed[0]) + trimmed.Substring(1);
                result += capitalized + ". ";
            }
        }

        Console.WriteLine("\n" + result.Trim());
    }
}