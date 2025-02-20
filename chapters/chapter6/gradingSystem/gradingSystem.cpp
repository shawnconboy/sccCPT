#include <iostream>
using namespace std;

int main() {

	//variables
	int grade = 0;
	char extraCredit = ' ';
	char letterGrade = ' ';

	//output input

	cout << "Please enter your grade : ";
	cin >> grade;

	cout << "Do you have extra credit? : ";
	cin >> extraCredit;
	extraCredit = toupper(extraCredit);

	//process

	if (extraCredit == 'Y') {
		if (grade >= 58 && grade <= 69) {
			grade += 2;
		}
	}

	if (grade >= 90) {
		letterGrade = 'A';
	} else if (grade >= 80) {
		letterGrade = 'B';
	}
	else if (grade >= 70) {
		letterGrade = 'C';
	}
	else if (grade >= 60) {
		letterGrade = 'D';
	}
	else if (grade >= 50) {
		letterGrade = 'F';
	}

	cout << "You recieved " << grade << "! That a " << letterGrade << ".";
}