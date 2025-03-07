#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
    system("clear");
    double newCarPrice = 25000;
    double depreciationValue = 0.15;
    double currentPrice = 0;

    cout << "Original Value: " << newCarPrice << endl
         << endl;
    cout << "Depreciation rate: " << depreciationValue * 100 << "%" << endl;
    currentPrice = newCarPrice;

    cout << "Value after year: " << endl;

    for (int i = 1; i < 6; i++)
    {

        currentPrice = currentPrice - (currentPrice * depreciationValue);

        cout << i << "  " << ceil(currentPrice) << endl;
    }

    return 0;
}