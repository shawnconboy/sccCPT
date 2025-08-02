#include <iostream>
using namespace std;

// function declarations
void printAll();
void printUserChoice();
void greeting();
void exit();
void clearScreen();
int userNum = 0;

// Strings *****************************************************

string scope[8] = {"This week is going to be a lucky week for you, buy lotto", "You will barely escape an accident this week", "You are going to have a week full of surprises", "You will receive a large amount of money this week", "You will get promoted at your job this week", "You will get a phone call from an old phone this week", "You may have some type of car problem this week", "Today is a day of fun"};

string dayOfWeek[8] = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Funday"};

string numbers[8] = {"8,9,23,29,50", "7,19,21,38,51", "6,25,28,30,49", "22,27,33,37,42", "16,18,28,34,38", "10,3,6,13,33", "7,21,25,28,37", "15,10,20,33,66"};

// *************************************************************

int main()
{
    system("color f0");
    clearScreen();

    greeting();
    printUserChoice();
    printAll();

    system("pause");
    return 0;
}

void greeting()
{
    cout << "\t*****************************" << endl;
    cout << "\t*       Shawn Conboy        *" << endl;
    cout << "\t*       CPT-168-AO1H        *" << endl;
    cout << "\t*          Test 3           *" << endl;
    cout << "\t*****************************" << endl;

    cout << "\n<<<<<<<<<<< Hello >>>>>>>>>>>>\n\n";
}

void exit()
{
    cout << "\n\nProgram has ended. \n";
    cout << "T H A N K  Y O U\n\n"
         << endl;
}

void printUserChoice()
{
    cout << "Please enter a number from 1 - 8 or 99 to end: ";
    cin >> userNum;

    while (userNum != 99 && userNum != -1)
    {
        if (userNum >= 1 && userNum <= 8)
        {
            cout << "\n\tYour " << dayOfWeek[userNum - 1] << " Horoscope: " << scope[userNum - 1]
                 << "\n\tLucky Carolina5 numbers: " << numbers[userNum - 1] << endl;
        }
        else
        {
            cout << "\n\tInvalid number was entered." << endl;
        }

        cout << "\nPlease enter a number from 1 - 8 or 99 to end: ";
        cin >> userNum;
    }

    cout << "\n\tSentinel value has been entered.\n";
}

void printAll()
{
    cout << "\n\nEvery Day's Horoscope and Numbers\n";
    for (int i = 0; i < 8; i++)
    {
        cout << "\n\tYour " << dayOfWeek[i] << " Horoscope: " << scope[i]
             << "\n\tLucky Carolina5 numbers: " << numbers[i] << endl;
    }
}

void clearScreen()
{
#ifdef _WIN32
    system("CLS");
#else
    system("clear");
#endif
}