#include <iostream>
#include <cmath>
using namespace std;

int main()
{

    cout << "Number   Square    Cube" << endl;

    for (int row = 10; row < 14; row++)
    {
        for (int col = 0; col < 4; col++)
        {
            cout << "  " << row << "      ";
            cout << pow(row, 2) << "      ";
            cout << pow(row, 3) << "    " << endl;

            row++;
        }
    }

    return 0;
}