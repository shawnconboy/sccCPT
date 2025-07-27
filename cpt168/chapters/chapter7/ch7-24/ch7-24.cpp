#include <iostream>
#include <iomanip>
using namespace std;




int main() {

	system("color f0");

	// display my info

	cout << "****************************************" << endl;
	cout << "*                                      *" << endl;
	cout << "*           ATM Simulator              *" << endl;
	cout << "*                                      *" << endl;
	cout << "****************************************" << endl;

	// declare variables
	double startBalance = 0;
	double endBalance = 0;
	double deposit = 0;
	double depositTotal = 0;
	double withdraw = 0;
	double withdrawTotal = 0;
	int depositOrWithdraw = 0;

	// output input 

	cout << "Hello. Please enter your starting balance : ";
	cin >> startBalance;

	// process

	while (startBalance > 0) {

		system("cls");

		cout << "****************************************" << endl;
		cout << "*                                      *" << endl;
		cout << "*           ATM Simulator              *" << endl;
		cout << "*                                      *" << endl;
		cout << "****************************************" << endl;

		cout << "Your balance : $" << startBalance << endl;

		cout << "Choose an option. \n1\tDeposit \n2\tWithdraw" << endl;
		cin >> depositOrWithdraw;


		if (depositOrWithdraw == 1) {
			cout << "Please enter amout to deposit : ";
			cin >> deposit;
			startBalance += deposit;
			depositTotal += deposit;
		}
		else if (depositOrWithdraw == 2) {
			cout << "Please enter amount to withdraw : ";
			cin >> withdraw;
			startBalance -= withdraw;
			withdrawTotal += withdraw;
		}
		else if (depositOrWithdraw == 3) {
			break;
		}

	}

	// final output

	cout << "Your total deposits : $" << depositTotal << endl;
	cout << "Your total withdraws : $" << withdrawTotal << endl;
	cout << "Your total balance : $" << startBalance << endl;

	system("pause");
	return 0;

}