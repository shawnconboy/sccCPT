#include <iostream>
using namespace std;

int main()
{
    system("clear");

    // display information

    cout << "\n**********************************" << endl;
    cout << "*                                *" << endl;
    cout << "*      Multiplication Tables     *" << endl;
    cout << "*                                *" << endl;
    cout << "**********************************\n"
         << endl;

    // declare variables

    int num = 0;

    // output input

    cout << "Enter a number to generate it's multiplication table : ";
    cin >> num;

    cout << "\nMultiplication table for " << num << endl
         << endl;
    // process

    while (num != -1000)
    {
        for (int i = 1; i < 11; i++)
        {
            cout << num << " x " << i << " = " << num * i << endl;
        }

        cout << "\nDo you want to generate another table? : ";
        cin >> num;
    }

    if (num == -1000)
    {
        cout << "You've exited the program." << endl;
    }

    // final output
    cout << "Goodbye." << endl;
    return 0;
}