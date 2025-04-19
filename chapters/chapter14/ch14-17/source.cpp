#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
    system("clear");

    // input and output declarations
    ofstream outGrades;
    ifstream inGrades;

    // variables

    string name = "";
    int grade = 0;
    char userChoice = 'Y';

    // open outGrades
    outGrades.open("grades.txt", ios::app);
    if (outGrades.is_open())
    {
        cout << "grades.txt opened successfully\n";
    }
    else
    {
        cout << "grades.txt failed to open\n";
    }

    // get name and grade from user and insert into grades.txt file

    while (toupper(userChoice) == 'Y')
    {
        cout << "Please enter name: ";
        getline(cin, name);

        cout << "Please enter grade: ";
        cin >> grade;

        outGrades << name << "#" << grade << endl;

        cout << "Enter another student? (Y/N) : ";
        cin >> userChoice;
        cin.ignore();
    }

    // close and check if closed
    outGrades.close();
    if (!outGrades.is_open())
    {
        cout << "grades.txt closed successfully\n";
    }
    else
    {
        cout << "grades.txt failed to close\n";
    }

    return 0;
}
