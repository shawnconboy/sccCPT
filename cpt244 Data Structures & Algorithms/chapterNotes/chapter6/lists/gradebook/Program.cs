using System;

class Program
{
    static void Main()
    {

        Console.Clear();
        // gradebook
        List<int> grades = new List<int>();

        int sentinel = 0;
        while (sentinel != -1)
        {
            Console.WriteLine("Enter grade (-1 to stop)");
            int grade = int.Parse(Console.ReadLine());
            if (grade == -1) break;
            grades.Add(grade);
        }

        Console.Clear();
        Console.WriteLine("Class Grades\n");
        foreach (var grade in grades)
        {
            Console.WriteLine(grade);
        }
    }
}