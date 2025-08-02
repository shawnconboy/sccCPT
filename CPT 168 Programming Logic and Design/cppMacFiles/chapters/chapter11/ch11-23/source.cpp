#include <iostream>
#include <iomanip>
using namespace std;

int main()
{

    system("clear");
    int winnings[5] = {12500, 9000, 2400, 15600, 5400};
    int total = 0;
    double average = 0.0;
    int highDay = 0;

    cout << fixed << setprecision(2);
    for (int i = 0; i < 5; i++)
    {
        total += winnings[i];
    }

    cout << "Total amount won: $" << total << endl;

    average = total / 5;

    cout << "\nAverage daily amount won: $" << average << endl;

    for (int i = 0; i < 5; i++)
    {
        if (winnings[i] > highDay)
        {
            highDay = winnings[i];
        }
    }

    cout << "\nThe contestant's highest amount won was on day "
         << highDay << "." << endl
         << endl;
    return 0;
}
