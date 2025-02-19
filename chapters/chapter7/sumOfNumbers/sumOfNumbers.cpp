#include <iostream>
using namespace std;

int main() {

	int num, sum = 0;

	cout << "\tPlease enter a number : ";
	cin >> num;

	for (int i = 1; i <= num; i += 1) {
		sum = sum + i;
	}

	cout << "\tThe sum of numbers from 1 to  " << num <<  " is " << sum << endl;


	system("pause");
	return 0;
}