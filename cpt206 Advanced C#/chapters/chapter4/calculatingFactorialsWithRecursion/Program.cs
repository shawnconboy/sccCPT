namespace calculatingFactorialsWithRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int Factorial(int number)
            {
                if (number < 1)
                {
                    return 0;
                } else if (number == 1)
                {
                    return 1;
                } else
                {
                    checked
                    {
                        return number * Factorial(number - 1);
                    }
                }
            }

            static void RunFactorial()
            {
                for (int i = 1; i < 15; i++)
                {
                    try
                    {
                        Console.WriteLine($"{i}! = {Factorial(i):N0}");

                    }
                    catch (System.OverflowException)
                    {
                        Console.WriteLine($"{i}! is too big for a 32 bit-integer.");
                    }
                }
            }
            RunFactorial();
        }
    }
}
