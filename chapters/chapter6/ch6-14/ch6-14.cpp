#include <iostream>
using namespace std;

int main() {

	//declare variables
	double quarterlySales = 0.0;
	double commissionRate = 0.0;

	//output-input 
	cout << "Hello. Please enter your quarterly sales.";
	cin >> quarterlySales;

	//process
	if (quarterlySales >= 0 && quarterlySales <= 20000) {
		commissionRate = quarterlySales * 0.05;
		cout << commissionRate;
	}
	else if (quarterlySales >= 20001 && quarterlySales <= 50000) {
		commissionRate = quarterlySales * 0.07 + 1000;
		cout << commissionRate;
	}
	else if (quarterlySales >= 50001) {
		commissionRate = quarterlySales * 0.10 + 3100;
		cout << commissionRate;
	}
	else {
		cout << "Invalid Entry";
	}

	return 0;
}