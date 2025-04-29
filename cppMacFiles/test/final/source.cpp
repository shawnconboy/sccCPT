#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>

using namespace std;

int main()
{

    system("clear");

    // variables

    string firstName = "";
    string lastName = "";
    string acres = "";
    string zipCode = "";
    string year = "";
    string state = "";
    string oddOrEven = "";
    int count = 0;

    double tax = 0.0;

    bool isEven = true;
    string isEvenString = "";

    // fstream declarations
    ifstream inAcres;
    ofstream outReport;

    // create file

    outReport.open("acres.txt", ios::app);

    if (outReport.is_open())
    {
        cout << "acres.txt opened successfully" << endl;
    }
    else
    {
        cout << "acres.txt failed to open" << endl;
    }

    outReport.close();
    if (outReport.is_open())
    {
        cout << "acres.txt failed to close" << endl;
    }
    else
    {
        cout << "acres.txt closed successfully" << endl;
    }

    // *******************************************

    inAcres.open("acres.txt");

    if (inAcres.is_open())
    {
        cout << "acres.txt opened successfully\n"
             << endl;
    }
    else
    {
        cout << "acres.txt failed to open" << endl;
    }

    // do logic here

    /*while (getline(inAcres, firstName, '#') && getline(inAcres, lastName, '#') && getline(inAcres, acresString, '#') && getline(inAcres, zipCode, '#') && getline(inAcres, year)) {
        cout << left << setw(10) << firstName
            << setw(12) << lastName
            << setw(5) << acresString
            << setw(12) << zipCode
            << setw(6) << year;
    }*/

    cout << left << setw(10) << "Last Name" << "\t"
         << setw(12) << "First Initial" << "\t"
         << setw(8) << "State" << "\t"
         << setw(12) << "Zip Code" << "\t"
         << setw(7) << "Acres" << "\t"
         << setw(8) << "Tax" << "\t"
         << setw(6) << "Odd/Even" << endl;

    cout << left << setw(10) << "_________" << "\t" << setw(12) << "____________" << "\t" << setw(8) << "________" << "\t" << setw(12) << "____________" << "\t" << setw(7) << "_______" << "\t" << setw(8) << "________" << "\t" << setw(6) << "______" << endl;

    while (!inAcres.eof())
    {

        getline(inAcres, firstName, '#');
        getline(inAcres, lastName, '#');
        getline(inAcres, acres, '#');
        getline(inAcres, zipCode, '#');
        getline(inAcres, year);

        string firstInitial = firstName.substr(0, 1) + ".";

        if (zipCode.substr(0, 1) == "9")
        {
            tax = stod(acres) * 500;
            state = "CA";
        }
        else if (zipCode.substr(0, 1) == "2")
        {
            tax = stod(acres) * 100;
            state = "SC";
        }
        else
        {
            tax = stod(acres) * 200;
            state = "FL";
        }

        int yearInt = stoi(year);

        if (yearInt % 2 == 0)
        {
            isEvenString = "Even";
        }
        else if (yearInt % 2 == 1)
        {
            isEvenString = "Odd";
        }

        // if (zipCode.find(" ", 0))
        // {
        //     zipCode.insert(6, "8623");
        // }

        cout << left << setw(10) << lastName << "\t" << setw(12) << firstInitial << "\t" << setw(8) << state << "\t" << setw(12) << zipCode << "\t" << setw(7) << acres << "\t" << setw(8) << fixed << setprecision(2) << tax << "\t" << setw(6) << isEvenString << endl
             << endl;

        count++;
    }

    cout << "Total Count = " << count << endl
         << endl;

    inAcres.close();

    if (inAcres.is_open())
    {
        cout << "acres.txt failed to close" << endl;
    }
    else
    {
        cout << "acres.txt closed successfully" << endl;
    }

    outReport.open("report.txt");

    if (outReport.is_open())
    {
        cout << "report.txt is open";
    }
    else
    {
        cout << "report.txt failed to open";
    }

    // unsure of what to do here at the moment.

    // also ran out of time with baby sitter. till next time, buckaroos.

    outReport.close();

    cout << "Thank You" << endl;

    system("pause");
    return 0;
}