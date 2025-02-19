#include <iostream>
using namespace std;

int main() {

	int num, asterisks = 0;

	cout << "Enter the number of rows : ";
	cin >> num;

	for (int rows = 1; rows <= num; rows += 1) {

		asterisks += 1;

		cout << asterisks << endl;
	}



	return 0;
}