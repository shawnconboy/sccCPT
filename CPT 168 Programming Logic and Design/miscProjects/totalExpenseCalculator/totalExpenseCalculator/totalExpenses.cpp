#include <iostream>
using namespace std;

int main() {

	//declare variables
	float totalExpenses = 0.00;
	float food = 0.00;
	float rent = 0.00;
	float utilities = 0.00;
	float carPayment = 0.00;

	//process
	cout << "Hello. Please enter price of food : ";
	cin >> food;

	cout << "Please enter price of rent : ";
	cin >> rent;

	cout << "Please enter price of utilities : ";
	cin >> utilities;

	cout << "Please enter price of car payment : ";
	cin >> carPayment;

	totalExpenses = food + rent + utilities + carPayment;

	cout << "Your total expenses are $" << totalExpenses << ". Thank you." << endl << endl;

	return 0;
}