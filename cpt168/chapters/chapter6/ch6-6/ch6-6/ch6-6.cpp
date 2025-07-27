#include <iostream>
using namespace std;

int main() {
	//declare variables
	int myScore;
	int expectedScore;

	//output-input
	cout << "Please enter your score : ";
	cin >> myScore;

	cout << "Please enter your expected score : ";
	cin >> expectedScore;

	//process
	if (myScore > expectedScore) {
		cout << "I scored higher than expected.";
	}
	else if (myScore == expectedScore) {
		cout << "I met my expectations.";
		}
	else {
		cout << "I scored lower than expected.";
	}

	cout << endl;

	return 0;
}