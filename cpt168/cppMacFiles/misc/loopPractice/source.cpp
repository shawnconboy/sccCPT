#include <iostream>
#include <iomanip>
using namespace std;

int main()
{

    cout << "*************************" << endl;
    cout << "*                       *" << endl;
    cout << "*  Loop Demo Practice   *" << endl;
    cout << "*                       *" << endl;
    cout << "*************************" << endl;

    // loop exercises
    // 1. write a while loop and a for loop that each count from 0 to 20 and print out the values.

    // 2. write a while loop that allows the user to input a value until they hit the sentinel value of -1000.

    // 3. write a for loop that allows the user to enter a value that will be multiplied by 47 ten times.

    // 4. write a while loop that counts backwards from 100 by 5.

    // 5. write a for loop that counts backwards by 13 from 527.

    // 6. write a loop that computes a total, an average of 8 numbers entered by the user.

    // 7. write a while loop that computes a total, an average of numbers entered by the user until a sentinel value is entered.

    // **********************************************************
    // ex.1
    // whle loop count from zero to 20

    //  int counter = 0; //priming read

    //  while (counter < 21) {
    //      cout << counter << endl;

    //      counter++; //update read
    //  }

    //  for(int i = 0; i < 21; i++) {
    //      cout << i << endl;
    //  }

    //  cout << "Thank You" << endl;

    // **********************************************************

    // 2. write a while loop that allows the user to input a value until they hit the sentinel value of -1000.

    // int userInput = 0;

    // cout << "Please enter a number.";
    // cin >> userInput;

    // while(userInput != -1000){

    //     cout << "You entered " << userInput << endl;
    //     cout << "Please enter a number.";
    //     cin >> userInput;
    // }

    // int userInput = 0;

    // for (int i = 0; i < 10; i++) {
    //     cout << "Please enter a numnber : ";
    //     cin >> userInput;
    //     userInput *= 47;
    //     cout << endl;
    //     cout << userInput << endl;
    // }

    // int num = 100;
    // cout << num << endl;

    // while(num != 0) {
    //     num -= 5;
    //     cout << num << endl;
    // }

    // for(int i = 527; i >= 0; i -= 13) {
    //     cout << i << endl;
    // }

    //     int userInput = 0;
    //     int total = 0;
    //     double average = 0.0;
    //     int i = 0;

    //     for (i = 0; i < 8; i++)
    //     {
    //         cout << "Please enter a number : ";
    //         cin >> userInput;

    //         total += userInput;
    //     }
    //     average = total / i;
    //     cout << "Average is " << average << endl;

    //     cout << "Total is " << total << endl;

    //     return 0;
    // }

    // 7. write a while loop that computes a total, an average of numbers entered by the user until a sentinel value is entered.

    cout << "Please enter a number. : ";
    cin >> num;

    while (num != -1)
    {
    }
}