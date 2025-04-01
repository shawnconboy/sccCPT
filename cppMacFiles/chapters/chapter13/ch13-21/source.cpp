#include <iostream>
#include <string>
using namespace std;

int main()
{
    system("clear");

    string city = "", state = "", zip = "";
    char userChoice = 'Y';

    while (toupper(userChoice) == 'Y')
    {
        system("clear");
        cout << "Please enter city: ";
        getline(cin, city);

        cout << "Please enter state: ";
        getline(cin, state);

        cout << "Please enter zip: ";
        getline(cin, zip);

        string sentence = city + ", " + state + ", " + zip;

        cout << sentence << endl;

        cout << "\nWould you like to enter another location? (Y/N) ";
        cin >> userChoice;
        cin.ignore();
    }

    cout << "\nProgram ended.  Thank You." << endl;

    return 0;
}