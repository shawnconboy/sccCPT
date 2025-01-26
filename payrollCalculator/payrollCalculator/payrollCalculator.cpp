#include <iostream>
using namespace std;

int main() {

	//declare variables
	float amountToBePayed;
	float hoursWorked;
	float payrate;
	float overtimeHours;
	float overtimePayrate;
	float overtimeToBePayed;
	float totalCheck;

	//process

	cout << "Hello, Please enter your payrate  :  ";
	cin >> payrate;

	cout << "Please enter your amount of hours worked  :  ";
	cin >> hoursWorked;

	if (hoursWorked > 40) {
		overtimeHours = hoursWorked - 40;
		overtimePayrate = payrate * 1.5;
		overtimeToBePayed = overtimeHours * overtimePayrate;

		amountToBePayed = (hoursWorked - overtimeHours) * payrate;

		totalCheck = overtimeToBePayed + amountToBePayed;
		
		cout << "You worked overtime this week! Your total paycheck is $" << totalCheck << "." << endl;
	}
	else {
		amountToBePayed = hoursWorked * payrate;
		cout << "You worked overtime this week! Your total paycheck is $" << amountToBePayed << "." << endl;
	}

	return 0;
}