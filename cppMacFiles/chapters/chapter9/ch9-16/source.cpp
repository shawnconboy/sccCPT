#include <iostream>
#include <cmath>
using namespace std;

int main()
{

    for (int row = 10; row < 14; row++)
    {
        cout << "Row : " << row << endl;

        for (int col = 0; col < 4; col++)
        {
            cout << row << "    ";
            cout << pow(row, 2) << "    ";
            cout << pow(row, 3) << "    " << endl;

            row++;
        }
    }

    return 0;
}