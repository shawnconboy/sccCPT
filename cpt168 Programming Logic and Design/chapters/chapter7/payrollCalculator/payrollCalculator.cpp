#include <iostream>
#include <iomanip>
using namespace std;

int main() {

	system("color f0");

	cout << "\t\t*******************************" << endl;
	cout << "\t\t*       Payroll Calculator     " << endl;
	cout << "\t\t*******************************" << endl;

	//declare variables
	double payrollAmount = 0.0;
	double storePayroll = 0.0;




	for (int storeCount = 1; storeCount < 4; storeCount += 1) {
		cout << "Store " << storeCount << " payroll : ";
		cin >> storePayroll;
		payrollAmount = payrollAmount + storePayroll;
	}

	cout << "Total payroll amount : " << fixed << setprecision(2) << payrollAmount << endl;

	system("pause");
	return 0;
}