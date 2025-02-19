#include <iostream>
using namespace std;

int main() {
	system("color f0");

	//Display my information
	cout << "\t\t******************************" << endl;
	cout << "\t\t*        Shawn Conboy        *" << endl;
	cout << "\t\t*        CPT-168-A01H        *" << endl;
	cout << "\t\t*  CalculateAutoCommission   *" << endl;
	cout << "\t\t*           Lab-4            *" << endl;

	//Declare Variables
	int carsSold = 0;
	float commission = 500.00;
	float totalCommission = 0.00;

	//Process
	cout << "Please enter number of cars you sold: ";
	cin >> carsSold;
	
	totalCommission = carsSold * commission;

	cout << "Your commission is: " << totalCommission << endl;
	cout << "     T H A N K Y O U     " << endl;

	return 0;
}