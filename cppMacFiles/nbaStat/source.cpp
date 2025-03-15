#include <iostream>

using namespace std;

void getPoints();
void getRebounds();
void getAssists();

int main()
{

    int option = 0;
    char runAgain = ' ';

    system("clear");

    do
    {
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
        cout << "4 -- All" << endl
             << endl;

        cout << "Option : ";
        cin >> option;

        if (option < 0 || option > 4)
        {
            cout << "Invalid Option" << endl;
        }
        else if (option == 1)
        {
            getPoints();
        }
        else if (option == 2)
        {
            getRebounds();
        }
        else if (option == 3)
        {
            getAssists();
        }
        else if (option == 4)
        {
            getRebounds();
        }

        cout << "Would you like to run again? : ";
        cin >> runAgain;
        runAgain = toupper(runAgain);

    } while (runAgain == 'Y');

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

void getRebounds()
{

    int rebounds = 0;
    int totalRebounds = 0;
    double reboundAverage = 0;
    for (int i = 0; i < 5; i++)
    {
        cout << "Please enter number of rebounds : ";
        cin >> rebounds;
        totalRebounds += rebounds;
    }
    reboundAverage = totalRebounds / 5;
    cout << "Rebound Average : " << reboundAverage << endl
         << endl;
}

void getAssists()
{

    int assists = 0;
    int totalAssists = 0;
    double assistAverage = 0;
    for (int i = 0; i < 5; i++)
    {
        cout << "Please enter number of assists : ";
        cin >> assists;
        totalAssists += assists;
    }
    assistAverage = totalAssists / 5;
    cout << "Assist Average : " << assistAverage << endl
         << endl;
}