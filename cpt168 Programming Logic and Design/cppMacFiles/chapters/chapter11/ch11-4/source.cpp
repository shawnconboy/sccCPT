#include <iostream>
using namespace std;

int main()
{

    int counter = 0;

    system("clear");

    double rates[5] = {6.5, 8.3, 4.0, 2.0, 10.5};

    for (int i = 0; i < 5; i++)
    {
        cout << rates[i] << endl;
    }

    cout << endl;

    do
    {
        cout << rates[counter] << endl;
        counter++;
    } while (counter < 5);

    return 0;
}
