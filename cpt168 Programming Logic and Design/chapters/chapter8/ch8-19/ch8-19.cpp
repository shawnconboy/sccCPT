#include <iostream>
#include <iomanip>
using namespace std;

int main() {

	int sales = 0;
	double totalSales = 0;

	for (int i = 0; i < 3; i++) {

		cout << "Dealership Number " << i + 1 << " sales" << endl;

		do {
			cout << "Please enter number of sales : ";
			cin >> sales;

			totalSales += sales;
		} while (sales != -1);

		cout << "Total Sales = $" << fixed << setprecision(2) << totalSales << endl;

		cout << endl;
	}

	system("pause");

	return 0;
}

