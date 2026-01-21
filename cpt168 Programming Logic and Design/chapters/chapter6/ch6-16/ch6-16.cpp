#include <iostream>
using namespace std;

int main() {

	//declare variables
	int num1 = 0;
	int num2 = 0;
	int num3 = 0;
	int smallest = 0;
	int largest = 0;

	//output-input
	cout << "Please enter your first number : ";
	cin >> num1;

	cout << "Please enter your second number : ";
	cin >> num2;

	cout << "Please enter your third number : ";
	cin >> num3;

	//process
	if (num1 >= num2 && num1 >= num3) {
		largest = num1;
	}
	else if (num2 >= num1 && num2 >= num3) {
		largest = num2;
	}
	else {
		largest = num3;
	}

	if (num1 <= num2 && num1 <= num3) {
		smallest = num1;
	}
	else if (num2 <= num1 && num2 <= num3) {
		smallest = num2;
	}
	else {
		smallest = num3;
	}

	//output
	cout << "The largest number is : " << largest << endl;
	cout << "The smallest number is : " << smallest << endl;
	return 0;
}