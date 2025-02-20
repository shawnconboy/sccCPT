#include <iostream>
using namespace std;

int main() {

	int num = 0;
	const int myFavNum = 7;
	string outputMessage = "";



	cout << "Hello. Please enter your a number : ";
	cin >> num;

	if (num > 0) {
		if (num % 2 == 1) {
			outputMessage = "Number is odd.\n";
			if (num == 7) {
				outputMessage += "You found my favorite number!\n";
			}
		}
		else {
			outputMessage = "Number is even.";
		}
	}
	else {
		if (num % 5 == 0) {
			outputMessage = "Number is divisible by 5.";
		}
		else {
			outputMessage = "Number is not divisible by 5.";
		}
	}

	cout << outputMessage;
}