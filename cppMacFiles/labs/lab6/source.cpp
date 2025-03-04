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

    cout << "Please enter number of years worked : ";
    cin >> yearsWorked;

    if (yearsWorked < 0 || yearsWorked > 99)
    {
        cout << "Invalid entry." << endl;
    }
    else
    {
        while (yearsWorked != -1)
        {

            cout << "Please enter yearly salary : ";
            cin >> salary;

            if (yearsWorked < 6)
            {
                bonusRate = 0.01;
            }
            else
            {
                bonusRate = 0.02;
            }

            bonus = salary * bonusRate;

            cout << "Your bonus is $" << bonus << endl;

            cout << "Please enter number of years worked : ";
            cin >> yearsWorked;
        }
    }

    cout << "\n\t\tT H A N K Y O U" << endl
         << endl;
    return 0;
}
