#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{

    system("clear");

    char menuChoice;

    cout << "Would you like to (R)ead file or (W)rite new names? ";
    cin >> menuChoice;
    cin.ignore(); // clear the newline after menu input

    if (toupper(menuChoice) == 'R')
    {
        // read from Names.txt print out names and ages

        int studentAge = 0;
        string studentName = "";

        ifstream inNames;

        inNames.open("Names.txt");
        if (inNames.is_open())
        {
            cout << "File opened successfully." << endl;
        }
        else
        {
            cout << "File failed to open." << endl;
        }

        // read until the end of the file
        while (getline(inNames, studentName, '#'))
        {
            inNames >> studentAge;

            if (inNames.fail())
            {
                break;
            }

            inNames.ignore(); // ignore the newline after the number

            cout << "Student name: " << studentName << endl;
            cout << "Student age: " << studentAge << endl;
        }

        inNames.close();
    }
    else if (toupper(menuChoice) == 'W')
    {
        // write student names to a file and their ages.

        // variables

        string studentNameWrite = "";
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
            getline(cin, studentNameWrite);

            cout << "Please enter age : ";
            cin >> age;

            // write it to the file

            cout << "Student name is: " << studentNameWrite << endl;

            outNames << studentNameWrite << "#" << age << endl;

            cout << "Would you like to enter another name? (Y/N): ";
            cin >> userChoice;
            cin.ignore();
        }

        // close the file

        outNames.close();
    }
    else
    {
        cout << "Invalid option selected. Please run the program again." << endl;
    }

    return 0;
}
