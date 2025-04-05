#include <iostream>
#include <string>
using namespace std;

int main()
{

    system("clear");

    string userInputString = "";
    string upperCase = "";
    char userChoice = 'Y';

    while (userChoice == 'Y')
    {

        cout << "Please enter a string to be analyzed: ";
        getline(cin, userInputString);

        // Length
        int stringLength = userInputString.length();
        cout << "The length of the string is: " << stringLength;

        // Convert to uppercase using char to upper

        for (int i = 0; i < stringLength; i++)
        {
            upperCase += toupper(userInputString[i]);
        }
        cout << "\nCapitalized: " << upperCase << endl;

        // Lowercase

        // First character
        cout << "The first character of this string is: " << userInputString.substr(0, 1) << endl;
        cout << "The first character of this string is: " << userInputString[0] << endl;

        // Last character

        // Number of vowels

        int totalVowels = 0;

        for (int i = 0; i < stringLength; i++)
        {
            // looking for vowels
            if (upperCase[i] == 'A' || upperCase[i] == 'E' || upperCase[i] == 'I' || upperCase[i] == 'O' || upperCase[i] == 'U')
            {
                totalVowels++;
            }
        }

        // comment

        // Reverse the string

        // Ask user for a length and an index
        int index = 0;
        int length = 0;
        cout << "Please enter a start index: ";
        cin >> index;
        cout << "Please enter a length of characters: ";
        cin >> length;

        cout << "Substring is: " << userInputString.substr(index - 1, length);
        char findChar = ' ';
        cout << "Enter a character to find: ";
        cin >> findChar;
        cout << "Position is: " << userInputString.find(findChar, 0);

        // replace

        int spacePosition = userInputString.find(" ");

        while (spacePosition != -1)
        {
            userInputString.replace(spacePosition, 1, "_");
            spacePosition = userInputString.find(" ");
        }

        cout << "String is: " << userInputString << endl;

        cout << "Would you like to analyze another string? (Y/N): ";
        cin >> userChoice;
        cin.ignore();
    }

    cout << "Thank you." << endl;
    return 0;
}