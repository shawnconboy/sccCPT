#include <iostream>
using namespace std;

int main() {

	//declare variables
	double marySales = 0.0;
	double jimSales = 0.0;
	double highSales = 0.0;
	double lowSales = 0.0;

	//process

	cout << "Please enter Mary's sales : ";
	cin >> marySales;

	cout << "Please enter Jim's sales : ";
	cin >> jimSales;

	if (marySales > jimSales) {
		highSales = marySales;
		lowSales = jimSales;

		cout << "Mary had the higher sales with " << highSales << " total sales." << endl;
		cout << "Jim had the lesser sales with " << lowSales << " total sales." << endl;
	}
	else {
		highSales = jimSales;
		lowSales = marySales;

		cout << "Jim had the higher sales with " << highSales << " total sales." << endl;
		cout << "Mary had the lesser sales with " << lowSales << " total sales." << endl;
	}


	return 0; 
}