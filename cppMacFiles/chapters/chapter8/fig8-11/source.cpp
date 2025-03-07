#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
    system("clear");
    double newCarPrice = 25000;
    double depreciationValue = 0.15;
    double currentPrice = 0;

    cout << "Original Value: $" << newCarPrice << endl
         << endl;

    for (double rate = 0.15; rate <= 0.25; rate += 0.05)
    {
        cout << "Depreciation rate: " << rate * 100 << "%" << endl;
        currentPrice = newCarPrice;
        cout << "Value after year: " << endl;

        for (int i = 1; i < 6; i++)
        {
            currentPrice = currentPrice - (currentPrice * rate);
            cout << i << "  " << ceil(currentPrice) << endl;
        }
        cout << endl;
    }
    return 0;
}