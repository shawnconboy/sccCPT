#include <iostream>
using namespace std;

int main()
{

    // Declare_variables
    double grossPay = 0;
    double yearsWorked = 0;
    double lowYears = 0.01;
    double highYears = 0.02;

    // Input/Output
    cout << "Please enter your gross pay per year: ";
    cin >> grossPay;

    cout << "Please enter the number of years you worked: ";
    cin >> yearsWorked;
    // Process
    if (yearsWorked < 1 || yearsWorked > 82)
    {
        cout << "Error";
    }
    else if (yearsWorked <= 5)
    {

        cout << "Your Bonus is: " << (lowYears * grossPay) << "(Low Years)" << endl;
    }
    else
    {

        cout << "Your Bonus is: " << (highYears * grossPay) << "(High Years)" << endl;
    }

    // Output
    cout << "T H A N K   Y O U" << endl;
    return 0;
}
