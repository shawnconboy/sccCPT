#include <iostream>
#include <iomanip>
using namespace std;

int main()
{

    system("clear");

    int numRegistered = 0;
    double seminarFee = 0.0;
    double totalOwed = 0.0;

    cout << "\n\nPlease enter number of registrants : ";
    cin >> numRegistered;

    if (numRegistered <= 0)
    {
        cout << "Invalid entry.";
    }
    else
    {
        if (numRegistered <= 5)
        {
            totalOwed = numRegistered * 125;
        }
        else if (numRegistered <= 20)
        {
            totalOwed = numRegistered * 100;
        }
        else
        {
            totalOwed = numRegistered * 75;
        }
    }

    cout << "Your total owed is $" << totalOwed << endl
         << endl;

    return 0;
}