#include <iostream>
using namespace std;

int main()
{

    int subscript = 0;

    double sales[0];

    while (subscript < 4)
    {
        sales[subscript] = 0.0;
        subscript += 1;
    }

    for (int i = 0; i < sales[subscript]; i++)
    {
        cout << sales[i] << endl;
    }

    cout << "Program ran" << endl;
    return 0;
}