#include <iostream>
using namespace std;

int main() {
	//declare variables
	double dollarAmount = 0.0;
	int currencyChoice = 0;
	double conversion = 0.0;

	//output-input
	cout << "Please enter the amount you'd like to convert : ";
	cin >> dollarAmount;

	cout << "Please choose the currency you'd like to convert to." << endl;
	cout << "Choose 1 for Euro" << endl;
	cout << "Choose 2 for Canadian Dollar" << endl;
	cout << "Choose 3 for Indian Rupee" << endl;
	cin >> currencyChoice;

	switch (currencyChoice) {
	case 1:
		//euro
		conversion = dollarAmount * 0.97;
		cout << "You have " << conversion << " Euros.";
		break;
	case 2:
		//cad
		conversion = dollarAmount * 1.43;
		cout << "You have " << conversion << " Canadian dollars.";
		break;
	case 3:
		//Indian Rupee
		conversion = dollarAmount * 87.58;
		cout << "You have " << conversion << " Indian Rupees.";
		break;
	default:
		cout << "Invalid entry";
	}

	return 0;
}
