#include <iostream>
using namespace std;

int main() {


	//Declare Variables

	int numStudents = 0;
	int numTeachers = 0;
	float averageStudentsPerTeacher = 0.00;

	//Process

	cout << "Hello. How many students are enrolled? : ";
	cin >> numStudents;
	cout << "Okay. And how many teachers are there? : ";
	cin >> numTeachers;

	averageStudentsPerTeacher = numStudents / numTeachers;

	cout << "Wow. Every teacher has an average of " << averageStudentsPerTeacher << " students in each class.";


	return 0;
}