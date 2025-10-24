using System;

class Program
{
    // create a program to tell how many  words are in a string
    static void Main()
    {

        int wordCount = 0;
        int letterCount = 0;
        string userString = "Larry the lobster eats crab daily.";

        // use .split(null) to split the string by the white spaces
        string[] words = userString.Split(null);

        // isolate and the total words
        foreach (string word in words)
        {
            wordCount++;

            // isolate and count the total letters
            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    letterCount++;
                }
            }
        }

        // get the average of the letters per word
        double averageLetters = (double)letterCount / wordCount;

        // spit data back to user
        Console.WriteLine($"Total words in string : {wordCount}");
        Console.WriteLine($"Average letters per word : {averageLetters:F2}");
    }
}