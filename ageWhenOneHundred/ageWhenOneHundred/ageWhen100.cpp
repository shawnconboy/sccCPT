#include <iostream>
using namespace std;

int main()
{
	//Variables
	int yearBorn = 0;
	int ageAt100 = 0;
	int currentAge = 0;
	int currentYear = 2025;
	string name = "name";
	//Process
	cout << "Hello, What's your name?" << endl << endl;
	cin >> name;
	cout << endl << endl;
	cout << "What year were you born?" << endl << endl;
	cin >> yearBorn;
	cout << endl;
	cout << "Okay, " << name << ". If you were born in "
		<< yearBorn << " , that would make you " << currentYear - yearBorn << " years old." << endl << endl;
	currentAge = currentYear - yearBorn;
	cout << "You'll turn 100 years old in " << 100 - currentAge << " years. ";
	ageAt100 = 100 - currentAge;
	cout << ageAt100 + currentYear << " to be exact." << endl;

	return 0;
}

