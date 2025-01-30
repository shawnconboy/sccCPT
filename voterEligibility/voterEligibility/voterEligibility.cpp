#include <iostream>
using namespace std;

int main() {

	//declare variables
	int age;
	char registered = ' ';

	//output-input
	cout << "Hello. Please enter your age : ";
	cin >> age;

	//process
	if (age >= 18) {
		cout << "Are you registered to vote? (Y or N) : ";
		cin >> registered;

		if (toupper(registered) == 'Y') {
			cout << "You can vote." << endl;
		}
		else {
			cout << "You need to register first." << endl;
		}
	}
	else {
		cout << "You're too young to vote." << endl;
	}
	return 0;
}