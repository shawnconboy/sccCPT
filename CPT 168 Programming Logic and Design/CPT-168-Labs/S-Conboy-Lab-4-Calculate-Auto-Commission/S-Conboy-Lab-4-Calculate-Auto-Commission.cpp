#include <iostream>
using namespace std;

int main() {

	system("color f0");

	// Display My Information
	cout << "\t\t*************************" << endl;
	cout << "\t\t*      Shawn Conboy     *" << endl;
	cout << "\t\t*      CPT-168-AO1H     *" << endl;
	cout << "\t\t*  Calculate Commission *" << endl;
	cout << "\t\t*          Lab 3        *" << endl;
	cout << "\t\t*************************" << endl;

	//declare variables
	int carsSold = 0;
	double commission = 0.0;

	//output-input
	cout << "Hello. Please enter number of cars sold : ";
	cin >> carsSold;

	//process
	commission = carsSold * 500;

	//output
	cout << "Your commission is : " << commission << endl;
	cout << "\n********** T H A N K Y O U **********\n" << endl;

	system("pause");

	return 0;
}