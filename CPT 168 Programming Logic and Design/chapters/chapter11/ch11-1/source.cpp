#include <iostream>
#include <string>

using namespace std;

int main()
{

    system("clear");

    int scores[10] = {0};
    int counter = 0;

    scores[2] = 12;

    cout << "For loop content : " << endl;

    for (int i = 0; i < 10; i++)
    {
        cout << scores[i] << endl;
    }

    cout << "\nWhile loop content : " << endl;

    while (counter < 10)
    {
        cout << scores[counter] << endl;
        counter++;
    }

    cout << endl;

    return 0;
}