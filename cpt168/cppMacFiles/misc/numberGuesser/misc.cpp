#include <iostream>
#include <iomanip>
using namespace std;

int main()
{

    cout << "******************************" << endl;

    int num = 0;
    char member = 'y';

    cout << "Enter a number";
    cin >> num;

    if (num == 0)
    {
        member = 'Y';
        cout << member;
    }

    return 0;
}