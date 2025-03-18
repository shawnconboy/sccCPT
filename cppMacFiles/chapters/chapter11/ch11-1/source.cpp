#include <iostream>
using namespace std;

int main()
{

    // ch11-oneThroughThree

    system("clear");

    int scores[10] = {0};
    int counter = 0;

    scores[2] = 12;

    while (counter < 10)
    {
        cout << "Score " << counter + 1;
        cout << "  : " << scores[counter] << endl;
        counter++;
    }

    cout << endl;

    for (int i = 0; i < 10; i++)
    {
        cout << "Score " << i + 1;
        cout << "  : " << scores[i] << endl;
    }

    return 0;
}