#include <iostream>
using namespace std;

int main()
{

    // declare variables
    int num = 0;
    // output input
    cout << "Hello. Please enter a number : ";
    cin >> num;
    // process
    for (int i = 1; i < 11; i += 1)
    {
        cout << num << " * " << i << " = " << num * i << endl;
    }
    // final output
}