#include <iostream>
using namespace std;

int main() {

	//declare variables
	char member = ' ';
	char weekend = ' ';
	float fee = 0.00;

	//output-input
	cout << "Hello. Are you a member?(Y or N) : ";
	cin >> member;

	if (toupper(member) == 'Y') {
		fee = 5;
	}
	else {
		cout << "Is today part of the weekend?";
		cin >> weekend;

		if (toupper(weekend) == 'Y') {
			fee = 25;
		}
		else {
			fee = 15;
		}
	}

	cout << "You owe $" << fee << ". Thank you.";
	return 0;
}