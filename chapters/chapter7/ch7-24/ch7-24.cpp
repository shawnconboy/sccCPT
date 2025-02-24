#include <iostream>
using namespace std;




int main() {

	system("color f0");

	// display my info

	// declare variables
	double startBalance = 0;
	double endBalance = 0;
	double deposit = 0;
	double depositTotal = 0;
	double withdraw = 0;
	double withdrawalTotal = 0;

	// output input 

	cout << "Hello. Please enter your starting balance : ";
	cin >> startBalance;

	// process

	while (true) {
		cout << "Please enter a deposit.";
		cin >> deposit;

		if (deposit == -777) {
			cout << "Program has ended" << endl;
			break;
		}

		depositTotal += deposit;

		cout << "Please enter a deposit.";
		cin >> deposit;
	}

	// final output


	system("pause");
	return 0;

}