#include <iostream>
using namespace std;

int main() {

    //Declare Variables
    float milesInput;
    const float KILOMETERS_IN_MILE = 1.60934;
    float convertedNumber;

    //Process
    cout << "Enter number of miles : ";

    cin >> milesInput;

    //Math to convert mile to kilometer
    convertedNumber = milesInput * KILOMETERS_IN_MILE;

    cout << "There are " << convertedNumber << " kilometers in " << milesInput << " mile(s).";


    return 0;
}