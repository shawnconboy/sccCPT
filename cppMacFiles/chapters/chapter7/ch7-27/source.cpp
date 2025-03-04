#include <iostream>
using namespace std;

int main()
{
    system("clear");

    // display info

    cout << "******************************" << endl;
    cout << "*                            *" << endl;
    cout << "* Display Average Commission *" << endl;
    cout << "*                            *" << endl;
    cout << "******************************" << endl;

    // declare variables
    double rate = 0.2;
    double sales = 0.0;
    double commission = 0.0;
    double salesCounter = 0.0;
    double salesAverage = 0.0;
    double salesAccumulator = 0.0;

    // output input

    cout
        << "First salesperson's sales (-1 to stop) : ";
    cin >> sales;

    // process

    while (sales != -1)
    {
        if (sales < -1)
        {
            cout << "Invalid entry." << endl;
        }
        else
        {
            commission = sales * rate;
            salesCounter += 1;
            salesAccumulator = sales + salesAccumulator;

            cout
                << "Your commission is : $" << commission << endl;

            cout << "Next salesperson's sales (-1 to stop) : ";
            cin >> sales;
        }
    }

    // final output
    cout << "Total sales amounts entered : " << salesCounter << endl;

    salesAverage = salesAccumulator / salesCounter;

    cout << "Sales average : $" << salesAverage << endl;

    return 0;
}