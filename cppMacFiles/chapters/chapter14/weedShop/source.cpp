#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>

using namespace std;

int main()
{
    system("clear");

    // variables
    string strainName = "";
    string type = "";
    string thcPercent = "";
    string price = "";

    ifstream inInventory;

    inInventory.open("inventory.txt");

    if (inInventory.is_open())
    {
        cout << "inventory.txt opened successfully" << endl;
    }
    else
    {
        cout << "inventory.txt failed to open successfully" << endl;
    }

    cout << "Press Enter to continue...";
    cin.get();

    system("clear");

    cout << endl
         << "Weed Shop Inventory" << endl;
    cout << "---------------------------------------------------------------" << endl;

    // headers
    cout << left << setw(25) << "Strain"
         << setw(15) << "Type"
         << setw(12) << "THC %"
         << setw(10) << "Price" << endl;

    cout << "---------------------------------------------------------------" << endl;

    // data rows
    while (getline(inInventory, strainName, '#') &&
           getline(inInventory, type, '#') &&
           getline(inInventory, thcPercent, '#') &&
           getline(inInventory, price))
    {
        cout << left << setw(25) << strainName
             << setw(15) << type
             << setw(12) << (thcPercent + "%")
             << "$" << fixed << setprecision(2) << setw(9) << price << endl;
    }

    cout << "\n\n";

    inInventory.close();
    if (!inInventory.is_open())
    {
        cout << "inventory.txt closed successfully" << endl;
    }
    else
    {
        cout << "inventory.txt failed to close successfully" << endl;
    }

    return 0;
}
