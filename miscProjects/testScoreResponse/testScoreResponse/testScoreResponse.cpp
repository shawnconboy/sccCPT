#include <iostream>
using namespace std;

int main() {

	//declare variables
	int testScore = 0;

	//output-input
	cout << "Please enter your test score : ";
	cin >> testScore;

	//process
	if (testScore >= 90) {
		cout << "Great Score!";
	}
	else if (testScore >= 70 && testScore <= 89) {
		cout << "Good score.";
	}
	else if (testScore < 70) {
		cout << "Retake the test.";
	}

	cout << endl;


	return 0;
}