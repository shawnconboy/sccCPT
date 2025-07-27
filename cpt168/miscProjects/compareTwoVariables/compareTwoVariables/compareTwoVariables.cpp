#include <iostream>
using namespace std;

int main() {
	//declare variables
	int code1;
	int code2;

	cout << "enter code 1 : ";
	cin >> code1;

	cout << "enter code 2 : ";
	cin >> code2;

	if ((char)code1 == (char)code2) {
		cout << "These are the same";
	}
	else {
		cout << "Not the same";
	}

	return 0;
}