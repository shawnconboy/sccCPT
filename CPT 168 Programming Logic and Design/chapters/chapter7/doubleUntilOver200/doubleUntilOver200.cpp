#include <iostream>
using namespace std;

int main() {

	// declare variables
	int num = 0;

	// output input
	cout << "Hello. Please enter a number less than 200 : ";
	cin >> num;

	// process
	while (num < 200) {
		num = num * 2;
		cout << num << endl;
	}

	return 0;
}