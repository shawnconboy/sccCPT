#include <iostream>
using namespace std;

// int main()
// {

//     system("clear");
//     int numRows = 0;

//     cout << "Please enter number of rows : ";
//     cin >> numRows;

//     for (int row = 1; row <= numRows; row++)
//     {
//         for (int stars = 1; stars <= row; stars++)
//         {
//             cout << "* ";
//         }
//         cout << endl;
//     }

//     return 0;
// }

int main()
{
    system("clear");
    int numRows = 0;

    cout << "Please enter number of rows: ";
    cin >> numRows;

    for (int row = numRows; row >= 1; row--) // Start from numRows and decrease
    {
        for (int stars = 1; stars <= row; stars++) // Print 'row' number of stars
        {
            cout << "* ";
        }
        cout << endl;
    }

    return 0;
}