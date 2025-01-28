//#include <iostream>
//#include <iomanip>
//using namespace std;
//
//int main() {
//
//	//declare variables
//	char payCode = ' ';
//	double currentPay = 0.00;
//	const double RATE1 = 0.045;
//	const double RATE2 = 0.035;
//	double raise = 0.00;
//	double newPay = 0.00;
//
//	//process
//
//	cout << "Hello. Please enter your pay code : ";
//	cin >> payCode;
//
//	cout << "Please enter your current pay : ";
//	cin >> currentPay;
//
//	if (payCode == '1' || payCode == '4' || payCode == '9') {
//		raise = RATE1;
//	}
//	else {
//		raise = RATE2;
//	}
//
//	newPay = currentPay * raise + currentPay;
//
//	cout << fixed << setprecision(2) << newPay;
//
//
//	return 0;
//}