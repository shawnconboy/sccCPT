#include <iostream>
#include <string>
#include <fstream>

using namespace std;

int main()
{

    ofstream outFeb;

    outFeb.open("febSales.txt");

    if (outFeb.is_open())
    {
        cout << "febSales.txt opened successfully\n";
    }
    else
    {
        cout << "febSales.txt failed to open\n";
    }

    return 0;
}