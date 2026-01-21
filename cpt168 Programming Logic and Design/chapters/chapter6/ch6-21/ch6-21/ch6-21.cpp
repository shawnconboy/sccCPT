#include <iostream>
using namespace std;

//int main() {
//	int code = 0;
//
//	cout << "Enter the code";
//	cin >> code;
//
//	if (code == 36) {
//		cout << "kentucky";
//	} else 
//		if (code == 40 || code == 43) {
//			cout << "Louisiana";
//		}
//		else {
//			cout << "invalid code";
//		}
//	return 0;
//}

int main() {


	int code = 0;

	cout << "enter the code : ";
	cin >> code;

	if (code == 12) {
		cout << "tennessee";
	}
	else if (code == 36) {
		cout << "kentucky";
	}
	else if (code == 40 || code == 43) {
		cout << "louisiana";
	}
	else {
		cout << "invalid code";
	}

	cout << endl;

	return 0;
}