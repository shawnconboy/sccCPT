/*


number guesser

generate a random number

ask the user to guess the number

actual number
user number

if user number is  greater than actual, say too high
if user number is  less than actual, say too low.


*/

#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

int userNum = 0;

int main()
{

    // Seed the random number generator with the current time
    srand(time(0));

    // Generate a random number between 0 and 100 (inclusive)
    int randomNumber = rand() % 101;

    // Print the random number
    cout << "Random number between 0 and 100 : " << randomNumber << endl;

    cout << "Guess the number between 0 and 100 : ";
    cin >> userNum;

    while (userNum != randomNumber)
    {
        if (userNum > randomNumber)
        {
            cout << "Too high.\n";
        }
        else
        {
            cout << "Too low.\n";
        }

        cout << "Guess again. : ";
        cin >> userNum;
    }

    if (userNum == randomNumber)
    {
        cout << "Congratulations. You guessed correctly!\n";
    }

    return 0;
}