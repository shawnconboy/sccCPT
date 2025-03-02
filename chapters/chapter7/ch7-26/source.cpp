#include <iostream>
using namespace std;

int main()
{
    system("clear");

    // display info

    cout << "************************" << endl;
    cout << "*                      *" << endl;
    cout << "*   Fibonacci Display  *" << endl;
    cout << "*                      *" << endl;
    cout << "************************\n"
         << endl;

    // declare variables
    int num1 = 1;
    int num2 = 1;
    int next = 0;
    // output input

    cout << num1 << ", " << num2;

    // process
    for (int i = 3; i < 11; i++)
    {
        next = num1 + num2;
        cout << ", " << next;
        num1 = num2;
        num2 = next;
    }
    // final output
    cout << endl
         << endl;
    return 0;
}