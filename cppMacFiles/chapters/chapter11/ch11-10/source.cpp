#include <iostream>
using namespace std;

int main()
{

    int counter = 0;

    int quantities[10] = {0};

    // for (int i = 0; i < 10; i++)
    // {
    //     cout << quantities[i] - 1 << endl;
    // }

    while (counter < 10)
    {
        cout << quantities[counter] - 1 << endl;
        counter++;
    }

    return 0;
}