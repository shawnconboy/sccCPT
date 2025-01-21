#include <iostream>
using namespace std;

int main() {

    //Declare variables
    float discountAmount;
    float netTotal;
    int age;
    float discount;
    float purchaseAmount;

    //Process
    cout << "hello, please enter your purchase amount : " << endl;  
    cin >> purchaseAmount;

    if(purchaseAmount >= 100) {
        discount = 0.02;
    } else {
        discount = 0.01;
    }

    discountAmount = purchaseAmount * discount;
    netTotal = purchaseAmount - discountAmount;

    cout << "you recieved " << discount << " Percent off" << endl;
    cout << "your total purchase price is now, " << netTotal << ".";



    return 0;
}