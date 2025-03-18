#include <iostream>
using namespace std;

int main()
{
    int grade = 0;

    cout << "Please enter your grade(00) : ";
    cin >> grade;

    if (grade >= 90)
    {
        cout << "A";
    }
    else if (grade >= 80)
    {
        cout << "B";
    }
    else if (grade >= 70)
    {
        cout << "C";
    }
    else
    {
        cout << "You failed.";
    }

    cout << endl;
}
