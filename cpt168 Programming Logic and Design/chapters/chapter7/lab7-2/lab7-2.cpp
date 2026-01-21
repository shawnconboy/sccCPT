#include <iomanip>
#include <iostream>
using namespace std;


int main() {

	const double GROWTH_RATE = 0.055;
	double sales = 0.0;
	double annualIncrease = 0.0;
	int years = 0;

	cout << "Current year's sales : ";
	cin >> sales;

	while (sales < 150000) {
		annualIncrease = sales * GROWTH_RATE;
		sales = sales + annualIncrease;

		years = years + 1;
	}

	cout << "Sales " << years << " years from now : " << sales << endl;
	
 	return 0;
}