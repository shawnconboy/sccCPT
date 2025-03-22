#include <iostream>
using namespace std;

int main()
{

    system("clear");

    double mathNumbers[8] = {4, 9, 16, 25, 36, 49, 64, 81};
    int userNumber = 0;
    char userChoice = 'Y';

    while (toupper(userChoice) == 'Y')
    {

        cout << "Please enter a number : ";
        cin >> userNumber;

        for (int i = 0; i < 8; i++)
        {
            if (userNumber == i)
            {
                cout << "The square root of " << mathNumbers[i - 1] << " is : " << sqrt(mathNumbers[i - 1]) << endl;
            }
        }

        cout << "Would you like to enter another number? : ";
        cin >> userChoice;
        cout << endl;
    }

    return 0;
}