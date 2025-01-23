#include <iostream>
using namespace std;
int main() {
	system("color f0");

	//Display my information
	cout << "\t\t******************************" << endl;
	cout << "\t\t*        Shawn Conboy        *" << endl;
	cout << "\t\t*        CPT-168-A01H        *" << endl;
	cout << "\t\t*      Christmas Bonus       *" << endl;
	cout << "\t\t*           Lab-5            *" << endl;

	//Declare Variables
	int yearsWorked;
	float salary;
	float bonusPercentage;
	float bonus;

	//Process

	cout << "Hello, What's your annual salary amount? :" << endl;
	cin >> salary;

	cout << "How many years have you worked with the company? : " << endl;
	cin >> yearsWorked;
	
	// If statement to determine bonus percentage
	if(yearsWorked > 0) {
		if(yearsWorked >= 6) {
			bonusPercentage = 0.02;
		} else {
			bonusPercentage = 0.01;
		}
	} else {
		cout << "Number is invalid. Pleas enter a number larger than 0" << endl;
	}

	bonus = salary * bonusPercentage;

	cout << "Awesome! Your Christmas bonus this year is $" << bonus << ". Thank you for your service." << endl;


	return 0;
}