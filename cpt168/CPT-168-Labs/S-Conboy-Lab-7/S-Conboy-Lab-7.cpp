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

	system("color f0");

	// declare variables

	int userNum = 0;
	char runAgain = ' ';

	// output input

	do
	{
		clearScreen();

		// display my info
		cout << "\n\t\t****************************************" << endl;
		cout << "\t\t*                                      *" << endl;
		cout << "\t\t*            Shawn Conboy              *" << endl;
		cout << "\t\t*            CPT 168 A01H              *" << endl;
		cout << "\t\t*               Lab 7                  *" << endl;
		cout << "\t\t*         Square-Cube-Program          *" << endl;
		cout << "\t\t*                                      *" << endl;
		cout << "\t\t****************************************" << endl;

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

		cout << "\nWould you like to continue (Y or N)? ";
		cin >> runAgain;
		runAgain = toupper(runAgain);

	} while (runAgain != 'N');

	cout << "\n- - - > T H A N K   Y O U < - - -" << endl
		<< endl;

	// final output
	system("pause");
	return 0;
}