#include <iostream>

using namespace std;

void getPoints();

int main()
{

    int option = 0;

    system("clear");

    cout << "\n**********************" << endl;
    cout << "*                    *" << endl;
    cout << "*  NBA Stat Tracker  *" << endl;
    cout << "*                    *" << endl;
    cout << "**********************" << endl;

    cout << "\nPlease pick an option." << endl;

    cout << "1 -- Points" << endl;
    cout << "2 -- Rebounds" << endl;
    cout << "3 -- Assists" << endl;

    cin >> option;

    return 0;
}

void getPoints()
{

    int points = 0;
    int totalPoints = 0;
    double pointAverage = 0;

    for (int i = 0; i < 5; i++)
    {
        cout << "Please enter number of points : ";
        cin >> points;
        totalPoints += points;
    }
    pointAverage = totalPoints / 5;
    cout << "Point Average : " << pointAverage << endl
         << endl;
}