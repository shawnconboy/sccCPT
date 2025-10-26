using System;
using System.Collections.Generic;

namespace DataStructuresGuide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ===========================================================
                ARRAYS
                - Fixed size, sequential elements of same type
                - Zero-based indexing
            ===========================================================
            */

            // Declaration and initialization (empty with size)
            int[] numbers = new int[5]; // { 0, 0, 0, 0, 0 }

            // Declaration with initial values
            int[] nums = { 1, 2, 3, 4, 5 };

            // Accessing elements
            int firstElement = nums[0];   // 1
            int thirdElement = nums[2];   // 3

            // Modify element
            nums[2] = 10; // Now nums = { 1, 2, 10, 4, 5 }

            // Iterate with for loop
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            // Iterate with foreach loop
            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }

            // Length property
            int arrayLength = nums.Length;
            Console.WriteLine($"Array length: {arrayLength}");


            /*
            ===========================================================
                LISTS
                - Dynamic array (can grow/shrink)
                - Found in System.Collections.Generic
            ===========================================================
            */

            // Create empty list
            List<int> listNums = new List<int>();

            // Add elements
            listNums.Add(1);
            listNums.Add(2);
            listNums.Add(3);

            // Initialize with values
            List<string> names = new List<string>() { "Alice", "Bob", "Charlie" };

            // Access by index
            string firstName = names[0]; // "Alice"

            // Iterate with for loop
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            // Iterate with foreach
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Remove by value
            listNums.Remove(2); // Removes element "2"
            // Remove by index
            listNums.RemoveAt(0); // Removes first element
            // Clear all
            listNums.Clear();

            // Count property
            Console.WriteLine($"List count: {names.Count}");


            /*
            ===========================================================
                STACKS
                - LIFO (Last In, First Out)
                - Push = add to top
                - Pop = remove top
                - Peek = view top
            ===========================================================
            */

            Stack<int> stack = new Stack<int>();

            // Push elements
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            // Stack now = { 3, 2, 1 } (top is 3)

            // Peek top (view only)
            int topElement = stack.Peek(); // 3
            Console.WriteLine($"Top of stack: {topElement}");

            // Pop (remove top)
            int popped = stack.Pop(); // returns 3, removes it
            Console.WriteLine($"Popped: {popped}");

            // Stack now = { 2, 1 }

            // Check if empty
            if (stack.Count == 0)
                Console.WriteLine("Stack is empty");

            // Example: Empty stack via loop
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }


            /*
            ===========================================================
                QUEUES
                - FIFO (First In, First Out)
                - Enqueue = add to back
                - Dequeue = remove from front
                - Peek = view front
            ===========================================================
            */

            Queue<string> queue = new Queue<string>();

            // Enqueue elements
            queue.Enqueue("Task 1");
            queue.Enqueue("Task 2");
            queue.Enqueue("Task 3");
            // Queue now = { Task 1, Task 2, Task 3 }

            // Peek (view front)
            string frontTask = queue.Peek(); // "Task 1"
            Console.WriteLine($"Front task: {frontTask}");

            // Dequeue (remove front)
            string dequeuedTask = queue.Dequeue(); // "Task 1"
            Console.WriteLine($"Dequeued: {dequeuedTask}");

            // Queue now = { Task 2, Task 3 }

            // Check if empty
            if (queue.Count == 0)
                Console.WriteLine("Queue is empty");

            // Example: Empty queue
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }


            /*
            ===========================================================
                SUMMARY
                Arrays  = fixed size, fast indexing
                Lists   = resizable arrays (dynamic)
                Stacks  = LIFO (Undo, backtracking)
                Queues  = FIFO (task order, scheduling)
            ===========================================================
            */

            Console.WriteLine("\n=== Data Structures Review Complete ===");
        }
    }
}
