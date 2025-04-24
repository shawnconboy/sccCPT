#include <iostream>
#include <string>
#include <fstream>
#include <iomanip>

using namespace std;

// Write a program that  displays the contents of the file in three columns titled “Name”, “Quantity”, and  “Price”.
// The program should also display a fourth column that contains the result of multiplying each item’s quantity by its price.
// Use “Value” as the column’s title. (Hint: You can align the columns using '\t', which is the escape sequence for the Tab key.)
// In addition, the program should calculate and display the total value of the items in inventory.
// Display the price, value, and total value with two decimal places.
// Save and then run the program.

// make the file
// open the file
// check if it is open

int main()
{

    system("clear");

    // variables
    const int numItems = 10;
    string item = "";
    int quantity = 0;
    double price = 0.0;
    double totalPrices = quantity * price;
    double totalInventory = 0.0;

    // fstream declarations
    ifstream inItems;
    ofstream outReport;

    inItems.open("items.txt");

    if (inItems.is_open())
    {
        cout << "items.txt opened successfully" << endl;
    }
    else
    {
        cout << "items.txt failed to open" << endl;
        return 0;
    }

    cout << endl;

    cout << left << setw(20) << "Item"
         << setw(8) << "Qty"
         << setw(8) << "Price" << endl;

    while (inItems.eof() == false)
    {
        getline(inItems, item, '#');
        inItems >> quantity;
        inItems.ignore();
        inItems >> price;
        inItems.ignore();

        cout << left << setw(20) << item
             << setw(8) << quantity
             << setw(8) << price << endl;
    }

    system("pause");
    return 0;
}