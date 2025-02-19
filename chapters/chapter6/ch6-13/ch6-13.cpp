#include <iostream>
using namespace std;

int main() {
	// declare variables
	double moneyOwed = 0.0;
	double feePerPerson = 0.0;
	int numberOfRegistrants = 0;

	//output-input
	cout << "How many people would you like to register? : ";
	cin >> numberOfRegistrants;

	//process
	
	if (numberOfRegistrants <= 0) {
		cout << "Invalid number of regitrants.";
	}
	else if (numberOfRegistrants >= 0 && numberOfRegistrants <= 5) {
		feePerPerson = 125;
	}
	else if (numberOfRegistrants >= 6 && numberOfRegistrants <= 20) {
		feePerPerson = 100;
	}
	else if (numberOfRegistrants >= 21) {
		feePerPerson = 75;
	}

	//output
	cout << "With " << numberOfRegistrants << " people registered, that'll make the fee $" << feePerPerson << " per person." << endl << "Thank you.";
}