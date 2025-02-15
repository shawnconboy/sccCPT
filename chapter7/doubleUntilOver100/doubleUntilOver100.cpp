#include <iostream>
using namespace std;

int main() {

	int num = 0;

	// output input

	cout << "Please enter a number less than 100 : ";
	cin >> num;

	// process

	while (num < 100) {
		num = num * 2;
		cout << num << endl;
	}

}