#include <iostream>
using namespace std;

void clearScreen();

int main()
{

    system("color f0");

    // variables
    string actors[6] = {"Angelina Jolie", "Bradd Pitt", "Margot Robbit", "George Clooney", "Jennifer Lopez", "Jennifer Lawrence"};

    string info[6] = {"949-232-1124", "949-865-3492", "864-235-7569", "939-453-2288", "987-209-2132", "543-239-8745"};

    int userNumber = 0;
    char userChoice = 'Y';

    while (toupper(userChoice) == 'Y')
    {
        // display info
        clearScreen();

        cout << "\t\t*********************************" << endl;
        cout << "\t\t*                               *" << endl;
        cout << "\t\t*         Shawn Conboy          *" << endl;
        cout << "\t\t*      Lab 8 Actor's Info       *" << endl;
        cout << "\t\t*         CPT 168 A01H          *" << endl;
        cout << "\t\t*                               *" << endl;
        cout << "\t\t*********************************" << endl;

        // output-input
        cout << "Enter a number from 1 to 6 to display an actor's info : ";
        cin >> userNumber;

        if (userNumber >= 1 && userNumber <= 6)
        {
            cout << "\n\tYour actor's name is : " << actors[userNumber - 1] << endl;
            cout << "\tYour actor's number is : " << info[userNumber - 1] << endl;
        }
        else
        {
            cout << "\n\tInvalid number. Please enter a number between 1 and 6." << endl;
        }

        cout << "\nWould you like to continue (Y or N)? ";
        cin >> userChoice;
    }

    cout << "\n\t\tProgram has ended." << endl;
    cout << "\t\tT H A N K   Y O U"
         << endl;

    system("pause");

    return 0;
}

void clearScreen()
{
#ifdef _WIN32
    system("CLS");
#else
    system("clear");
#endif
}