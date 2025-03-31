#include <iostream>
#include <string>
using namespace std;

int main()
{

    system("clear");

    cout << "*****************************" << endl;
    cout << "*       Shawn Conboy        *" << endl;
    cout << "*       CPT 168 A01H        *" << endl;
    cout << "*    LAB 9 STRING MANIP     *" << endl;
    cout << "*****************************" << endl;

    char userChoice = 'Y';

    while (toupper(userChoice) == 'Y')
    {
        string firstName = "", lastName = "", phoneNumber = "", ssn = "";

        // takeIn information *********************************************************

        cout << "Enter your first name: ";
        getline(cin, firstName);

        cout << "Enter your last name: ";
        getline(cin, lastName);

        do
        {
            cout << "Enter your 10 digit phone number (with no dashes or parenthesis): ";
            getline(cin, phoneNumber);
        } while (phoneNumber.length() != 10);

        do
        {
            cout << "Enter 9 digit SSN (with no dashes or parenthesis): ";
            getline(cin, ssn);
        } while (ssn.length() != 9);

        // return information *********************************************************
        string fullName = firstName + " " + lastName;
        cout << "\nYour full name is: " << fullName << endl;

        string reversedName = string(fullName.rbegin(), fullName.rend());
        cout << "Your reversed full name is: " << reversedName << endl;

        phoneNumber = phoneNumber.insert(0, "(");
        phoneNumber = phoneNumber.insert(4, ") ");
        phoneNumber = phoneNumber.insert(9, "-");
        cout << "Your phone number is: " << phoneNumber << endl;

        ssn = ssn.insert(3, "-");
        ssn = ssn.insert(6, "-");
        cout << "Your social security number: " << ssn << endl;

        cout << "\nWould you like to enter person's data? (Y or N)  ";
        cin >> userChoice;
        cin.ignore();
    }

    cout << "\nThank You\n\n";
    return 0;
}
