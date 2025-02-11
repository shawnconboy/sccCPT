#include <iostream>
using namespace std;

int main()
{
    // declare variables
    char membershipType = ' ';
    double monthlyPurchase = 0.0;
    double rewardPoints = 0.0;

    // output input
    cout << "Hello. Please enter your membership type (A, B, or C): ";
    cin >> membershipType;
    membershipType = toupper(membershipType);
    cout << membershipType << endl;

    // process
    if (membershipType != 'A' && membershipType != 'B' && membershipType != 'C')
    {
        cout << "Invalid entry." << endl;
        return 1;
    }

    // output input
    cout << "Please enter your monthly purchase amount: ";
    cin >> monthlyPurchase;

    // process
    if (membershipType == 'A')
    {
        if (monthlyPurchase >= 150)
        {
            rewardPoints = monthlyPurchase * 0.1;
        }
        else if (monthlyPurchase >= 75)
        {
            rewardPoints = monthlyPurchase * 0.075;
        }
        else
        {
            rewardPoints = monthlyPurchase * 0.05;
        }
    }
    else if (membershipType == 'B')
    {
        if (monthlyPurchase >= 150)
        {
            rewardPoints = monthlyPurchase * 0.06;
        }
        else
        {
            rewardPoints = monthlyPurchase * 0.13;
        }
    }
    else if (membershipType == 'C')
    {
        if (monthlyPurchase >= 200)
        {
            rewardPoints = monthlyPurchase * 0.15;
        }
        else
        {
            rewardPoints = monthlyPurchase * 0.04;
        }
    }

    // output
    cout << "You have " << rewardPoints << " reward points!" << endl;

    return 0;
}
