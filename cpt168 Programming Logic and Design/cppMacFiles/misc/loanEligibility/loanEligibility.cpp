#include <iostream>
using namespace std;

int main()
{
    int age = 0;
    double income = 0.0;

    cout << "Hello. Please enter your age : ";
    cin >> age;

    if (age >= 18)
    {
        cout << "Please enter your annual income : ";
        cin >> income;

        if (income >= 30000)
        {
            cout << "Congratulations. You qualify for the loan!" << endl;
        }
        else
        {
            cout << "Sorry. You're not eligible for this loan." << endl;
        }
    }
    else
    {
        cout << "Sorry. You're too young for this loan." << endl;
    }

    return 0;
}