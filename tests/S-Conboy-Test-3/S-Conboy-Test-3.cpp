#include <iostream>
using namespace std;

int main() {
	system("color f0");

	cout << "**********************************" << endl;
	cout << "*       Shawn Conboy             *" << endl;
	cout << "*       CPT-168-AO1H             *" << endl;
	cout << "*          Test 3                *" << endl;
	cout << "*                                *" << endl;
	cout << "**********************************" << endl;

	// Strings *****************************************************

	string scope[8] = { "This week is going to be a lucky week for you, buy lotto", "You will barely escape an accident this week", "You are going to have a week full of surprises", "You will receive a large amount of money this week", "You will get promoted at your job this week", "You will get a phone call from an old phone this week", "You may have some type of car problem this week", "Today is a day of fun" };

	string dayOfWeek[8] = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Funday" };

	string numbers[8] = { "8,9,23,29,50", "7,19,21,38,51", "6,25,28,30,49", "22,27,33,37,42", "16,18,28,34,38" , "10,3,6,13,33", "7,21,25,28,37" , "15,10,20,33,66" };

	// *************************************************************

	// Variables
	int userNum = 0;

	cout << "<<<<<<<<<<< Hello >>>>>>>>>>>>" << endl;

	cout << "Please enter a number from 1 - 7 or 99 to end: ";
	cin >> userNum;

	while (userNum != 99) {
		if (userNum >= 1 && userNum <= 7) {
			cout << "\nYour " << dayOfWeek[userNum - 1] << " Horoscope: " << scope[userNum - 1]
				<< "\nLucky Carolina5 numbers: " << numbers[userNum - 1] << endl;
		}
		else {
			cout << "Invalid number was entered." << endl;
		}

		cout << "\nPlease enter a number from 1 - 7 or 99 to end: ";
		cin >> userNum;
	}

	cout << "T H A N K  Y O U" << endl;

	system("pause");
	return 0;
}
