#include <iostream>
using namespace std;

int main()
{

    system("clear");

    char membership = ' ';
    int age = 0;
    double seminarFee = 0.0;

    cout << "\n\nPlease enter your member status : ";
    cin >> membership;
    membership = toupper(membership);

    if (membership != 'M' && membership != 'N')
    {
        cout << "Invalid entry";
    }
    else
    {
        cout << "Please enter your age : ";
        cin >> age;

        if (membership == 'M')
        {
            if (age >= 65)
            {
                seminarFee = 5;
            }
            else
            {
                seminarFee = 10;
            }
        }
        else
        {
            if (age >= 65)
            {
                seminarFee = 15;
            }
            else
            {
                seminarFee = 20;
            }
        }
    }

    cout << "Your seminar fee is $ " << seminarFee << endl
         << endl;
    return 0;
}