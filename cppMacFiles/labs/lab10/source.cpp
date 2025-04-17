#include <iostream>
#include <string>
#include <fstream>

using namespace std;

int main()
{

    system("clear");

    // *************************************************

    // ofstream outPayroll;

    // outPayroll.open("payroll.txt", ios::app);

    // if (outPayroll.is_open())
    // {
    //     cout << "payroll.txt opened successfully." << endl;
    // }
    // else
    // {
    //     cout << "payroll.txt not found." << endl;
    // }

    // *************************************************

    // ofstream outJan;

    // outJan.open("janSales.txt", ios::app);

    // if (outJan.is_open())
    // {
    //     cout << "Success" << endl;
    // }
    // else
    // {
    //     cout << "Failed to open" << endl;
    // }

    // *************************************************

    // ifstream inInventory;

    // inInventory.open("inventory.txt");

    // if (inInventory.is_open())
    // {
    //     cout << "success" << endl;
    // }
    // else
    // {
    //     cout << "Failed" << endl;
    // }

    // *************************************************

    // ofstream outSales;

    // outSales.open("firstQtr.txt", ios::app);

    // if (outSales.is_open())
    // {
    //     cout << "Success" << endl;
    // }
    // else
    // {
    //     cout << "Failure" << endl;
    // }

    // *************************************************

    ofstream outFeb;

    outFeb.open("febSales.txt");

    if (outFeb.is_open())
    {
        cout << "success\n";
    }
    else
    {
        cout << "failure\n";
    }

    return 0;
}