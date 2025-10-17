// Shawn Conboy
// CPT 185 A01H
// Arrays Practice 


using System;

namespace sConboyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double odd = 0;
            double even = 0;
            double evenPercent = 0;
            double oddPercent = 0;

            int size = 10;
            int[] grades = new int[size];

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = rand.Next(2);
            }

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }



            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            evenPercent = even / size;

            oddPercent = odd / size;

            Console.WriteLine(evenPercent);
            Console.WriteLine(oddPercent);

        }
    }
}