#include <iostream>
#include <iomanip>
using namespace std;

// Function to clear the screen based on OS
void clearScreen()
{
#ifdef _WIN32
    system("CLS");
#else
    system("clear");
#endif
}

int main()
{
    clearScreen();

    // display my info
    cout << "\n\t\t****************************************" << endl;
    cout << "\t\t*                                      *" << endl;
    cout << "\t\t*         Square-Cube-Program          *" << endl;
    cout << "\t\t*                                      *" << endl;
    cout << "\t\t****************************************" << endl;

    // declare variables

    int userNum = 0;
    char runAgain = ' ';

    // output input

    do
    {
        cout << "\nPlease enter a number to square, cube, and raise to the 4th power : ";
        cin >> userNum;

        // process

        cout << "Number     Square    Cube      4th Power" << endl;
        cout << "--------   ------    ------    -----------" << endl;

        for (int i = 0; i < 10; i++)
        {

            cout << left << setw(11) << userNum << setw(10) << pow(userNum, 2.0) << setw(10) << pow(userNum, 3.0) << setw(15) << pow(userNum, 4.0) << endl;

            userNum += 5;
        }

        cout << "Would you like to continue (Y or N)? ";
        cin >> runAgain;
        runAgain = toupper(runAgain);

        clearScreen();
    } while (runAgain != 'N');

    // final output
}