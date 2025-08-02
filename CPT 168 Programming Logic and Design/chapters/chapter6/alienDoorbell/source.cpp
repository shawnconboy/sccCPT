#include <iostream>
using namespace std;

int main()
{

    char didKnock = ' ';
    string password = "Password";

    cout << "You walk up to the door of the lair. Do you knock? (Y or N)";
    cin >> didKnock;
    didKnock = toupper(didKnock);

    if (didKnock != 'Y' && didKnock != 'N')
    {
        cout << "invalid entry";
    }
    else
    {
        if (didKnock == 'Y')
        {
            // code for if answer is yes

            cout << "A voice over the speaker asks for a password. Please enter password : ";
            cin >> password;

            if (password != "Password")
            {
                cout << "Orange buton pressed *person destroyed*";
            }
            else
            {
                cout << "Please come in.";
            }
        }
        else
        {
            // code for if answer is no
        }
    }
    return 0;
}