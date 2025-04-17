#include <iostream>
#include <string>
#include <fstream>

using namespace std;

int main()
{

    system("clear");

    ofstream outPayroll;

    outPayroll.open("payroll.txt", ios::app);

    if (outPayroll.is_open())
    {
        cout << "payroll.txt opened successfully." << endl;
    }
    else
    {
        cout << "payroll.txt not found." << endl;
    }

    return 0;
}