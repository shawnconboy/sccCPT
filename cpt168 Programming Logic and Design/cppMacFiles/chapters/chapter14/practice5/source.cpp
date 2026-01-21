#include <fstream>
#include <iomanip>
#include <iostream>
#include <string>

using namespace std;
int main() {

  system("clear");

  // declare variables
  int userChoice = 0;
  int grades[5] = {0};
  char letterGrade = ' ';
  double gradeTotal = 0;
  double average = 0;
  string name = "";

  // declare streams
  ofstream outStudents;

  // starting code. getting input from user

  outStudents.open("grades.txt", ios::app);

  if (outStudents.is_open()) {
    cout << "grades.txt opened successfully\n\n";
  } else {
    cout << "grades.txt failed to open\n\n";
  }

  cout << "How many students would you like to enter? : ";
  cin >> userChoice;

  outStudents << left << setw(15) << "Name" << setw(8) << "Grade" << endl;

  for (int i = 0; i < userChoice; i++) {

    gradeTotal = 0;

    cout << "Please enter name: ";
    cin >> name;

    cout << "Student " << i + 1 << ": " << endl;

    for (int x = 0; x < 5; x++) {
      cout << "Please enter test " << x + 1 << " grade: ";
      cin >> grades[x];

      gradeTotal += grades[x];
    }

    average = gradeTotal / 5;

    if (average >= 90) {
      letterGrade = 'A';
    } else if (average >= 80) {
      letterGrade = 'B';
    } else if (average >= 70) {
      letterGrade = 'C';
    } else if (average >= 60) {
      letterGrade = 'D';
    } else {
      letterGrade = 'F';
    }

    cout << "Average: " << average << endl;

    outStudents << left << setw(15) << name << setw(8) << letterGrade << endl;
    cout << endl;
  }

  return 0;
}