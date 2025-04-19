#include <iostream>
#include <fstream>
#include <string>

using namespace std;

// input and output declarations
ofstream outGrades;
ifstream inGrades;

// variables

string name = "";
int grade = 0;
char userChoice = 'Y';

// functions

void outOpen();
void outClose();
void outWriteData();

void inOpen();

int main()
{
    system("clear");

    outOpen();
    outWriteData();
    outClose();

    inOpen();

    return 0;
}

void outOpen()
{
    outGrades.open("grades.txt", ios::app);
    if (outGrades.is_open())
    {
        cout << "grades.txt opened successfully\n";
    }
    else
    {
        cout << "grades.txt failed to open\n";
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

        cout << "Enter another student? (Y/N) : ";
        cin >> userChoice;
        cin.ignore();
    }
}

void outClose()
{
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
}

void inOpen()
{
    inGrades.open("grades.txt");
    if (inGrades.is_open())
    {
        cout << "grades.txt opened successfully\n";
    }
    else
    {
        cout << "grades.txt failed to open\n";
    }
}