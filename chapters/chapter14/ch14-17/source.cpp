#include <iostream>
#include <fstream>
#include <string>
#include <limits>

using namespace std;

// File streams
ofstream outGrades;
ifstream inGrades;

// Variables
string name = "";
int grade = 0;
char userChoice = 'Y';

// Function declarations
void outOpen();
void outWriteData();
void outClose();

void inOpen();
void inPullData();

int main()
{
    system("clear");

    outOpen();
    outWriteData();
    outClose();

    inOpen();
    inPullData();

    return 0;
}

void outOpen()
{
    outGrades.open("grades.txt", ios::app);
    if (outGrades.is_open())
    {
        cout << "grades.txt opened successfully\n";
        cout << "_________________________________________\n\n";
    }
    else
    {
        cout << "grades.txt failed to open\n";
        cout << "_________________________________________\n";
    }
}

void outWriteData()
{
    while (toupper(userChoice) == 'Y')
    {
        cout << "Please enter name: ";
        getline(cin, name);

        cout << "Please enter grade: ";
        cin >> grade;

        outGrades << name << "#" << grade << endl;

        cout << "Enter another student? (Y/N): ";
        cin >> userChoice;
        cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Flush leftover newline
    }
}

void outClose()
{
    outGrades.close();
    if (!outGrades.is_open())
    {
        cout << "grades.txt closed successfully\n";
        cout << "_________________________________________\n";
    }
    else
    {
        cout << "grades.txt failed to close\n";
        cout << "_________________________________________\n";
    }
}

void inOpen()
{
    inGrades.open("grades.txt");
    if (inGrades.is_open())
    {
        cout << "grades.txt opened successfully\n";
        cout << "_________________________________________\n";
    }
    else
    {
        cout << "grades.txt failed to open\n";
        cout << "_________________________________________\n";
    }
}

void inPullData()
{
    cout << "Grade Report\n";
    cout << "_________________________________________\n\n";
    cout << "Student Name\t\tStudent Grade\n";
    cout << "_________________________________________\n";

    while (getline(inGrades, name, '#') && inGrades >> grade)
    {
        cout << name << "\t\t\t" << grade;
    }

    cout << endl;
}
