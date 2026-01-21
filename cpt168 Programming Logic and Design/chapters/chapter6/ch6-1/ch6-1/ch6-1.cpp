#include <iostream>
using namespace std;

int main() {

	double sales = 0.0;
	double bonus = 0.0;

	cout << "Enter sales : ";
	cin >> sales;

	if (sales <= 0) {
		bonus = 0;
		cout << "The sales must be greater than 0.";
	}
	else {
		if (sales <= 1000) {
			bonus = sales * 0.15;
		}
		else {
			if (sales <= 5000) {
				bonus = sales * 0.20;
			}
			else {
				bonus = sales * 0.25;
			}
		}
	}

	cout << bonus << endl;


	return 0;
}