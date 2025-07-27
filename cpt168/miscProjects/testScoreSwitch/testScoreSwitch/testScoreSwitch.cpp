#include <iostream>
using namespace std;

int main() {

	//declare variables
	int testScore = 0;

	//output-input
	cout << "Please enter your test score : ";
	cin >> testScore;

	//process

	switch (testScore) {
	case testScore >= 90:
		cout << "Great Score";
		break;
	case testScore >= 70 && testScore <= 89:
		cout << "Good Score";
		break;
	case testScore >= 0 && testScore <= 69:
		cout << "Retake test";
		break;
	default:
		cout << "Invalid test score.";
		break;
	}



	return 0;
}