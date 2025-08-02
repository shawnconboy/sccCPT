#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

int main() {
  system("clear");

  int numStudents = 0;
  const int numTests = 3;

  cout << "Please enter number of students: ";
  cin >> numStudents;

  string names[numStudents];
  double averages[numStudents];
  char letterGrades[numStudents];
  int grades[numTests];

  for (int i = 0; i < numStudents; i++) {
    double gradeTotal = 0;

    cin.ignore();  // clear newline
    cout << "\nEnter student name: ";
    getline(cin, names[i]);

    for (int j = 0; j < numTests; j++) {
      cout << "Grade for test " << j + 1 << ": ";
      cin >> grades[j];
      gradeTotal += grades[j];
    }

    averages[i] = gradeTotal / numTests;

    if (averages[i] >= 90)
      letterGrades[i] = 'A';
    else if (averages[i] >= 80)
      letterGrades[i] = 'B';
    else if (averages[i] >= 70)
      letterGrades[i] = 'C';
    else if (averages[i] >= 60)
      letterGrades[i] = 'D';
    else
      letterGrades[i] = 'F';
  }

  // Show summary
  cout << "\n--------------------------------------------\n";
  cout << left << setw(15) << "Name" << setw(10) << "Average"
       << "Grade\n";
  cout << "--------------------------------------------\n";

  for (int i = 0; i < numStudents; i++) {
    cout << left << setw(15) << names[i] << setw(10) << fixed << setprecision(2)
         << averages[i] << letterGrades[i] << endl;
  }

  return 0;
}
