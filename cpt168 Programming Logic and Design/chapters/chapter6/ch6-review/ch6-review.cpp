#include <iostream>
#include <iomanip>
using namespace std;

//int main() {
//
//	int participants = 0;
//
//	cout << "Please enter number of participants : ";
//	cin >> participants;
//
//	while (participants > -1) {
//		if (participants < 10) {
//			cout << "Cancel the seminar.\n";
//		}
//		else if (participants < 40) {
//			cout << "Use the small conference room.\n";
//		}
//		else if (participants < 75) {
//			cout << "Use the Harris room.\n";
//		}
//		else {
//			cout << "Use the Kanton Room.\n";
//		}
//		system("pause");
//		system("cls");
//
//
//		cout << "Please enter number of participants : ";
//		cin >> participants;
//
//	}
//
//
//	return 0;
//}


//int main() {
//
//	int myScore = 0, expectedScore = 0;
//
//	cout << "Please enter your score : ";
//	cin >> myScore;
//
//	cout << "Please enter your expected score : ";
//	cin >> expectedScore;
//
//	if (myScore == expectedScore) {
//		cout << "I met my expectations!";
//	}
//	else if (myScore > expectedScore) {
//		cout << "I scored higher than expected.";
//	}
//	else {
//		cout << "I scored lower than expected";
//	}
//
//
//	return 0;
//}

int main() {

	char department = ' ';
	double salary = 0, raise = 0;
	double raiseAmount = 0.0;

	cout << "Please enter your salary : ";
	cin >> salary;

	cout << "Please enter your department code (A,B,C, or D) : ";
	cin >> department;
	department = toupper(department);

	switch (department) {
	case 'A':
	case 'B':
		raise = 0.02;
		break;
	case 'C':
		raise = 0.015;
		break;
	case 'D':
		raise = 0.03;
		break;
		return 0;
	default:
		cout << "Invalid entry";
		break;
	}

	cout << "You get a raise of $" << salary * raise << "!";
}