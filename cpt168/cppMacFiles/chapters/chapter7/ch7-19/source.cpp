#include <iostream>
using namespace std;

int main()
{

    system("color f0");

    // declare variables
    int midTermScore = 0;
    int finalTestScore = 0;
    char testGrade = 0;

    // output input

    cout << "\n\nHello. What was your midterm score? : ";
    cin >> midTermScore;

    cout << "\nPlease enter the score of your final exam. : ";
    cin >> finalTestScore;

    // process

    if (midTermScore >= 0 && finalTestScore >= 0)
    {
        int totalScore = midTermScore + finalTestScore;

        if (totalScore < 240)
        {
            testGrade = 'F';
        }
        else if (totalScore < 280)
        {
            testGrade = 'D';
        }
        else if (totalScore < 320)
        {
            testGrade = 'C';
        }
        else if (totalScore < 360)
        {
            testGrade = 'B';
        }
        else if (totalScore <= 400)
        {
            testGrade = 'A';
        }
        else
        {
            cout << "\ninvalid entry";
        }

        cout << "\nYour final test grade is : " << testGrade << endl
             << endl;
    }
    else
    {
        cout << "\nBoth entries need to be positive numbers.";
    }

    // final output
    system("pause");
    return 0;
}