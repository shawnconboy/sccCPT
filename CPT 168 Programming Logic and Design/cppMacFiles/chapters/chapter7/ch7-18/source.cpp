#include <iostream>
#include <iomanip>
using namespace std;

/*

Create a program that displays the weekly gross pay for any number of employees. The user will input the number of hours the employee worked and the employee’s hourly rate. Employees working more than 40 hours receive time and one-half for the hours worked over 40. If necessary, create a new project named Introductory18 Project, and save it in the Cpp8\Chap07 folder. Enter the C++ instructions into a source file named Introductory18.cpp. Also enter appropriate comments and any additional instructions required by the compiler. Save, run, and test the program.

*/

int main()
{
    system("color f0");

    // declare variables

    int hoursWorked = 0;
    double hourlyRate = 0.0;
    double checkAmount = 0.0;
    int overtimeHours = 0;

    // output input

    cout << "Hello. Please enter number of hours worked : ";
    cin >> hoursWorked;

    cout << "Please enter hourly rate : ";
    cin >> hourlyRate;

    // process

    while (hoursWorked > 0)
    {
        if (hoursWorked > 40)
        {
            cout << "You worked overtime. Let's calculate your pay.\n";
            overtimeHours = hoursWorked - 40;
            checkAmount = (hoursWorked - overtimeHours) * hourlyRate;
            checkAmount = checkAmount + (overtimeHours * 1.5);
            cout << "Your total check amount is : " << checkAmount << endl;

            cout << "Please enter number of hours worked for next employee : ";
            cin >> hoursWorked;
            cout << endl;

            cout << "Please enter hourly rate : ";
            cin >> hourlyRate;
            cout << endl;
        }
        else
        {
            checkAmount = hoursWorked * hourlyRate;
            cout << "Your total check amount is : " << checkAmount << endl;

            cout << "Please enter number of hours worked for next employee : ";
            cin >> hoursWorked;
            cout << endl;

            cout << "Please enter hourly rate : ";
            cin >> hourlyRate;
            cout << endl;
        }
    }

    // final output

    system("pause");
    return 0;
}