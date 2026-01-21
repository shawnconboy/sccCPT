#include <iostream>
#include <string>

using namespace std;

int main()
{

    system("clear");

    string firstName = "";
    string lastName = "";
    string fullName = "";
    string phoneNumber = "";

    cout << "Please enter first name : ";
    getline(cin, firstName);

    cout << "Please enter last name : ";
    getline(cin, lastName);

    while (phoneNumber.length() != 10)
    {

        cout << "Please enter phone number (No dashes or spaces) : ";
        cin >> phoneNumber;
    }

    phoneNumber.insert(0, "(");
    phoneNumber.insert(4, ")");
    phoneNumber.insert(8, "-");

    fullName = firstName + " " + lastName;

    cout << "Full name is : " << fullName << endl;

    cout << "Your phone number is : " << phoneNumber << endl;

    cin.ignore();

    return 0;
}