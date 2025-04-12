#include <iostream>
#include <string>

using namespace std;

int main()
{
    system("clear");
    int calories[5] = {1560, 1700, 1500, 2000, 1545};
    int total = 0;
    int totalCalories = 0;

    for (int i = 0; i < 5; i++)
    {
        total = calories[i];
    }

    cout << "Total Calories : " << total << endl;

    int calories2[5] = {0};
    string days[5] = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};

    cout << endl;
    for (int i = 0; i < 5; i++)
    {
        cout << "Please enter number of calories for " << days[i] << ": ";
        cin >> calories2[i];
        totalCalories += calories2[i];
    }

    cout << endl;
    for (int i = 0; i < 5; i++)
    {
        cout << "Calories for " << days[i] << " : " << calories2[i] << endl;
    }

    cout << "\nTotal calories = " << totalCalories << endl;

    cout << "Average calories = " << totalCalories / 5 << endl;

    return 0;
}