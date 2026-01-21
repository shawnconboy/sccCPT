#include <iostream>
using namespace std;

int main()
{

    system("clear");

    int increase = 0;
    int numbers[6] = {0, 1, 2, 3, 4, 5};

    cout << "Enter increase amount : ";
    cin >> increase;

    for (int i = 0; i < 6; i += 1)
    {
        numbers[i] += increase * (i + 1);
        cout << numbers[i] << endl;
    }

    return 0;
}