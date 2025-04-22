#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>

using namespace std;

int main()
{
    system("clear");
    // variables

    int numStudents = 0;
    int testScores[5] = {0};
    double average = 0.0;
    int grade = 0;
    string name = "";
    char userChoice = 'Y';

    // fstream declarations
    ofstream outGrades;
    ifstream inGrades;

    outGrades.open("grades.txt");

    if (outGrades.is_open())
    {
        cout << "grades.txt opened successfully" << endl;
    }
    else
    {
        cout << "grades.txt failed to open" << endl;
    }

    cout << "____________________________________________________________________" << endl
         << endl;

    while (toupper(userChoice) == 'Y')
    {
        cout << "Please enter student name: ";
        getline(cin, name);

        cout << "Enter student grade: ";
        cin >> grade;

        outGrades << "Student Name is " << name << "\tStudent Grade " << grade << endl;

        cout << "Enter another student's grade? (Y/N): ";
        cin >> userChoice;
        cin.ignore();
    }

    return 0;
}