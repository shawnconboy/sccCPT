#include <iostream>
using namespace std;

int main() {

	// declare variables
	float taxRate = 0.00;
	int income = 0;
	int age = 0;

	// output - input
	cout << "Hello, please enter your income : ";
	cin >> income;

	// process
	if (income >= 200000) {
		taxRate = 0.20;
	}
	else {
		cout << "Please enter your age : ";
		cin >> age;

		if (age >= 60) {
			taxRate = 0.06;
		}
		else {
			taxRate = 0.12;
		}
	}

	// output
	cout << "Your tax amount is : " << taxRate << ". Thank you!" << endl;

	return 0;
}