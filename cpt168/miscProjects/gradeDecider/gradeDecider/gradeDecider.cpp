#include <iostream>
using namespace std;

int main() {
	int grade = 0;

	cout << "Enter your grade : ";
	cin >> grade;

	if (grade >= 90) {
		cout << "A" << endl;
	}
	else if (grade >= 80) {
		cout << "B" << endl;
	}
	else if (grade >= 70) {
		cout << "C" << endl;
	}
	else if (grade >= 60) {
		cout << "D" << endl;
	}
	else {
		cout << "F" << endl;
	}
	return 0;
}