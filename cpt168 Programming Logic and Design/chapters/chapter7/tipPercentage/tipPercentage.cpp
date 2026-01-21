#include <iostream>
#include <iomanip>
using namespace std;

int main() {

	//declare variable
	double billAmount = 0.0;
	double tip = 0.0;


	cout << "Please enter bill amount : ";
	cin >> billAmount;

	//for (double rate = 0.1; rate <= 0.02; rate += 0.05) {
	//	tip = billAmount * rate;

	//	cout << rate * 100 << "% tip: ";

	//	cout << "$" << tip << endl;
	//}

	for (double i = 0.1; i <= 0.2; i += 0.05) {
		//cout << fixed << setprecision(2) << i << endl;
		
		tip = billAmount * i;

		cout << i * 100 << "% tip: ";
		cout << "$" << tip << endl;
	}

}