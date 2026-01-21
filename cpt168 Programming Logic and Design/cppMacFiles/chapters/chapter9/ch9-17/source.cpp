#include <iostream>
using namespace std;

int main()
{
    system("clear");

    int hoursWorked = 0;
    int hourlyRate = 0;
    double gross = 0;
    char runAgain = ' ';

    do
    {
        cout << "Please enter hours worked : ";
        cin >> hoursWorked;

        cout << "Please enter hourly rate : ";
        cin >> hourlyRate;

        if (hoursWorked <= 37)
        {
            gross = hoursWorked * hourlyRate;
        }
        else if (hoursWorked <= 50) // Overtime (1.5x)
        {
            gross = (37 * hourlyRate) + ((hoursWorked - 37) * hourlyRate * 1.5);
        }
        else // Double time (2x)
        {
            gross = (37 * hourlyRate) + (13 * hourlyRate * 1.5) + ((hoursWorked - 50) * hourlyRate * 2);
        }

        cout << "Gross pay : $" << gross << endl;

        cout << "Enter another employee (Y or N) : ";
        cin >> runAgain;
    } while (toupper(runAgain) == 'Y');

    cout << "Program ended" << endl;
    return 0;
}