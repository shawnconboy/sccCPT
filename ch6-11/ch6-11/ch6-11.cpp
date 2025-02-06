#include <iostream>
using namespace std;

int main() {
	//declare variables
	int deptCode = 0;
	int salary = 0;

	//output-input
	cout << "Hello. Please enter your department code(1,2, or 3) : ";
	cin >> deptCode;

	//process

	switch (deptCode) {
	case 1:
		salary = 25000;
		break;
	case 2:
		salary = 30000;
		break;
	case 3:
		salary = 32000;
		break;
	default:
		"Invalid entry";
		break;
	}

	cout << "Your salary is : " << salary << endl;

	return 0;
}