#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	// variables
	ifstream inText;
	ofstream outText;
	string userEntry = "";


	// open the userText file
	outText.open("userText.txt");
	if (outText.is_open()) {
		cout << "outText.txt opened successfully.\n\n";
	}
	else {
		cout << "outText.txt not found.";
		return 0;
	}



	// ask user for 10 letters
	cout << "Please enter the first 10 letters of the alphabet." << endl;
	getline(cin, userEntry);



	// write each uppercase letter to the file, one per line
	for (int i = 0; i < 10; i++) {
		outText << (char)toupper(userEntry[i]) << endl;
	}


	// print to the file
	outText << userEntry;
	outText.close();

	// ***********************************************************************

	inText.open("userText.txt");
	if (inText.is_open()) {
		cout << "inText.txt opened successfully.\n\n";
	}
	else {
		cout << "inText.txt not found.";
		return 0;
	}

	while (!inText.eof()) {
		getline(inText, userEntry);

		cout << "You entered: " << userEntry << endl;
	}

	inText.close();

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
