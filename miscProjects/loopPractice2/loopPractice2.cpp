#include <iostream>
using namespace std;

int main() {

	/*	Counting to N – Ask the user for a number and print all numbers from 1 to that	number.

		Print a Word Multiple Times – Ask the user for a word and a number, then print the word that many times.

		Even Numbers Only – Print all even numbers from 1 to 20 using a loop.
	*/




	//priming read

	int num = 0;
	int counter = 0;

	cout << "Please enter a number : ";
	cin >> num;

	for (int i = 0; i < num; i++) {
		cout << i + num << endl;
	}



	return 0;
}