#include <fstream>
#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

int main() {

  system("clear");

  // variables

  string item, category, quantity, price, revenue, rating = "";

  // fstream declarations

  ifstream inSales;

  inSales.open("sales.txt");

  if (inSales.is_open()) {
    cout << "sales.txt opened successfully\n\n" << endl;
  } else {
    cout << "sales.txt failed to open" << endl;
  }

  cout << left << setw(10) << "Item" << setw(10) << "Category" << setw(10)
       << "Quantity" << setw(7) << "Price" << setw(10) << "Revenue" << setw(10)
       << "Rating" << endl;

  cout << left << setw(10) << "________" << setw(10) << "________" << setw(10)
       << "________" << setw(7) << "_____" << setw(10) << "________" << setw(10)
       << "________" << endl
       << endl
       << endl;

  ofstream outReport;

  outReport.open("report.txt");

  outReport << left << setw(10) << "Item" << setw(10) << "Category" << setw(10)
            << "Quantity" << setw(7) << "Price" << setw(10) << "Revenue"
            << setw(10) << "Rating" << endl;

  outReport << left << setw(10) << "________" << setw(10) << "________"
            << setw(10) << "________" << setw(7) << "_____" << setw(10)
            << "________" << setw(10) << "________" << endl
            << endl
            << endl;

  while (getline(inSales, item, '#'), getline(inSales, category, '#'),
         getline(inSales, quantity, '#'), getline(inSales, price)) {

    double revenueDouble = stod(quantity) * stod(price);

    int qty = stod(quantity);

    if (qty > 50) {
      rating = "High";
    } else if (qty > 10) {
      rating = "Medium";
    } else {
      rating = "Low";
    }

    cout << left << setw(10) << item << setw(10) << category << setw(10)
         << quantity << setw(7) << price << setw(10) << revenueDouble
         << setw(10) << rating << endl;

    outReport << left << setw(10) << item << setw(10) << category << setw(10)
              << quantity << setw(7) << price << setw(10) << revenueDouble
              << setw(10) << rating << endl;
  }

  return 0;
}