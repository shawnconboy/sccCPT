#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{

    ofstream outGrades;
    ifstream inGrades;

    string name = "";
    int grade = 0;

    outGrades.open("grades.txt");

    if (outGrades.is_open())
    {
        cout << "grades.txt opened successfully\n";
    }
    else
    {
        cout << "grades.txt failed to open\n";
    }

    cout << "Please enter name: ";
    getline(cin, name);

    cout << "Please enter grade: ";
    cin >> grade;

    return 0;
}