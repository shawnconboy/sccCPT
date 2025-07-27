#include <iostream>
#include <iomanip>
using namespace std;
//Start

int main() //Main function
{
	system("color f0");
	//Display my information
	cout << "\t\t******************************" << endl;
	cout << "\t\t*         Derek Rascoe       *" << endl;
	cout << "\t\t*   Calculate the gross pay  *" << endl;
	cout << "\t\t*     CPT-168-A01H-2025SP    *" << endl;
	cout << "\t\t*            Lab 5           *" << endl;
	cout << "\t\t******************************" << endl;

	//Declare_variables
	double grossPay = 0;
	double yearsWorked = 0;
	double Bonus = 0;

	//Input/Output
	cout << "Please enter the number of years you worked or (0,99 or higher, negative number) to exit: ";
	cin >> yearsWorked;
	cout << "Please enter your gross pay per year: ";
	cin >> grossPay;
	//Priming input read
	//Process
	if (yearsWorked >= 1 && yearsWorked <= 5)
	{
		Bonus = grossPay * 0.01;
		cout << fixed << setprecision(2) << "Your Bonus is: $" << Bonus << endl;
	}
	else if (yearsWorked >= 6)
	{
		Bonus = grossPay * 0.02;
		cout << fixed << setprecision(2) << "Your Bonus is: $" << Bonus << endl;
	}
	// loop
	while (yearsWorked != 0) //Pretest loop: sentinel value is etc
	{
		//Loop this

		cout << "Please enter the number of years you worked or (0,99 or higher, negative number) to exit: ";
		cin >> yearsWorked;
		cout << "Please enter your gross pay per year: ";
		cin >> grossPay;

		//Process
		if (yearsWorked >= 1 && yearsWorked <= 5)
		{
			Bonus = grossPay * 0.01;
			cout << fixed << setprecision(2) << "Your Bonus is: $" << Bonus << endl;
		}
		else if (yearsWorked >= 6)
		{
			Bonus = grossPay * 0.02;
			cout << fixed << setprecision(2) << "Your Bonus is: $" << Bonus << endl;
		}
	}

	//Output 
	cout << "T H A N K   Y O U" << endl;

	return 0;
	// end of main function

}