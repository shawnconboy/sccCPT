#include <iostream>
#include <iomanip>
using namespace std;

int main() {

	system("color f0");

	cout << "\t\t***************************" << endl;
	cout << "\t\t*                         *" << endl;
	cout << "\t\t*       Shawn Conboy      *" << endl;
	cout << "\t\t*  Electric Bill Average  *" << endl;
	cout << "\t\t*                         *" << endl;
	cout << "\t\t***************************" << endl << endl;

	//declare variables
	double bill = 0.0;
	int months = 0;
	double average = 0.0;

	//This is the initial read
	cout << "Please enter bill amount : ";
	cin >> bill;

	//while the number entered is valid
	while (bill >= 0) {
		months += 1;
		average += bill;

		cout << "Please enter bill amount : ";
		cin >> bill;
	}

	//output the average bill amount and end the program

	cout << "The average bill amount is : " << fixed << setprecision(2) << average / months << endl;

	cout << "Program no longer running." << endl;

	system("pause");

}