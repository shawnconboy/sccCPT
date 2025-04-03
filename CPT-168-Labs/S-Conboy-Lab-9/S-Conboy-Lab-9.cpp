// S-Conboy-Lab-9.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include <iostream>
#include <string>
using namespace std;

int main()
{

	system("cls");

	cout << "*****************************" << endl;
	cout << "*       Shawn Conboy        *" << endl;
	cout << "*       CPT 168 A01H        *" << endl;
	cout << "*    LAB 9 STRING MANIP     *" << endl;
	cout << "*****************************" << endl;

	char userChoice = 'Y';

	while (toupper(userChoice) == 'Y')
	{
		string firstName = "", lastName = "", phoneNumber = "", ssn = "";

		// take in information *********************************************************

		cout << "Enter your first name: ";
		getline(cin, firstName);

		cout << "Enter your last name: ";
		getline(cin, lastName);

		do
		{
			cout << "Enter your 10 digit phone number (with no dashes or parenthesis): ";
			getline(cin, phoneNumber);
		} while (phoneNumber.length() != 10);

		do
		{
			cout << "Enter 9 digit SSN (with no dashes or parenthesis): ";
			getline(cin, ssn);
		} while (ssn.length() != 9);

		// return information *********************************************************
		string fullName = firstName + " " + lastName;
		cout << "\nYour full name is: " << fullName << endl;

		// reversed name needs to be a for loop that outputs the numbers backwards

		cout << "Your reversed full name is: ";
		for (int i = fullName.length() - 1; i >= 0; i--)
		{
			cout << fullName[i];
		}
		cout << endl;

		// string reversedName = string(fullName.rbegin(), fullName.rend());
		// cout << "Your reversed full name is: " << reversedName << endl;

		phoneNumber = phoneNumber.insert(0, "(");
		phoneNumber = phoneNumber.insert(4, ") ");
		phoneNumber = phoneNumber.insert(9, "-");
		cout << "Your phone number is: " << phoneNumber << endl;

		ssn = ssn.insert(3, "-");
		ssn = ssn.insert(6, "-");
		cout << "Your social security number: " << ssn << endl;

		cout << "\nWould you like to enter person's data? (Y or N)  ";
		cin >> userChoice;
		cin.ignore();
	}

	cout << "\nThank You\n\n";

	system("pause");
	return 0;
}


// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
