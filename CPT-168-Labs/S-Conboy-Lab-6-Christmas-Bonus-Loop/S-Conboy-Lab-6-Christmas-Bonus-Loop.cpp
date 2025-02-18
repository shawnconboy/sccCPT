#include <iostream>
#include <iomanip>
using namespace std;

int main() {

    system("color f0");

    // display my information
    cout << "\t\t**********************************" << endl;
    cout << "\t\t*         Shawn Conboy           *" << endl;
    cout << "\t\t*         CPT 168 A01H           *" << endl;
    cout << "\t\t*    Lab 6 Christmas Bonus Loop  *" << endl;
    cout << "\t\t**********************************" << endl;

    // declare variables
    double salary = 0.0;
    int yearsWorked = 0;
    double bonus = 0.0;

    // output input
    cout << "Hello. Please enter number of years worked (0 or less, 99 or over will exit): ";
    cin >> yearsWorked;

    // process
    while (yearsWorked > 0 && yearsWorked < 99) {

        // output input
        cout << "Please enter your gross pay per year: ";
        cin >> salary;

        // process
        if (yearsWorked < 5) {
            bonus = salary * 0.01;
        }
        else {
            bonus = salary * 0.02;
        }

        // output input
        cout << fixed << setprecision(2);
        cout << "Your bonus is: $" << bonus << endl << endl;

        // output input
        cout << "Please enter number of years worked (0 to exit): ";
        cin >> yearsWorked;
    }

    cout << "Thank you! Program No Longer Running." << endl;
    system("pause");
    return 0;
}
