#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

// int getProduct(int num1, double num2);

int main()
{
    system("clear");
    // // 5 to the 2nd power
    // cout << pow(5.0, 2) << endl;

    // // 2 to the 4th power
    // cout << pow(2, 4) << endl;

    // cout << sqrt(25) << endl;
    // cout << sqrt(400) << endl;

    // cout << rand() << endl;

    // cout << add(1, 2) << endl;

    // cout << getGrossPay(20, 40) << endl;
    // cout << getGrossPay(35, 40) << endl;
    // cout << getGrossPay(45, 40) << endl;

    // cout << getProduct(10, 4) << endl;

    // double answer = pow(3, 5);

    // cout << answer << endl;

    srand(time(0));

    cout << 50 + rand() % (100 - 50 + 1) << " : 50 - 100" << endl;
    cout << (rand() % 100) + 1 << " : 1-100" << endl;

    double num = 0;

    cout << "Enter a number to square : ";
    cin >> num;

    double sqRoot = sqrt(num);

    while (num != -1)
    {
        cout << "Square Root : " << sqRoot << endl;

        cout << "Enter a number to square : ";
        cin >> num;
        sqRoot = sqrt(num);
    }

    return 0;
}

// int add(int x, int y)
// {
//     return x + y;
// }

// double getGrossPay(int hours, int hourlyRate)
// {
//     return hourlyRate * hours;
// }

// int getProduct(int num1, double num2)
// {
//     return num1 * num2;
// }