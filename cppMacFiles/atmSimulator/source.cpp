#include <iostream>
#include <iomanip>
#include <cstdlib> // Required for system("clear")
using namespace std;

int main()
{
    int userPin = 0;
    int password = 0; // 0000 is treated as 0 in int
    int userChoice = 0;

    double startingBalance = 1200;
    double balanceToBeAdded = 0;
    double totalBalance = startingBalance; // Initialize with starting balance

    cout << "***************************************" << endl;
    cout << "*                                     *" << endl;
    cout << "*           ATM Simulator             *" << endl;
    cout << "*                                     *" << endl;
    cout << "***************************************" << endl;

    cout << "Hello. Please enter your pin : ";
    cin >> userPin;

    if (userPin != password)
    {
        cout << "Wrong password. Access Denied." << endl;
        return 0; // Exit program if the pin is incorrect
    }

    cout << "Welcome to your checking account" << endl;

    while (true) // Main menu loop
    {
        // Clear the screen before showing the menu
        system("clear"); // Use system("cls") for Windows

        cout << "***************************************" << endl;
        cout << "*           ATM Simulator             *" << endl;
        cout << "***************************************" << endl;
        cout << "Total Balance: $" << fixed << setprecision(2) << totalBalance << endl;
        cout << "\nPlease pick an option." << endl;
        cout << "1 - Check Balance" << endl;
        cout << "2 - Make Deposit" << endl;
        cout << "3 - Make Withdrawal" << endl;
        cout << "4 - Exit" << endl;
        cout << "Enter your choice: ";
        cin >> userChoice;

        if (userChoice == 1) // Show balance
        {
            cout << "Total Balance: $" << fixed << setprecision(2) << totalBalance << endl;
            cout << "Press Enter to continue...";
            cin.ignore();
            cin.get(); // Pause until user presses Enter
        }
        else if (userChoice == 2) // Deposit money
        {
            cout << "Enter deposit amount: $";
            cin >> balanceToBeAdded;
            if (balanceToBeAdded > 0)
            {
                totalBalance += balanceToBeAdded;
                cout << "Deposit successful!" << endl;
            }
            else
            {
                cout << "Invalid deposit amount." << endl;
            }
            cout << "Press Enter to continue...";
            cin.ignore();
            cin.get();
        }
        else if (userChoice == 3) // Withdraw money
        {
            double withdrawAmount;
            cout << "Enter withdrawal amount: $";
            cin >> withdrawAmount;
            if (withdrawAmount > 0 && withdrawAmount <= totalBalance)
            {
                totalBalance -= withdrawAmount;
                cout << "Withdrawal successful!" << endl;
            }
            else
            {
                cout << "Invalid withdrawal amount or insufficient funds." << endl;
            }
            cout << "Press Enter to continue...";
            cin.ignore();
            cin.get();
        }
        else if (userChoice == 4) // Exit ATM
        {
            cout << "Thank you for using the ATM. Goodbye!" << endl;
            break; // Exit loop and end program
        }
        else
        {
            cout << "Invalid entry. Please try again." << endl;
            cout << "Press Enter to continue...";
            cin.ignore();
            cin.get();
        }
    }
    return 0;
}
