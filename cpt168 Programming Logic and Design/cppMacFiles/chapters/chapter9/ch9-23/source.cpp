#include <iostream>
#include <iomanip>
using namespace std;

void clearScreen();
void standardMembership();
void premiumMembership();

double total = 0;
int membershipType = 0;
double shippingPrice = 0;
double finalPrice = 0;

int main()
{
    clearScreen();

    cout << "Please enter membership type." << endl;
    cout << "1 -- Standard" << endl;
    cout << "2 -- Premium" << endl;
    cout << endl;
    cin >> membershipType;

    cout << "\nPlease enter total due : ";
    cin >> total;

    if (membershipType == 1)
    {
        standardMembership();
    }
    else if (membershipType == 2)
    {
        premiumMembership();
    }

    finalPrice = total + shippingPrice;

    cout << "Final Price is $" << fixed << setprecision(2) << finalPrice << endl;

    return 0;
}

// Function to clear the screen based on OS
void clearScreen()
{
#ifdef _WIN32
    system("CLS");
#else
    system("clear");
#endif
}

void standardMembership()
{
    if (total < 100)
    {
        shippingPrice = 12.99;
    }
    else
    {
        shippingPrice = 4.99;
    }
}

void premiumMembership()
{
    if (total < 49.99)
    {
        shippingPrice = 4.99;
    }
    else
    {
        shippingPrice = 0;
    }
}