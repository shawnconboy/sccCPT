#include <iostream>
using namespace std;

int main() {
	// declare variables
	int areaCode = 0;


	cout << "Please enter your area code (123) : ";
	cin >> areaCode;

	switch (areaCode)
	{
	case 305:
		cout << "Miami";
		break;
	case 863:
		cout << "Greenville";
		break;
	case 843:
		cout << "Charleston";
		break;
	case 704:
		cout << "Charlotte";
		break;
	default:
		cout << "Invalid code";
	}
	cout << " area code." << endl;
	return 0;
}