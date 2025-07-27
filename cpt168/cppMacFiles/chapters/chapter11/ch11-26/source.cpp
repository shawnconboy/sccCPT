#include <iostream>
#include <string>

using namespace std;

int main()
{

    system("clear");

    string months[12] = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

    int days[12] = {31, 28, 31,
                    30, 31, 30,
                    31, 31, 30,
                    31, 30, 31};

    int userInput = 0;
    int year = 0;

    cout << "Please enter month(MM) : ";
    cin >> userInput;

    if (userInput > 0 && userInput < 13)
    {
        if (userInput == 2)
        {
            cout << "Please enter the current year: ";
            cin >> year;

            if (year % 4 == 0)
            {
                cout << year << " is a leap year." << endl;
            }
            else
            {
                cout << year << " is not a leap year." << endl;
            }
        }
        cout << "Month entered: " << months[userInput - 1] << endl;
        cout << "Number of days: " << days[userInput - 1] << endl;
    }
    else
    {
        cout << "Invalid number entered." << endl;
    }

    return 0;
}