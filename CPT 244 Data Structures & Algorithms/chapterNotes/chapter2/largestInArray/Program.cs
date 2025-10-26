using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 40, 32, 99 };

        // Call the method and display result
        int result = Largest(numbers);
        Console.WriteLine($"Largest number: {result}");
    }

    // Define the method OUTSIDE of Main
    static int Largest(int[] arrayName)
    {
        int largest = arrayName[0]; // start from first element

        for (int i = 1; i < arrayName.Length; i++)
        {
            if (arrayName[i] > largest)
            {
                largest = arrayName[i];
            }
        }

        return largest;
    }
}
