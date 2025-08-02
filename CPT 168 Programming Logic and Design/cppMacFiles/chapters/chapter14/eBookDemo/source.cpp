#include <iostream>
#include <string>
#include <fstream>
#include <iomanip> // ✨ Added for formatting

using namespace std;

// ask user for book info. write info to the file
// display the book info back to the screen after user would like to enter another book to write to the file
// program ends by opening the file that was created and displaying all the book info

int main()
{
    system("clear");

    // variables

    ifstream inBookList;
    ofstream outBookList;

    outBookList.open("books.txt", ios::app);
    if (outBookList.is_open())
    {
        cout << "books.txt opened successfully" << endl;
    }
    else
    {
        cout << "books.txt failed to open" << endl;
        return 0;
    }

    string title = "";
    string author = "";
    char userChoice = 'Y';

    while (toupper(userChoice) == 'Y')
    {
        cout << "Please Enter Book Name: ";
        getline(cin, title);

        cout << "Please Enter Author: ";
        getline(cin, author);

        cout << "Title is: " << title << "\t Author Name is: " << author << endl;

        outBookList << title << '\#' << author << endl;
        cout << "Do You Have Another Book To Enter (Y/N): ";
        cin >> userChoice;
        cin.ignore();
    }
    outBookList.close();

    inBookList.open("books.txt");
    if (inBookList.is_open())
    {
        cout << "books.txt opened successfully" << endl;
    }
    else
    {
        cout << "books.txt failed to open" << endl;
        return 0;
    }

    // 🔽 ORIGINAL OUTPUT CODE (Commented Out)
    /*
    cout << "___________________________________" << endl;
    cout << "          eBook Report" << endl;

    while (!inBookList.eof())
    {
        // read the stuff from the file to print out
        getline(inBookList, title, '\#');
        getline(inBookList, author);

        cout << "Book title: " << title << "\t\tBook Author: " << author << endl;
    }
    */

    // 🔽 NEW FORMATTED OUTPUT CODE (Same while condition preserved)
    cout << "___________________________________" << endl;
    cout << "             eBook Report" << endl;
    cout << "___________________________________" << endl;
    cout << left << setw(25) << "Book Title" << setw(30) << "Author" << endl;
    cout << "-----------------------------------" << endl;

    while (!inBookList.eof())
    {
        getline(inBookList, title, '#');
        getline(inBookList, author);

        if (inBookList.fail())
            break; // prevent last line duplication if bad read

        cout << left << setw(25) << title << setw(30) << author << endl;
    }

    return 0;
}