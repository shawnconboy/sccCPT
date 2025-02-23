#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
    // Display header
    cout << "*****************************************" << endl;
    cout << "*                                       *" << endl;
    cout << "*           GPA Calculator              *" << endl;
    cout << "*                                       *" << endl;
    cout << "*****************************************" << endl;

    // Declare variables
    char gender;
    double gpa;
    double gpaAll = 0, gpaMale = 0, gpaFemale = 0;
    int totalStudents = 0, maleCount = 0, femaleCount = 0;

    // Input loop
    while (true)
    {
        cout << "Enter gender (M or F, or '.' to stop): ";
        cin >> gender;
        gender = toupper(gender);

        if (gender == '.') // Exit condition
            break;

        if (gender == 'M' || gender == 'F')
        {
            cout << "Enter GPA (0.0 - 4.0): ";
            cin >> gpa;

            // Validate GPA
            if (gpa < 0.0 && gpa > 4.0)
            {
                cout << "Invalid GPA. Must be between 0.0 and 4.0." << endl;
                continue; // Restart loop without counting invalid input
            }

            // Process valid inputs
            totalStudents++;
            gpaAll += gpa;

            if (gender == 'M')
            {
                maleCount++;
                gpaMale += gpa;
            }
            else
            {
                femaleCount++;
                gpaFemale += gpa;
            }
        }
        else
        {
            cout << "Invalid entry. Please enter M or F." << endl;
        }
    }

    // Final output
    cout << fixed << setprecision(2);
    cout << "\n********** GPA REPORT **********\n";
    if (totalStudents > 0)
        cout << "Overall Average GPA: " << (gpaAll / totalStudents) << endl;
    else
        cout << "No GPA data entered.\n";

    if (maleCount > 0)
        cout << "Male Average GPA: " << (gpaMale / maleCount) << endl;
    else
        cout << "No male GPA data entered.\n";

    if (femaleCount > 0)
        cout << "Female Average GPA: " << (gpaFemale / femaleCount) << endl;
    else
        cout << "No female GPA data entered.\n";

    return 0;
}
