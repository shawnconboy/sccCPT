#include <iostream>
#include <iomanip>
using namespace std;

int main() {

	system("color f0");

	//display info

	cout << "\n\n\t\t***********************************" << endl;
	cout << "\t\t*                                 *" << endl;
	cout << "\t\t*          GPA Calculator         *" << endl;
	cout << "\t\t*                                 *" << endl;
	cout << "\t\t***********************************" << endl;

	//declare variables

	char gender = ' ';
	double gpa = 0.0;
	double gpaAll = 0.0;
	double gpaAllAverage = 0.0;
	double gpaMale = 0.0;
	double gpaMaleAverage = 0.0;
	double gpaFemale = 0.0;
	double gpaFemaleAverage = 0.0;
	int counterAll = 0;
	int counterMale = 0;
	int counterFemale = 0;



	//output input

	cout << "\n\n\t\tHello. Please enter your gender(F or M) : ";
	cin >> gender;
	gender = toupper(gender);

	//process

	while (true) {
		if (gender == '.') {
			cout << "\n\t\tProgram has ended." << endl;
			break;
		}

		if (gender == 'M' || gender == 'F') {
			cout << "\n\t\tPlease enter your GPA : ";
			cin >> gpa;

			if (gpa >= 0.0 && gpa <= 4.0) {

				gpaAll += gpa;
				counterAll++;

				if (gender == 'M') {
					counterMale++;
					gpaMale += gpa;
					gpaMaleAverage = gpaMale / counterMale;
				}
				else {
					counterFemale++;
					gpaFemale += gpa;
					gpaFemaleAverage = gpaFemale / counterFemale;
				}

				gpaAllAverage = gpaAll / counterAll;

				cout << "\n\n\t\tPlease enter your gender(F or M) : ";
				cin >> gender;
				gender = toupper(gender);


			}
			else {
				cout << "\n\t\tInvalid GPA entry.\n\n";
				break;
			}
		}
		else {
			cout << "\n\t\tInvalid entry.\n\n";
			break;
		}
	}

	//final output

	cout << "\t\t***********************************" << endl;
	cout << "\t\tAverage GPA : " << fixed << setprecision(2) << gpaAllAverage << endl;
	cout << "\t\tAverage Male GPA : " << fixed << setprecision(2) << gpaMaleAverage << endl;
	cout << "\t\tAverage Female GPA : " << fixed << setprecision(2) << gpaFemaleAverage << endl;
	cout << "\n\n";




	system("pause");
	return 0;
}