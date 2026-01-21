#include <fstream>
#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

int main() {
  system("clear");

  string firstName = "", lastName = "", acres = "", zipCode = "", year = "",
         state = "", oddOrEven = "";
  int count = 0;
  double tax = 0.0;
  bool isEven = true;
  string isEvenString = "";

  ifstream inAcres("acres.txt");
  ofstream outReport("report.txt");

  if (!inAcres) {
    cout << "acres.txt failed to open" << endl;
    return 1;
  }
  if (!outReport) {
    cout << "report.txt failed to open" << endl;
    return 1;
  }

  cout << left << setw(10) << "Last Name" << "\t" << setw(12) << "First Initial"
       << "\t" << setw(8) << "State" << "\t" << setw(12) << "Zip Code" << "\t"
       << setw(7) << "Acres" << "\t" << setw(8) << "Tax" << "\t" << setw(6)
       << "Odd/Even" << endl;

  cout << left << setw(10) << "_________" << "\t" << setw(12) << "____________"
       << "\t" << setw(8) << "________" << "\t" << setw(12) << "____________"
       << "\t" << setw(7) << "_______" << "\t" << setw(8) << "________" << "\t"
       << setw(6) << "______" << endl;

  // Write the same headers to report.txt
  outReport << left << setw(10) << "Last Name" << "\t" << setw(12)
            << "First Initial" << "\t" << setw(8) << "State" << "\t" << setw(12)
            << "Zip Code" << "\t" << setw(7) << "Acres" << "\t" << setw(8)
            << "Tax" << "\t" << setw(6) << "Odd/Even" << endl;

  outReport << left << setw(10) << "_________" << "\t" << setw(12)
            << "____________" << "\t" << setw(8) << "________" << "\t"
            << setw(12) << "____________" << "\t" << setw(7) << "_______"
            << "\t" << setw(8) << "________" << "\t" << setw(6) << "______"
            << endl;

  while (getline(inAcres, firstName, '#') && getline(inAcres, lastName, '#') &&
         getline(inAcres, acres, '#') && getline(inAcres, zipCode, '#') &&
         getline(inAcres, year)) {
    string firstInitial = firstName.substr(0, 1) + ".";

    if (zipCode.substr(0, 1) == "9") {
      tax = stod(acres) * 500;
      state = "CA";
    } else if (zipCode.substr(0, 1) == "2") {
      tax = stod(acres) * 100;
      state = "SC";
    } else {
      tax = stod(acres) * 200;
      state = "FL";
    }

    int yearInt = stoi(year);

    isEvenString = (yearInt % 2 == 0) ? "Even" : "Odd";

    // Console Output
    cout << left << setw(10) << lastName << "\t" << setw(12) << firstInitial
         << "\t" << setw(8) << state << "\t" << setw(12) << zipCode << "\t"
         << setw(7) << acres << "\t" << setw(8) << fixed << setprecision(2)
         << tax << "\t" << setw(6) << isEvenString << endl
         << endl;

    // Report File Output
    outReport << left << setw(10) << lastName << "\t" << setw(12)
              << firstInitial << "\t" << setw(8) << state << "\t" << setw(12)
              << zipCode << "\t" << setw(7) << acres << "\t" << setw(8) << fixed
              << setprecision(2) << tax << "\t" << setw(6) << isEvenString
              << endl
              << endl;

    count++;
  }

  cout << "Total Count = " << count << endl << endl;
  outReport << "Total Count = " << count << endl << endl;

  inAcres.close();
  outReport.close();

  cout << "Thank You" << endl;

  return 0;
}
