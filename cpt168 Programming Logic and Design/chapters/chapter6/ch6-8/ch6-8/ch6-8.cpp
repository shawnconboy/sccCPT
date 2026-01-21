#include <iostream>
using namespace std;

int main() {
	char membership = ' ';
	int age = 0;
	double fee = 0.0;

	cout << "Are you a member (y or n) : ";
	cin >> membership;
	membership = toupper(membership);

	cout << "Please enter your age : ";
	cin >> age;

	if (membership == 'Y') {
		if (age > 65) {
			fee = 5;
		}
		else {
			fee = 10;
		}
	}
	else {
		if (age > 65) {
			fee = 15;
		}
		else {
			fee = 20;
		}
	}

	cout << "Please pay : $" << fee << ". Thank you.";
}