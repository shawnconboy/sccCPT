#include <iostream>
#include <iomanip>
using namespace std;

int main() {
	//declare variables
	double salesAmount = 0.0;
	double commissionRate = 0.0;
	double commissionDue = 0.0;

	//output-input
	cout << "Please enter sales amount : ";
	cin >> salesAmount;

	//process
	if (salesAmount >= 0 && salesAmount <= 100000) {
		commissionRate = 0.02;
	}
	else if (salesAmount >= 100001 && salesAmount <= 400000) {
		commissionRate = 0.05;
	}
	else if (salesAmount >= 400001) {
		commissionRate = 0.09;
	}
	
	commissionDue = commissionRate * salesAmount;

	cout << "Your total commission due is : $" << fixed << setprecision(2) << commissionDue << endl;

	return 0;
}