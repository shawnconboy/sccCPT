#include <iostream>
#include <iomanip>
using namespace std;

int main() {
	system("color f0");


	cout << "\t\t*************************" << endl;
	cout << "\t\t*      Shawn Conboy     *" << endl;
	cout << "\t\t*      CPT 168 A01H     *" << endl;
	cout << "\t\t*Lab 5 - Christmas Bonus*" << endl;
	cout << "\t\t*************************" << endl;

	//declare variables
	double bonus = 0.0;
	double gross = 0.0;
	int yearsWorked = 0;

	//output input
	cout << "\n\tHello, please enter number of years you worked : ";
	cin >> yearsWorked;

	//process
	if (yearsWorked > 0) {

		//output input
		cout << "\n\tPlease enter your gross per year : ";
		cin >> gross;

		//process
		if (yearsWorked > 5) {
			bonus = gross * 0.02;
		}
		else {
			bonus = gross * 0.01;
		}

		//output
		cout << "\n\tYour Bonus is : $" << fixed << setprecision(2) << bonus << endl;
		cout << "\n\t\t\t T H A N K Y O U" << endl << endl;
	}
	else {
		//output
		cout << "\n\tInvalid number of years entered." << endl;
	}

	system("pause");
	return 0;
}