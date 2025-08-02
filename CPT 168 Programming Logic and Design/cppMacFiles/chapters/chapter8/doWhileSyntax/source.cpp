#include <iostream>
using namespace std;

int main()
{
    system("clear");

    char another = ' ';
    double number, sum;

    cout << "Enter a number? Y / N : ";
    cin >> another;

    do // begin loop
    {
        cout << "Number : ";
        cin >> number;
        sum += number;
        cout << "Enter a number? Y / N : ";
        cin >> another;
    } while (toupper(another) == 'Y');

    cout << "Sum = " << sum << endl;
}