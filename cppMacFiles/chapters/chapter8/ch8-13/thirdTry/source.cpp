#include <iostream>
using namespace std;

int main()
{
    system("clear");

    cout << "\nLoop Practice" << endl;

    double testScore = 0.0;
    char letterGrade = ' ';
    int studentNumber = 0;
    double totalTestScore = 0.0;
    char nextStudent = ' ';
    int currentStudent = 1;

    do
    {

        totalTestScore = 0;

        for (int i = 0; i < 4; i++)
        {
            cout << "Please enter test " << i + 1 << " score : ";
            cin >> testScore;

            totalTestScore += testScore;
        }

        if (totalTestScore > 372)
        {
            letterGrade = 'A';
        }
        else if (totalTestScore >= 340)
        {
            letterGrade = 'B';
        }
        else if (totalTestScore >= 280)
        {
            letterGrade = 'C';
        }
        else if (totalTestScore >= 240)
        {
            letterGrade = 'D';
        }
        else
        {
            letterGrade = 'F';
        }

        cout << "Student " << currentStudent << "'s Grade is : " << letterGrade << endl;

        currentStudent++;
        cout << "Do you have another student to enter? : ";
        cin >> nextStudent;
    } while (toupper(nextStudent) == 'Y');
    return 0;
}
