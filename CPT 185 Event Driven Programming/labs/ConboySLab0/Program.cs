using System.Collections.Specialized;

// Cout is Console.WriteLine();
// Cin is Console.ReadLine();

// get age name and fav number

//string firstName = "";
//int age = 0;
//int favNumber = 0;

//Console.Write("Hello. Please enter your name : ");
//firstName = Console.ReadLine();

//Console.Write("Please enter your age : ");
//age = int.Parse(Console.ReadLine());

//Console.Write("Please enter your favorite number : ");
//favNumber = int.Parse(Console.ReadLine());

//Console.WriteLine($"\nHello {firstName}, your are {age} years old. Your favorite number is {favNumber}.");
//Console.WriteLine($"The difference between your age and favorite number is {(age - favNumber)}.");

//Console.WriteLine("Thank You.");
//Console.Read();

// Suppose your instructor gives 4 exams, 5 labs, and 5 quizzes during the semester
// You want to write a program that calculates your average exam score.
// Out of 100 percent the exams are worth 45 percent, labs are worth 35 percent and quizzes are worth the rest.
// Write a console app in C# that will compute the final average score for the class and the final letter grade.

// Consider the following:
// What items of input must the user enter?
// Once the input has been entered, how will the program determine the average?
// What output will the program display?

// *****************************************************************************************************************************

// Declare Variables / Functions

void clearScreen()
{
    Console.Clear();
}

void header()
{
    Console.WriteLine("***********************************************************");
    Console.WriteLine("*                                                         *");
    Console.WriteLine("*   Hello, Welcome to CPT 185 Event Driven Programming!   *");
    Console.WriteLine("*                    Shawn Conboy                         *");
    Console.WriteLine("*                       Lab 0                             *");
    Console.WriteLine("*                                                         *");
    Console.WriteLine("***********************************************************");
    Console.WriteLine();
}

void transition()
{
    clearScreen();
    header();
}

char runAgain = 'y';
string studentName = "";

// loop per student
while (runAgain == 'y')
{
    transition();

    int[] examScores = [0, 0, 0, 0];
    int[] labScores = [0, 0, 0, 0, 0];
    int[] quizScores = [0, 0, 0, 0, 0];
    int examTotal = 0;
    int labTotal = 0;
    int quizTotal = 0;

    Console.WriteLine("Hello. Please enter your name.");
    studentName = Console.ReadLine();
    Console.WriteLine();

    transition();
    Console.WriteLine($"Hello, {studentName}.\n");
    // Loop to get exam scores
    for (int x = 0; x < 4; x++)
    {
        Console.WriteLine($"Please enter grade for exam {x + 1} : ");
        examScores[x] = int.Parse(Console.ReadLine());
        examTotal += examScores[x];
    }
    Console.ReadLine();

    transition();
    Console.WriteLine($"Hello, {studentName}.\n");
    // Loop to get lab scores
    for (int x = 0; x < 5; x++)
    {
        Console.WriteLine($"Please enter grade for lab {x + 1} : ");
        labScores[x] = int.Parse(Console.ReadLine());
        labTotal += labScores[x];
    }
    Console.ReadLine();

    transition();
    Console.WriteLine($"Hello, {studentName}.\n");

    // Loop to get quiz scores
    for (int x = 0; x < 5; x++)
    {
        Console.WriteLine($"Please enter grade for quiz {x + 1} : ");
        quizScores[x] = int.Parse(Console.ReadLine());
        quizTotal += quizScores[x];
    }

    // *****************************************************************************************************************************

    transition();
    Console.WriteLine($"Hello, {studentName}.\n");

    // Loop to show individual exam scores
    for (int x = 0; x < examScores.Length; x++)
    {
        Console.WriteLine($"Exam {x + 1} score : {examScores[x]}");
    }
    Console.ReadLine();

    // Loop to show individual lab scores
    for (int x = 0; x < labScores.Length; x++)
    {
        Console.WriteLine($"Lab {x + 1} score : {labScores[x]}");
    }
    Console.ReadLine();

    // Loop to show individual quiz scores
    for (int x = 0; x < quizScores.Length; x++)
    {
        Console.WriteLine($"Quiz {x + 1} score : {quizScores[x]}");
    }
    Console.ReadLine();

    // *****************************************************************************************************************************

    double examAverage = (double)examTotal / examScores.Length;
    double labAverage = (double)labTotal / labScores.Length;
    double quizAverage = (double)quizTotal / quizScores.Length;

    double weightedExam = examAverage * 0.45;
    double weightedLab = labAverage * 0.35;
    double weightedQuiz = quizAverage * 0.2;

    Console.WriteLine($"Exam scores average : {examAverage}");
    Console.WriteLine($"Lab scores average : {labAverage}");
    Console.WriteLine($"Quiz scores average : {quizAverage}");

    double finalAverage = weightedExam + weightedLab + weightedQuiz;

    Console.WriteLine($"Your overall grade is {finalAverage}");

    Console.WriteLine("Would you like to check another student's grades? (Y/N)");
    runAgain = char.Parse(Console.ReadLine().ToLower());
}

transition();
Console.WriteLine("Program has ended. Thank you.");

