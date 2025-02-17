#include <iostream>
#include <iomanip>
using namespace std;

int main() {

	//declare variables
	double stockPrice = 0.0;
	int stocksEntered = 0;
	double pricesCombined = 0.0;
	double averagePrice = 0.0;

	cout << "Please enter stock price(negative to end) : ";
	cin >> stockPrice;

	while (stockPrice >= 0.0) {
		stocksEntered += 1;
		pricesCombined += stockPrice;
		
		cout << "Please enter the next stock price : ";
		cin >> stockPrice;
	}
	if (stocksEntered > 0) {
		averagePrice = pricesCombined / stocksEntered;
		

		cout << "Number of stocks entered : " << stocksEntered << endl;
		cout << "Stock average : " << fixed << setprecision(2) << averagePrice << endl;
	}
	else {
		cout << "No stock prices entered." << endl;
	}

	


	return 0;
}