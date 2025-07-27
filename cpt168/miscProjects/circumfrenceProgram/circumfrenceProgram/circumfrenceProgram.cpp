#include <iostream>
using namespace std;

int main() {

	//declare variables
	const float	PI = 3.14;
	float radius = 0.0;
	char choice = ' ';
	float answer = 0.0;

	//process
	cout << "Circle area or circumference calculator" << endl;

	cout << "Hello. Please enter the radius : ";
	cin >> radius;

	cout << "Enter 'A' if you need the area." << endl << "Enter 'B' if you need the circumference." << endl;
	cin >> choice;


	if (choice == 'a' || 'A') {
		answer = PI * radius * radius;
		cout << "The area of the circle is " << answer << ". Thank you.";
	}
	else {
		answer = 2 * radius * PI;
		cout << "The circumference of the circle is " << answer << ". Thank you.";
	}

	cout << endl;
	return 0;
}