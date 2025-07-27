#include <iostream>
using namespace std;

int main() {

	//declare variables

	double sales = 0.0;
	double commission = 0.0;

	//output input
	cout << "Hey, how much did you make? : ";
	cin >> sales;

	//process
	while (sales != -1) {
		commission = sales * 0.2;
		cout << "Commission = : " << commission << endl;

		cout << "Hey, how much did you make? : ";
		cin >> sales;
	}

	return 0;
}