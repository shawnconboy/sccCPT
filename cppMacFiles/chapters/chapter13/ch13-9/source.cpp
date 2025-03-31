//
//

// this program shows two ways to get rid of commas in a string. Using a while loop, and then a for loop.

#include <iostream>
#include <string>
using namespace std;

int main()
{
    system("clear");

    int x = 0;
    string amount = "3,123,460";
    string currentChar = "";

    // while (x < amount.length())
    // {
    //     currentChar = amount.substr(x, 1);
    //     if (currentChar == ",")
    //     {
    //         amount.erase(x, 1);
    //     }
    //     else
    //     {
    //         x++;
    //     }
    // }

    for (int i = 0; i < amount.length(); i++)
    {
        currentChar = amount.substr(i, 1);
        if (currentChar == ",")
        {
            amount.erase(i, 1);
        }
        // ask Mr.T about else statement needing to be here or not.
    }

    cout << amount << endl;

    return 0;
}