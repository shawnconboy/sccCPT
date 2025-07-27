#include <iostream>
using namespace std;

int main()
{
    system("clear");
    int maxRows = 0;

    cout << "Maximum number of rows : ";
    cin >> maxRows;

    for (int row = 0; row < maxRows; row++)
    {
        for (int space = 0; space < maxRows; space++)
        {
            cout << " ";
        }

        for (int asterisk = 0; asterisk <= row; asterisk++)
        {
            cout << "* ";
        }

        cout << endl;
    }

    return 0;
}