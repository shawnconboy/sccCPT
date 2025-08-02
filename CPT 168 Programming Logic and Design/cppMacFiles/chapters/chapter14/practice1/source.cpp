#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>

using namespace std;

int main()
{

    system("clear");

    string name = "";
    string firstName = "";
    string lastName = "";
    string email = "";
    string loweredEmail = "";
    int numStudents = 0;

    ifstream inStudents;
    ofstream outStudents;

    outStudents.open("students.txt", ios::app);

    if (outStudents.is_open())
    {
        cout << "outStudents.txt opened successfully\n\n";
    }
    else
    {
        cout << "outStudents.txt failed to open\n\n";
    }

    cout << "Please enter number of students: ";
    cin >> numStudents;
    cin.ignore();

    for (int i = 0; i < numStudents; i++)
    {
        cout << "\n\nEnter student " << i + 1 << "'s information." << endl;

        cout << "Please enter your first name: ";
        getline(cin, firstName);

        cout << "Please enter your last name: ";
        getline(cin, lastName);

        name = firstName + " " + lastName;

        outStudents << firstName << '#' << lastName << endl;
    }

    outStudents.close();

    cout << "\n\n";
    inStudents.open("students.txt");
    if (inStudents.is_open())
    {
        cout << "outStudents.txt opened successfully\n\n";
    }
    else
    {
        cout << "outStudents.txt failed to open\n\n";
    }

    cout << left << setw(15) << "First Name"
         << setw(15) << "Last Name"
         << setw(30) << "Email" << endl;

    cout << left << setw(15) << "____________"
         << setw(15) << "____________"
         << setw(30) << "______________________________" << endl;

    while (getline(inStudents, firstName, '#'), getline(inStudents, lastName))
    {

        string firstInitial = firstName.substr(0, 1);

        email = firstInitial + lastName + "@sccsc.edu";

        for (int i = 0; i < email.length(); i++)
        {
            email[i] = tolower(email[i]);
        }

        cout << left << setw(15) << firstName
             << setw(15) << lastName
             << setw(30) << email << endl;
    }
    inStudents.close();

    cout << "Thank you";

        return 0;
}