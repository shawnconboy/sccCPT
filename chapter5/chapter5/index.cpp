#include <iostream>
using namespace std;

int main() {

	//declare variables
	float totalOwed = 0.0;
	int numPounds = 0.0;
	double poundPrice = 0.0;
	char tax = ' ';

	//output/input
	cout << "Hello. Please enter the number of pounds of coffee : ";
	cin >> numPounds;

	cout << "Please enter the price per pound : ";
	cin >> poundPrice;

	cout << "Apply tax? (Y or N) ";
	cin >> tax;

	//process
	if (toupper(tax) == 'Y') {
		totalOwed = numPounds * poundPrice;
		totalOwed = totalOwed + (totalOwed * 0.035);
	}
	else if (toupper(tax) == 'N') {
		totalOwed = numPounds * poundPrice;
	}

	cout << "Total Owed : $" << totalOwed;

	return 0;
}