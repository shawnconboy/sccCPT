#include <iostream>
#include <iomanip>
using namespace std;

int main()
{

    // display information

    cout << "\n\n\t**************************************" << endl;
    cout << "\t*                                    *" << endl;
    cout << "\t*        Ice Skater Score Card       *" << endl;
    cout << "\t*                                    *" << endl;
    cout << "\t**************************************" << endl;

    // declare variables

    int numScoresEntered = 0;
    int judgeScore = 0;
    double totalScore = 0;
    double scoreAverage = totalScore / scoreAverage;

    // output input

    cout << "\n\tPlease enter judge's score(0-10) : ";
    cin >> judgeScore;

    // process

    while (judgeScore >= 0)
    { // not negative
        if (judgeScore >= 0 && judgeScore <= 10)
        {
            numScoresEntered += 1;
            totalScore += judgeScore;

            cout << "\n\tPlease enter next judge's score(0-10) : ";
            cin >> judgeScore;
        }
        else
        {
            cout << "\n\tPlease enter valid judge's score(0-10) : ";
            cin >> judgeScore;
        }
    }

    // final output

    scoreAverage = totalScore / numScoresEntered;
    cout << "\n\tYour average score is : " << fixed << setprecision(2) << scoreAverage << endl;

    cout << "\n\tYou were judged by " << numScoresEntered << " judges total" << endl
         << endl;

    return 0;
}