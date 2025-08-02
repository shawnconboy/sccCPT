#include <iostream>
#include <string>
using namespace std;

int main()
{

    system("clear");

    // string name = "";

    // cout << "Please enter name: ";
    // getline(cin, name);

    // while (name != "-99")
    // {

    //     if (name.length() == 7)
    //     {
    //         cout << "Variable Name has 7 characters." << endl;
    //     }
    //     else if (name.length() > 7)
    //     {
    //         cout << "Variable Name has more than 7 characters." << endl;
    //     }
    //     else
    //     {
    //         cout << "Variable Name has less than 7 characters." << endl;
    //     }

    //     cout << "Please enter name: ";
    //     getline(cin, name);
    // }

    // string college = "";

    // cout << "Enter college name: ";
    // getline(cin, college);
    // cout << "Last character: " << college[college.length() - 1] << endl;

    string cityState = "Bowling Green, KY";
    int location = cityState.find(",", 0);

    cout << cityState.erase(13) << endl;
    cout << cityState.erase(13, 4);

    return 0;
}