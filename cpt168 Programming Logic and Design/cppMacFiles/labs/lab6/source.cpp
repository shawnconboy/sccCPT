#include <iostream>
#include <iomanip>
using namespace std;

int main()
{

    system("clear");
    // display info

    cout << "\t*******************************" << endl;
    cout << "\t*                             *" << endl;
    cout << "\t*         Shawn Conboy        *" << endl;
    cout << "\t*     Christmas Bonus Loop    *" << endl;
    cout << "\t*         CPT 168 A01H        *" << endl;
    cout << "\t*                             *" << endl;
    cout << "\t*******************************" << endl
         << endl;

    // declare variables

    int salary = 0;
    int yearsWorked = 0;
    double bonusRate = 0.0;
    double bonus = 0.0;

    // output input

    cout << "Hello. Please enter number of years worked (-1 to stop) : ";
    cin >> yearsWorked;

    while (yearsWorked != -1)
    {
        if (yearsWorked < 0 || yearsWorked > 98)
        {
            cout << "\n- - - - > T H A N K   Y O U < - - - -" << endl
                 << endl;
            return 0;
        }
        else if (yearsWorked < 6)
        {
            bonusRate = 0.01;
        }
        else
        {
            bonusRate = 0.02;
        }

        cout << "Please enter yearly salary : ";
        cin >> salary;

        if (salary < 0)
        {
            cout << "Invalid entry. Please try again." << endl;
        }
        else
        {
            bonus = salary * bonusRate;

            cout << "Your bonus is $" << fixed << setprecision(2) << bonus << endl
                 << endl;
        }

        cout << "Please enter number of years worked (-1 to stop) : ";
        cin >> yearsWorked;
    }

    cout << "\n- - - - > T H A N K   Y O U < - - - -" << endl
         << endl;
    return 0;
}
