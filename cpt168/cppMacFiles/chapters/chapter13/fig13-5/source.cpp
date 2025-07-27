#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{

    system("clear");

    const double RATE = 0.12;
    string name = "";
    int price = 0;
    double premium = 0.0;
    string itemNum = "";

    cout << "Buyer's name: ";
    getline(cin, name);
    cout << "Purchase price: ";
    cin >> price;
    cin.ignore(100, '\n');
    cout << "Item Number: ";
    getline(cin, itemNum);

    premium = price * RATE;

    system("clear");

    cout << fixed << setprecision(2);
    cout << "********** Auction Summary **********" << endl;
    cout << "Buyer : " << name << endl;
    cout << "Item Number : " << itemNum << endl;
    cout << "Premium : $" << premium << endl;

    return 0;
}