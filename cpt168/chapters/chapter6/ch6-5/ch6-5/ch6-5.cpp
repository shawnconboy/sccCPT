#include <iostream>
using namespace std;

int main() {

	//declare variables
	int participants;

	//output-input
	cout << "Please enter number of participants : ";
	cin >> participants;

	//process

	if (participants >= 75) {
		cout << "Use the Kantoon room.";
	}
	else if (participants >= 40 && participants <= 74) {
		cout << "Use the Harris room.";
	} 
	else if (participants >= 10 && participants <= 39) {
			cout << "Use the small conference room.";
	}
	else {
			cout << "Cancel the seminar.";
	}
	cout << endl;
	return 0;
}