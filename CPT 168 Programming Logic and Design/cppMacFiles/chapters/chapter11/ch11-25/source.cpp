// Intermediate25.cpp - increases the prices stored in
// an array and then displays the increased prices
// Created/revised by <your name> on <current date>

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{

    system("clear");
    cout << fixed << setprecision(2);

    // declare array
    double prices[10] = {4.5, 6.75, 23.0, 21.5, 5.25, 8.99, 9.99, 10.89, 3.99, 4.0};
    double percentage = 0;

    cout << "Please enter an amount to increase price by: ";
    cin >> percentage;

    for (int i = 0; i < 10; i++)
    {
        cout << "\n\nOriginal price was : " << prices[i] << ". "
             << "\nNew price is : " << prices[i] + (prices[i] * percentage) << endl;
    }
    return 0;
} // end of main function