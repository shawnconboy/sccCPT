#include <iostream>
using namespace std;

int main()
{

    system("clear");

    char gender = ' ';
    char activityLevel = ' ';
    int calories = 0;
    int weight = 0;

    cout << "Please enter your gender (M or F) : ";
    cin >> gender;
    gender = toupper(gender);

    if (gender != 'M' && gender != 'F')
    {
        cout << "Invalid entry.";
    }
    else
    {
        cout << "Please enter your weight : ";
        cin >> weight;

        if (weight < 0)
        {
            cout << "Invalid weight entered." << endl;
        }
        else
        {
            cout << "Please enter activity level (I or A) : ";
            cin >> activityLevel;
            activityLevel = toupper(activityLevel);

            if (activityLevel != 'I' && activityLevel != 'A')
            {
                cout << "Invalid entry";
            }
            else
            {
                if (gender == 'M' && activityLevel == 'I')
                {
                    calories = weight * 13;
                }
                else if (gender == 'M' && activityLevel == 'A')
                {
                    calories = weight * 15;
                }

                if (gender == 'F' && activityLevel == 'I')
                {
                    calories = weight * 10;
                }
                else if (gender == 'F' && activityLevel == 'A')
                {
                    calories = weight * 12;
                }
                cout << "Daily Calories : " << calories;
            }
        }
    }

    return 0;
}