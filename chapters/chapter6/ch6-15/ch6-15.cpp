#include <iostream>
using namespace std;

int main() {
	//declare variables
	char gender = ' ';
	char activityLevel = ' ';
	int weight = 0;
	int calories = 0;

	//output-input
	cout << "Hello. Please enter your gender (F or M) : ";
	cin >> gender;

	cout << "Please enter your activity level (A or I) : ";
	cin >> activityLevel;

	cout << "Please enter your weight : ";
	cin >> weight;

	//process

	if (gender == 'M') {
		if (activityLevel == 'A') {
			calories = weight * 17;
		}
		else if(activityLevel == 'I') {
			calories = weight * 15;
		}
		else {
			cout << "Invalid entry.";
		}
	}
	else if (gender == 'F') {
		if (activityLevel == 'A') {
			calories = weight * 15;
		}
		else if (activityLevel == 'I') {
			calories = weight * 13;
		}
		else {
			cout << "Invalid entry";
		}
	}
	else {
		cout << "Invalid entry";
	}

	//output
	cout << "Your daily calorie intake should be " << calories << " calories.";
	cout << endl;
}