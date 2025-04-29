#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>

using namespace std;

int main()
{

    system("clear");

    // declare variables
    string firstName, lastName, fullName = "";
    int score = 0;
    int totalStudents = 0;

    // declare fstream
    ofstream outStudents;
    ifstream inStudents;

    // creating honorRoll.txt
    outStudents.open("honorRoll.txt");
    if (outStudents.is_open())
    {
        cout << "honorRoll.txt opened successfully" << endl;
    }
    else
    {
        cout << "honorRoll.txt failed to open" << endl;
    }
    outStudents.close();

    inStudents.open("students.txt");

    if (inStudents.is_open())
    {
        cout << "students.txt opened successfully" << endl;
    }
    else
    {
        cout << "students.txt failed to open" << endl;
    }

    while (getline(inStudents, firstName, '#'), getline(inStudents, lastName, '#'), inStudents >> score)
    {
        fullName = firstName + " " + lastName;
        cout << fullName << score;
    }

    return 0;
}