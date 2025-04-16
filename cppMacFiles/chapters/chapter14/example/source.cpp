#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{

    system("clear");

    // read from Names.txt print out names and ages

    // int studentAge = 0;
    // string studentName = "";

    // ifstream inNames;

    // inNames.open("Names.txt");
    // if (inNames.is_open())
    // {
    //     cout << "Open" << endl;
    // }
    // else
    // {
    //     cout << "Failed" << endl;
    // }

    // getline(inNames, studentName, "\#");
    // inNames >> studentName;

    // getline(inNames, studentAge);
    // inNames >> studentAge;

    // inNames.close();

    // write student names to a file and their ages.

    // variables

    string studentName = "";

    int age = 0;

    char userChoice = 'Y';

    // creat file object
    ofstream outNames;

    // open the output file
    outNames.open("Names.txt", ios::app);

    // check to see if file opened.

    if (outNames.is_open())
    {
        cout << "Success." << endl;
    }
    else
    {
        cout << "File failed to open." << endl;
    }

    while (toupper(userChoice) == 'Y')
    {

        cout << "Please enter your name : ";
        getline(cin, studentName);

        cout << "Please enter age : ";
        cin >> age;

        // write it to the file

        cout << "Student name is: " << studentName << endl;

        outNames << studentName << "#" << age << endl;

        cout << "Would you like to enter another name? (Y/N): ";
        cin >> userChoice;
        cin.ignore();
    }

    // close the file

    outNames.close();

    return 0;
}