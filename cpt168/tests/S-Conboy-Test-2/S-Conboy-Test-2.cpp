#include <iostream>
#include <iomanip>
using namespace std;

int main() {

	//display info

	cout << "\t\t***************************************" << endl;
	cout << "\t\t*                                     *" << endl;
	cout << "\t\t*            Shawn Conboy             *" << endl;
	cout << "\t\t*            CPT 168 A01H             *" << endl;
	cout << "\t\t*               Test 2                *" << endl;
	cout << "\t\t*                                     *" << endl;
	cout << "\t\t***************************************" << endl;


	//declare variables

	double shippingCost = 0;
	int packageWeight = 0;
	//rounding up in weight to use int instead of double

	//output input

	cout << "Hello. Please enter package weight : ";
	cin >> packageWeight;

	//process

	if (packageWeight < 0) {
		cout << "Invalid Entry.";
	}
	else {
		if (packageWeight < 8) {
			cout << "****** Free Shipping ******\n";
		}
		else if (packageWeight < 25) {
			shippingCost = packageWeight * 0.2;
		}
		else if (packageWeight < 51) {
			shippingCost = (packageWeight * 0.30) + 20;
		}
		else {
			shippingCost = 100;
		}
	}

	//final output
	cout << "------> Shipping Cost : $" << fixed << setprecision(2) << shippingCost << endl;
	cout << "\t\t****** T H A N K Y O U ******";

	return 0;
}