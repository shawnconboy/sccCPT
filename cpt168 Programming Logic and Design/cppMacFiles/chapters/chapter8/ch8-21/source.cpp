#include <iostream>
using namespace std;

void clearScreen()
{
#ifdef _WIN32
    system("CLS");
#else
    system("clear");
#endif
}

int main()
{
    clearScreen();

    int reviewerCount = 0;
    int rating = 0;

    cout << "How many reviewers? ";
    cin >> reviewerCount;
    cout << "Movie ratings must be from 1 to 5." << endl;

    for (int i = 0; i < reviewerCount; i++)
    {
        cout << "Reviewer " << i + 1 << " rating: ";
        cin >> rating;

        cout << "                       ";

        if (rating >= 1 && rating <= 5)
        {
            for (int j = 0; j < rating; j++)
            {
                cout << "* ";
            }
        }
        else
        {
            cout << "Invalid entry.";
        }

        cout << endl;
    }

    cout << "Program has ended." << endl;
    return 0;
}
