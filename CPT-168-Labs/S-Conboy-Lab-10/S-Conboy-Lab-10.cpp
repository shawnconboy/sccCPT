#include <iostream>
#include <string>
#include <fstream>
#include <iomanip>

using namespace std;

int main() {

	cout << "*******************************************" << endl;
	cout << "*                                         *" << endl;
	cout << "*             Shawn Conboy                *" << endl;
	cout << "*             CPT 168 A01H                *" << endl;
	cout << "*        Payroll Sequential File          *" << endl;
	cout << "*                                         *" << endl;
	cout << "*******************************************\n" << endl;

	cout << "---------------------------------------------------------\n\n";

	ifstream inRecords;
	inRecords.open("payroll.txt");

	if (!inRecords.is_open()) {
		cout << "Failed to open payroll.txt\n";
		return 1;
	}

	// Variables
	string firstName = "";
	string lastName = "";
	string ssn = "";
	int hoursWorked = 0;
	double rate = 0.0;
	double gross = 0.0;
	double deductions = 0.0;
	double net = 0.0;
	int recordCount = 0;

	// Print table header
	cout << left << setw(6) << "SSN"
		<< setw(4) << "In."
		<< setw(12) << "Last Name"
		<< right << setw(10) << "Hours"
		<< setw(10) << "Rate"
		<< setw(10) << "Gross"
		<< setw(12) << "Deductions"
		<< setw(10) << "Net" << endl;

	cout << "--------------------------------------------------------------------------" << endl;

	// Process each record
	while (!inRecords.eof()) {
		inRecords >> firstName >> lastName >> ssn >> hoursWorked >> rate;

		// Calculate gross pay
		if (hoursWorked > 40) {
			gross = (40 * rate) + ((hoursWorked - 40) * rate * 1.5);
		}
		else {
			gross = hoursWorked * rate;
		}

		deductions = gross * 0.10;
		net = gross - deductions;

		string lastFourSSN = ssn.substr(ssn.length() - 4);
		string firstInitial = firstName.substr(0, 1);

		// Print row
		cout << left << setw(6) << lastFourSSN
			<< setw(4) << firstInitial + "."
			<< setw(12) << lastName
			<< right << setw(10) << hoursWorked
			<< setw(10) << fixed << setprecision(2) << rate
			<< setw(10) << gross
			<< setw(12) << deductions
			<< setw(10) << net << endl;

		recordCount++;
	}

	inRecords.close();

	cout << "\nTotal Records Processed: " << recordCount << endl;

	return 0;
}
