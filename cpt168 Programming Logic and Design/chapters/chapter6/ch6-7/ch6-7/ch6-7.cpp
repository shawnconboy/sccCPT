#include <iostream>
using namespace std;

int main() {
	//declare variables
	char department = ' ';
	double salary = 0.0;
	double raise = 0.0;

	//output-input
	cout << "Please enter your department (A,B,C, or D) : ";
	cin >> department;

	department = (toupper(department));

	cout << "Please enter your salary : ";
	cin >> salary;

	switch (department)
	{
	case 'A':
	case 'B':
		raise = 0.02;
		break;
	case 'C':
		raise = 0.015;
		break;
	case 'D':
		raise = 0.03;
		break;
	}

	cout << "Your raise is $" << salary * raise << ". Your new salary is $" << (salary*raise)+salary << "." << endl;
	return 0;
}