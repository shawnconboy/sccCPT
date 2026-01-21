#include <iostream>
using namespace std;

int main() {

	system("color f0");

	int num = 0;

	cout << "\tPlease enter a number : ";
	cin >> num;
	cout << endl;

	for (int n = 1; n <= 12; n += 1) {
		cout << "\t" << num << " * " << n << " = " << num * n << endl;
	}

	cout << endl;

	system("pause");
	return 0;
}