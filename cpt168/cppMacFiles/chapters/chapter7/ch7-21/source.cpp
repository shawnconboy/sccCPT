#include <iostream>
#include <iomanip>

using namespace std;

int main()
{

    // declare variables
    double originalPrice = 0.0;
    double discountPercentage = 0.0;
    double discountApplied = 0.0;
    double totalCost = 0;

    // output input
    cout << "Hello. Please enter item price : ";
    cin >> originalPrice;

    for (double i = 0.1; i <= 0.4; i += 0.05)
    {

        discountPercentage = i;
        discountApplied = originalPrice * discountPercentage;
        totalCost = originalPrice - discountApplied;

        cout << "\n"
             << discountPercentage << " percent off \n";
        cout << "Discounted Price : " << totalCost << endl
             << endl;
    }

    return 0;
}