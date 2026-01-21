using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 10, 25, 1, 36, 55, 2, 41, 87, 100, 5, 22, 39 };
            int[] numbers2 = (int[])numbers1.Clone(); // copy for selection sort

            Console.WriteLine("Original Array:");
            PrintArray(numbers1);

            Console.WriteLine("\n=== Bubble Sort ===");
            bubbleSort(numbers1);
            PrintArray(numbers1);

            Console.WriteLine("\n=== Selection Sort ===");
            selectionSort(numbers2);
            PrintArray(numbers2);
        }

        // BUBBLE SORT
        private static void bubbleSort(int[] x)
        {
            for (int i = 0; i < x.Length - 1; i++)
            {
                for (int j = 0; j < x.Length - i - 1; j++)
                {
                    if (x[j] > x[j + 1])
                    {
                        int temp = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = temp;

                        Console.WriteLine($"Swapped {x[j]} and {x[j + 1]}");
                    }
                }
                Console.WriteLine($"End of pass #{i + 1}");
            }
            Console.WriteLine("Bubble sort complete.\n");
        }

        // SELECTION SORT
        private static void selectionSort(int[] x)
        {
            for (int i = 0; i < x.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[j] < x[minIndex])
                        minIndex = j;
                }

                if (minIndex != i)
                {
                    int temp = x[i];
                    x[i] = x[minIndex];
                    x[minIndex] = temp;

                    Console.WriteLine($"Swapped {x[i]} and {x[minIndex]}");
                }

                Console.WriteLine($"End of pass #{i + 1}");
            }
            Console.WriteLine("Selection sort complete.\n");
        }

        private static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
