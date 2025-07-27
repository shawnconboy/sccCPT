#include <iostream>
using namespace std;

void clearScreen();
void getCentimeters();
void getInches();


int num = 0;
int choice = 0;
char runAgain = ' ';

int main() {

	do {
		clearScreen();

		cout << "Measurment Converter\n" << endl;

		cout << "1 -- Centimeters" << endl;
		cout << "2 -- Inches\n" << endl;
		cout << "Please pick an option. ";

		cin >> choice;

		cout << endl;

		if (choice == 1) {
			getCentimeters();
		}
		else if (choice == 2) {
			getInches();
		}
		else {
			cout << "Invalid entry." << endl;
		}

		system("pause");

		clearScreen();
		cout << "Would you like to convert another measurment (Y or N)?  ";
		cin >> runAgain;
	} while (toupper(runAgain) == 'Y');

	cout << "Program has ended. Thank you." << endl;
	system("pause");
	return 0;
}

void getCentimeters() {
	cout << "Please enter a number to convert \nfrom inches to centimeters : ";
	cin >> num;

	cout << endl;

	double numInches = num * 2.54;
	cout << numInches << " centimeters" << endl;
}

void getInches() {
	cout << "Please enter a number to convert \nfrom centimeters to inches : ";
	cin >> num;

	cout << endl;

	double numCentimeters = num * 0.3937;
	cout << numCentimeters << " inches" << endl;
}

// Function to clear the screen based on OS
void clearScreen()
{
#ifdef _WIN32
	system("CLS");
#else
	system("clear");
#endif
}