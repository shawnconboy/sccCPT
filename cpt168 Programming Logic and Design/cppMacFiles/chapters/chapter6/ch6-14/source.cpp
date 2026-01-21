#include <iostream>
#include <iomanip>
using namespace std;

int main()
{

    system("clear");

    double quarterlySales = 0.0;
    double commission = 0.0;

    cout << "Please enter quarterly sales : ";
    cin >> quarterlySales;

    if (quarterlySales < 0)
    {
        cout << "Invalid entry. Sales must be greater than 0." << endl
             << endl;
    }
    else
    {
        if (quarterlySales <= 20000)
        {
            commission = quarterlySales * 0.05;
        }
        else if (quarterlySales <= 50000)
        {
            commission = (quarterlySales * 0.07) + 1000;
        }
        else
        {
            commission = (quarterlySales * 0.10) + 3100;
        }

        cout << "Total commission : $" << commission << endl
             << endl;
    }

    return 0;
}