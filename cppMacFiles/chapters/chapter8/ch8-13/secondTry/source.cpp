#include <iostream>
using namespace std;

int main()
{

    system("clear");

    char enterGrade = ' ';
    int testGrade = 0;
    int testTotal = 0;

    cout << "Would you like to enter a student's grades? : ";
    cin >> enterGrade;
    enterGrade = toupper(enterGrade);

    if (enterGrade == 'Y')
    {
        do
        {

            for (int test = 1; test <= 4; test++)
            {
                cout << "Please enter test grade : ";
                cin >> testGrade;

                if (testGrade > 100 || testGrade < 0)
                {
                    cout << "Error.";
                    return 0;
                }

                testTotal += testGrade;
            }

            cout << "Test total is : " << testTotal << endl;
            cout << "Enter another grade? (Y or N) : ";
            cin >> enterGrade;

        } while (enterGrade != 'N');
    }
    else
    {
        cout << "Okay. Program ended." << endl;
    }

    cout << endl;
    return 0;
}