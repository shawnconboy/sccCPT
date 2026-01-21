#include <iostream>
using namespace std;

int main() {

	// declare variables

	double ticketPrice = 0.00;
	int age = 0;

	// output-input

	cout << "Please enter your age : ";
	cin >> age;

	if (age >= 0 && age <= 3) {
		ticketPrice = 0;
	}
	else if (age >= 4 && age <= 64) {
		ticketPrice = 9;
	}
	else if (age >= 65) {
		ticketPrice = 6;
	}
	else {
		cout << "Invalid age. Please enter a number greater than 0.";
	}
	cout << "Your ticket price is " << ticketPrice;
	
	return 0;
}