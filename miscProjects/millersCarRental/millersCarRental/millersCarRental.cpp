#include <iostream>
using namespace std;

int main() {


	//declare variables

	int dailyFee = 55;
	char luxuryCar = ' ';
	char member = ' ';

	//output-input
	cout << "Hello. Will you be renting a luxury car? Y or N : ";
	cin >> luxuryCar;

	//process
	if (toupper(luxuryCar) == 'Y') {
		cout << "Are you a Rental Club member? Y or N : ";
		cin >> member;

		if (toupper(member) == 'Y') {
			dailyFee += 20;
		}
		else {
			dailyFee += 30;
		}
	}

	//output-input
	cout << "You owe $" << dailyFee << endl;

	return 0;
}