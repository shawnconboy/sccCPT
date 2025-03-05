#include <iostream>
using namespace std;

int main()
{

    int num = 0;
    int total = 0;

    cout << "Please enter a number : ";
    cin >> num;

    while (num != -1)
    {
        total += num;
        cout << "Total : " << total << endl;

        cout << "Please enter a number : ";
        cin >> num;
    }
}