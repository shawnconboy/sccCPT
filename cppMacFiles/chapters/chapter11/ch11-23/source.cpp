#include <iostream>
#include <iomanip>
using namespace std;

// function prototypes
int getTotal(const int winnings[], int size);
double getAvg(int total, int size);
int getHighDay(const int winnings[], int size);

int main()
{

    system("clear");
    int winnings[5] = {12500, 9000, 2400, 15600, 5400};
    int size = 5;
    int total = getTotal(winnings, size);
    double average = getAvg(total, size);
    int highDay = getHighDay(winnings, size);

    cout << fixed << setprecision(2);
    cout << "Total amount won: $" << total << endl;
    cout << "Average daily amount won: $" << average << endl;
    cout << "The contestant's highest amount won was on day "
         << highDay << "." << endl;
    return 0;
}

//*****function definitions*****
int getTotal(const int winnings[], int size)
{
    int total = 0;
    for (int i = 0; i < size; i++)
    {
        total += winnings[i];
    }
    return total;
}

double getAvg(int total, int size)
{
    return static_cast<double>(total) / size;
}

int getHighDay(const int winnings[], int size)
{
    int highest = winnings[0];
    int day = 1; // Assume first day has highest initially

    for (int i = 1; i < size; i++)
    {
        if (winnings[i] > highest)
        {
            highest = winnings[i];
            day = i + 1; // Days are 1-based (not 0-based)
        }
    }
    return day;
}
