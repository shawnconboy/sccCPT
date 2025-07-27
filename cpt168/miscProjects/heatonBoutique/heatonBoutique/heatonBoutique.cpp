#include <iostream>
using namespace std;

int main() {
	
	//declare variables
	float purchasePrice = 0.00;
	float shippingFee = 0.00;
	float discountRate = 0.10;
	char member = ' ';
	float totalDue = 0.00;

	cout << "Hello. What's your purchase price? : ";
	cin >> purchasePrice;

	cout << "Are you a Premiere Club member? (Enter 'y' or 'n') : ";
	cin >> member;

	if (toupper(member) == 'Y') {
		totalDue = purchasePrice - (purchasePrice * discountRate);
	}
	else {
		totalDue = purchasePrice;
	}

	if (totalDue >= 100) {
		shippingFee = 0.99;
	}
	else {
		shippingFee = 4.99;
	}

	cout << "Amount owed : $" << totalDue << endl;
	cout << "Shipping fee : $" << shippingFee << endl;


	totalDue = totalDue + shippingFee;

	cout << "Your total is : $" << totalDue << endl << "Thank you." << endl;


	return 0;
}