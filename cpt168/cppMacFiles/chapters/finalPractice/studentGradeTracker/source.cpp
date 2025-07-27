#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>
#include <sstream>

using namespace std;

int main()
{
    system("clear");

    // Variables
    int grades[5] = {};
    int gradeTotal = 0;
    double gradesAverage = 0.0;
    string name = "";
    char userChoice = ' ';

    // fstream declarations
    ofstream outGrades;
    ifstream inGrades;

    outGrades.open("grades.txt", ios::app);

    if (outGrades.is_open())
    {
        cout << "grades.txt opened successfully" << endl;
    }
    else
    {
        cout << "grades.txt failed to open" << endl;
    }

    cout << "____________________________________________________________________" << endl
         << endl;

    // Input Loop
    cout << "Would you like to enter a student's grade? (Y/N): ";
    cin >> userChoice;
    cin.ignore(); // Flush newline before getline

    while (toupper(userChoice) == 'Y')
    {
        gradeTotal = 0; // Reset for new student

        cout << "Please enter student name: ";
        getline(cin, name);

        for (int i = 0; i < 5; i++)
        {
            cout << "Enter test " << i + 1 << " grade: ";
            cin >> grades[i];
            gradeTotal += grades[i];
        }

        gradesAverage = static_cast<double>(gradeTotal) / 5.0;

        // Write to file
        outGrades << name;
        for (int i = 0; i < 5; i++)
        {
            outGrades << '#' << grades[i];
        }
        outGrades << '#' << fixed << setprecision(2) << gradesAverage << endl;

        // Output to console
        cout << endl;
        cout << "Student: " << name << "\tAverage: " << fixed << setprecision(2) << gradesAverage << endl
             << endl;

        cout << "Enter another student's grade? (Y/N): ";
        cin >> userChoice;
        cin.ignore(); // Flush newline before next getline
    }

    outGrades.close();
    cout << endl;

    if (!outGrades.is_open())
    {
        cout << "grades.txt closed successfully" << endl;
    }
    else
    {
        cout << "grades.txt failed to close" << endl;
    }

    cout << "____________________________________________________________________" << endl
         << endl;

    // Reading the file back and displaying nicely
    inGrades.open("grades.txt");

    if (inGrades.is_open())
    {
        cout << "grades.txt opened successfully" << endl;
    }
    else
    {
        cout << "grades.txt failed to open" << endl;
    }

    cout << "____________________________________________________________________" << endl
         << endl;

    cout << left << setw(25) << "Student Name" << setw(10) << "Average" << "Grade" << endl;
    cout << "____________________________________________________________________" << endl
         << endl;

    string line;
    while (getline(inGrades, line))
    {
        stringstream ss(line);
        string field;
        string fields[7];
        int i = 0;

        // Split by '#' into fields array
        while (getline(ss, field, '#') && i < 7)
        {
            fields[i++] = field;
        }

        // Convert average to double
        double avg = stod(fields[6]);
        char letter;

        if (avg >= 90)
            letter = 'A';
        else if (avg >= 80)
            letter = 'B';
        else if (avg >= 70)
            letter = 'C';
        else if (avg >= 60)
            letter = 'D';
        else
            letter = 'F';

        // Print name, average, and letter grade
        cout << left << setw(25) << fields[0]
             << setw(10) << fields[6]
             << letter << endl;
    }

    inGrades.close();

    return 0;
}
