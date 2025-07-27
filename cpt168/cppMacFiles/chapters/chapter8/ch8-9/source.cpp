#include <iostream>
using namespace std;

int main()
{
    system("clear");
    for (int row = 1; row < 20; row += 1)
    {
        for (int col = 0; col < row; col = col + 1)
        {
            cout << "*";
        }
        cout << endl;
    }

    return 0;
}