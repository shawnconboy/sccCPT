#include <iostream>
using namespace std;

int main()
{
    char enterGrades = ' ';

    do
    {
        int testGrade = 0;
        int totalTest = 0;
        char studentGrade = ' ';
        double gradeAverage = 0.0;

        cout << "Would you like to enter a student's grades? (Y or N): ";
        cin >> enterGrades;
        enterGrades = toupper(enterGrades);

        if (enterGrades != 'Y')
        {
            break; // Exit if user doesn't want to continue
        }

        // Clear the screen before collecting new grades
        system("clear"); // Use "cls" on Windows

        for (int i = 0; i < 4; i++)
        {
            cout << "Please enter test grade: ";
            cin >> testGrade;
            totalTest += testGrade;
        }

        gradeAverage = static_cast<double>(totalTest) / 4;

        if (gradeAverage < 60)
        {
            studentGrade = 'F';
        }
        else if (gradeAverage < 70)
        {
            studentGrade = 'D';
        }
        else if (gradeAverage < 85)
        {
            studentGrade = 'C';
        }
        else if (gradeAverage < 93)
        {
            studentGrade = 'B';
        }
        else
        {
            studentGrade = 'A';
        }

        cout << "\nStudent's Grade: " << studentGrade << endl
             << endl;

        // Pause so the user can see the result before clearing
        cout << "Press Enter to continue...";
        cin.ignore();
        cin.get();

        system("clear"); // Clear screen before next student's entry

    } while (enterGrades == 'Y');

    cout << "Program ended." << endl;
    return 0;
}
