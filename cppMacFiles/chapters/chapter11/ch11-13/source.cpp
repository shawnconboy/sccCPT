#include <iostream>
using namespace std;

int main()
{
    system("clear");

    int orders[5] = {10, 29, 4, 22, 30};
    int smallest = 0;
    int current = 0;

    smallest = orders[0];

    for (int i = 0; i < 5; i++)
    {
        current = orders[i];

        if (current < smallest)
        {
            smallest = current;
        }
    }

    cout << "The smallest number in the orders array is: " << smallest << "\n\n";

    return 0;
}