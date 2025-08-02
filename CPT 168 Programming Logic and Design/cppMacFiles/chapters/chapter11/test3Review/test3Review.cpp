#include <iostream>
using namespace std;

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

	cout << "\t\t*******************************" << endl;
	cout << "\t\t*       Test 2 Review         *" << endl;
	cout << "\t\t*******************************" << endl;

	// declareVariables

	char userChoice = 'Y';
	char type[5] = {'A', 'B', 'C', 'D', 'E'};
	int fees[5] = {100, 110, 125, 150, 200};
	char userInput = ' ';
	double tax = 0.1;

	while (toupper(userChoice) == 'Y')
	{
		clearScreen();
		cout << "\t\tMembership Fees Chart" << endl
			 << endl;
		for (int i = 0; i < 5; i++)
		{
			cout << "\t\t" << type[i] << " - " << fees[i] << endl;
		}

		cout << "Which membership type would you like to purchase? : ";
		cin >> userInput;

		for (int i = 0; i < 5; i++)
		{
			if (toupper(userInput) == type[i])
			{
				cout << "Membership : " << type[i] << " - " << "Cost : " << (fees[i] * tax) + fees[i] << endl;
			}
		}

		cout << "Would you like to choose another membership type?";
		cin >> userChoice;
	}

	cout << "Program ended." << endl;
	return 0;
}