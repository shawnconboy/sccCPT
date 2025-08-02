#include <iostream>
using namespace std;

int main() {
	//Declare Variables
	int age;
	float gpa;
	int scholarshipAmount;

	//Process
	cout << "Please enter your gpa" << endl;
	cin >> gpa;

	if (gpa >= 3.5) {
		cout << "Please enter your age" << endl;
		cin >> age;

		if (age <= 25) {
			scholarshipAmount = 10000;
		}
		else {
			scholarshipAmount = 5000;
		}
	}
	else {
		scholarshipAmount = 1000;
	}

	cout << "You've been awarded $" << scholarshipAmount << "! Thank You !";

	return 0;
}