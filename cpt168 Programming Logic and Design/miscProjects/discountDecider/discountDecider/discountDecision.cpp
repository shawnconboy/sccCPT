#include <iostream>
using namespace std;

int main() {

	cout << endl;

	//Variables
	float amountOfPurchase = 0.00;
	float totalPurchasePrice = 0.00;
	float priceWithDiscount = 0.00;
	int discountAmount = 0.00;

	//Process
	cout << "Hello, please enter your purchase price. : ";
	cin >> amountOfPurchase;

	if (amountOfPurchase >= 100.00) {
		priceWithDiscount = amountOfPurchase * 0.98;
		cout << "You got a 2% discount! Your total is now  : " << priceWithDiscount;
	}
	else if (amountOfPurchase <= 99.99) {
		priceWithDiscount = amountOfPurchase * 0.99;
		cout << "You got a 1% discount! Your total is now  : " << priceWithDiscount;
	}

	cout << endl;
	cout << endl;

	return 0;
} 