#include <iostream>
#include <iomanip>
using namespace std;

int main() {

	// Declare variables
	int numRegistered = 0, totalRegistered = 0;
	double feePerPerson = 0, companyFee = 0.0, totalCharge = 0.0;
	char moreRegistrants;

	do {
		// Get user input
		cout << "Please enter number of registrants: ";
		cin >> numRegistered;

		// Validate input
		if (numRegistered <= 0) {
			cout << "Invalid input. Please enter a positive number." << endl;
			continue;  // Skip this iteration if input is invalid
		}

		// Determine fee per person
		if (numRegistered < 4) {
			feePerPerson = 150;
		}
		else if (numRegistered < 10) {
			feePerPerson = 100;
		}
		else {
			feePerPerson = 90;
		}

		// Calculate current company fee and update totals
		companyFee = numRegistered * feePerPerson;
		totalRegistered += numRegistered;
		totalCharge += companyFee;

		// Display current results
		cout << fixed << setprecision(2);
		cout << "Current charge for this entry: $" << companyFee << endl;
		cout << "Total number of people registered so far: " << totalRegistered << endl;
		cout << "Total charge so far: $" << totalCharge << endl;

		// Ask if user wants to add more registrants
		cout << "Would you like to add more registrants? (y/n): ";
		cin >> moreRegistrants;

	} while (moreRegistrants == 'y' || moreRegistrants == 'Y');  // Loop continues if user inputs 'y' or 'Y'

	// Final summary
	cout << "\n--- Final Summary ---" << endl;
	cout << "Total number of people registered: " << totalRegistered << endl;
	cout << "Total charge: $" << totalCharge << endl;

	// Prevent division by zero before calculating average charge
	if (totalRegistered > 0) {
		cout << "Average charge per person: $" << (totalCharge / totalRegistered) << endl;
	}

	cout << "Program ended." << endl;
	return 0;
}
