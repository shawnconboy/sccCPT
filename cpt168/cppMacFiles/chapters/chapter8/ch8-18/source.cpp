#include <iostream>
#include <iomanip>
using namespace std;

int main()
{

    system("clear");

    int newSalary = 0;
    double raisePercentage = 0.0;
    double raiseAmount = 0.0;
    double originalSalary = 0.0;

    cout << "Please enter your salary. : ";
    cin >> originalSalary;

    do
    {

        system("clear");
        for (int year = 1; year < 4; year++)
        {
            cout << "\nYear " << year << " salary : $" << originalSalary << endl;
            cout << "Raise % " << "  Salary Increase    " << endl;

            for (double i = 0.03; i < 0.07; i = i + 0.01)
            {

                raiseAmount = i * originalSalary;

                cout << fixed << setprecision(2) << i * 100 << "%" << "     ";
                cout << "$" << fixed << setprecision(2) << raiseAmount << endl;
            }
            originalSalary = originalSalary + raiseAmount;
        }
        cout << "\nPlease enter your salary. : ";
        cin >> originalSalary;

    } while (originalSalary != -1);

    return 0;
}
