#include <iostream>
using namespace std;
int main() {
	system("color f0");

	//Display my information
	cout << "\t\t******************************" << endl;
	cout << "\t\t*        Shawn Conboy        *" << endl;
	cout << "\t\t*        CPT-168-A01H        *" << endl;
	cout << "\t\t*      Christmas Bonus       *" << endl;
	cout << "\t\t*           Lab-5            *" << endl;

	//Declare Variables
	float annualSalary = 0.00;
	float yearsWorked = 0;
	float bonusPercentage = 0.00;

	//Process
	cout << "Please enter your gross pay per year : ";
	cin >> annualSalary;

	cout << "Please enter number of years you worked : ";
	cin >> yearsWorked;

	if (yearsWorked <= 5) {
		bonusPercentage = 0.01;
	}
	else if (yearsWorked >= 6) {
		bonusPercentage = 0.02;
	}

	float bonus = annualSalary * bonusPercentage;

	cout << "Your bonus is : $" << bonus << endl;

	cout << "     T H A N K Y O U     ";

	return 0;
}