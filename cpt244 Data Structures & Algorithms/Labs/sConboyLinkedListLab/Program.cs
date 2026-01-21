// Shawn Conboy
// CPT 244 A01H
// Task Scheduler

using System;

namespace TaskScheduler
{
    // define the task object
    class TaskItem
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public DateTime DueDate { get; set; }

        public TaskItem(string name, int priority, DateTime dueDate)
        {
            Name = name;
            Priority = priority;
            DueDate = dueDate;
        }
    }
    // set up the nodes
    class Node
    {
        public TaskItem Data { get; set; }
        public Node Next { get; set; }

        public Node(TaskItem data)
        {
            Data = data;
            Next = null;
        }
    }
    // set up the linked list
    class TaskLinkedList
    {
        private Node headNode;
        private Node tailNode;
        
        // add a task
        public void AddTask(string name, int priority, DateTime dueDate)
        {
            TaskItem newTask = new TaskItem(name, priority, dueDate);
            Node newNode = new Node(newTask);

            if (headNode == null)
            {
                headNode = newNode;
                tailNode = newNode;
            }
            else
            {
                tailNode.Next = newNode;
                tailNode = newNode;
            }
        }

        // get rid of a task
        public bool RemoveTask(string name)
        {
            if (headNode == null) return false;

            if (headNode.Data.Name == name)
            {
                headNode = headNode.Next;
                if (headNode == null) tailNode = null;
                return true;
            }

            Node previousNode = headNode;
            Node currentNode = headNode.Next;

            while (currentNode != null)
            {
                if (currentNode.Data.Name == name)
                {
                    previousNode.Next = currentNode.Next;
                    if (currentNode == tailNode) tailNode = previousNode;
                    return true;
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            return false;
        }
        
        // show all the tasks
        public void ListTasks()
        {
            Console.Clear();
            Console.WriteLine("\tAll Tasks");
            Console.WriteLine("-----------------------------------");

            if (headNode == null)
            {
                Console.WriteLine("No tasks.");
                return;
            }

            Node currentNode = headNode;
            while (currentNode != null)
            {
                TaskItem t = currentNode.Data;
                Console.WriteLine("Name: " + t.Name + " | Priority: " + t.Priority + " | Due: " + t.DueDate.ToShortDateString());
                currentNode = currentNode.Next;
            }
        }

        // filter out tasks that are past due
        public void FindOverdueTasks(DateTime currentDate)
        {
            Console.Clear();
            Console.WriteLine("=== Overdue Tasks ===");
            bool foundAny = false;

            Node currentNode = headNode;
            while (currentNode != null)
            {
                TaskItem t = currentNode.Data;
                if (t.DueDate < currentDate)
                {
                    Console.WriteLine("Name: " + t.Name + " | Priority: " + t.Priority + " | Due: " + t.DueDate.ToShortDateString());
                    foundAny = true;
                }
                currentNode = currentNode.Next;
            }

            if (!foundAny) Console.WriteLine("No overdue tasks.");
        }
    }

    class Program
    {
        static void Main()
        {
            TaskLinkedList tasks = new TaskLinkedList();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Task Scheduler");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1. Show All Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Find Overdue Tasks");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option : ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    tasks.ListTasks();
                    Console.WriteLine("\nPress Enter to return to menu.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("=== Add Task ===");
                    Console.Write("Task name: ");
                    string nameInput = Console.ReadLine();

                    Console.Write("Priority (number): ");
                    int priorityInput;
                    while (!int.TryParse(Console.ReadLine(), out priorityInput))
                    {
                        Console.Write("Enter a number: ");
                    }

                    Console.Write("Due date (any date format): ");
                    DateTime dueInput;
                    while (!DateTime.TryParse(Console.ReadLine(), out dueInput))
                    {
                        Console.Write("Enter a valid date: ");
                    }

                    tasks.AddTask(nameInput, priorityInput, dueInput);
                    Console.WriteLine("Task added. Press Enter to return to menu.");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine("=== Remove Task ===");
                    Console.Write("Task name to remove: ");
                    string nameToRemove = Console.ReadLine();

                    bool removed = tasks.RemoveTask(nameToRemove);
                    if (removed) Console.WriteLine("Task removed.");
                    else Console.WriteLine("Task not found.");

                    Console.WriteLine("Press Enter to return to menu.");
                    Console.ReadLine();
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    Console.WriteLine("=== Find Overdue Tasks ===");
                    Console.Write("Current date (or press Enter for today): ");
                    string raw = Console.ReadLine();

                    DateTime currentDate;
                    if (string.IsNullOrWhiteSpace(raw))
                    {
                        currentDate = DateTime.Today;
                    }
                    else
                    {
                        while (!DateTime.TryParse(raw, out currentDate))
                        {
                            Console.Write("Enter a valid date: ");
                            raw = Console.ReadLine();
                        }
                    }

                    tasks.FindOverdueTasks(currentDate);
                    Console.WriteLine("\nPress Enter to return to menu.");
                    Console.ReadLine();
                }
                else if (choice == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Press Enter to try again.");
                    Console.ReadLine();
                }
            }
        }
    }
}
