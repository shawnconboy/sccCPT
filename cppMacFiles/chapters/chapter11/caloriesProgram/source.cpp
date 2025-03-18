#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
    system("clear");

    cout << "***********************************" << endl;
    cout << "*                                 *" << endl;
    cout << "*        Calories Program         *" << endl;
    cout << "*                                 *" << endl;
    cout << "***********************************\n"
         << endl;

    // declare variables

    int days[5] = {0};
    double average = 0.0;
    double totalCalories = 0.0;
    int numDays = 5;
    string daysOfWeek[5] = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};

    for (int i = 0; i < 5; i++)
    {
        cout << "Please enter your daily calorie intake for " << daysOfWeek[i] << " : ";
        cin >> days[i];

        totalCalories += days[i];
    }

    average = totalCalories / numDays;

    cout << endl;

    for (int i = 0; i < 5; i++)
    {
        cout << "Calories for " << daysOfWeek[i] << " : ";
        cout << days[i] << endl;
    }

    cout << endl;

    cout << "Total Calories = " << totalCalories << endl;
    cout << "Average daily calories  = " << fixed << setprecision(2) << average << endl;

    return 0;
}