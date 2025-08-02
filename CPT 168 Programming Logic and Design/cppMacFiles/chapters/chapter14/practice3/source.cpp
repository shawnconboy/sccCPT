#include <fstream>
#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

int main() {
  system("clear");

  // variables
  string title, authorFirst, authorLast, numPages, year, isbn, era, length;

  // fstream declarations
  ofstream outBooks;
  ifstream inBooks;

  // create books.txt file *****************************************
  outBooks.open("books.txt", ios::app);

  if (outBooks.is_open()) {
    cout << "books.txt opened successfully\n\n";
  } else {
    cout << "books.txt failed to open\n\n";
  }

  outBooks.close();

  // open books.txt file to extract data **************************
  inBooks.open("books.txt");

  if (inBooks.is_open()) {
    cout << "books.txt opened successfully\n\n";
  } else {
    cout << "books.txt failed to open\n\n";
  }

  // headers
  cout << left << setw(25) << "Title" << setw(20) << "Author" << setw(6)
       << "Year" << setw(8) << "Pages" << setw(8) << "Length" << setw(10)
       << "Era" << setw(16) << "ISBN" << endl
       << endl;

  outBooks.open("report.txt");

  outBooks << "Book Report" << endl;
  outBooks << "__________________________________________________" << endl
           << endl;

  outBooks << left << setw(25) << "Title" << setw(20) << "Author" << setw(6)
           << "Year" << setw(8) << "Pages" << setw(8) << "Length" << setw(10)
           << "Era" << setw(16) << "ISBN" << endl
           << endl;

  // LOOP: keep reading while there's another line of data
  while (getline(inBooks, title, '#') && getline(inBooks, authorFirst, '#') &&
         getline(inBooks, authorLast, '#') && getline(inBooks, year, '#') &&
         getline(inBooks, numPages, '#') && getline(inBooks, isbn)) {

    string fullName = authorFirst + " " + authorLast;

    if (stoi(year) < 2000) {
      era = "Classic";
    } else {
      era = "Modern";
    }

    int pages = stoi(numPages);

    if (pages > 400) {
      length = "Long";
    } else if (pages < 200) {
      length = "Short";
    } else {
      length = "Medium";
    }

    cout << left << setw(25) << title << setw(20) << fullName << setw(6) << year
         << setw(8) << pages << setw(8) << length << setw(10) << era << setw(16)
         << isbn << endl;

    outBooks << left << setw(25) << title << setw(20) << fullName << setw(6)
             << year << setw(8) << pages << setw(8) << length << setw(10) << era
             << setw(16) << isbn << endl;
  }

  inBooks.close();
  outBooks.close();

  return 0;
}
