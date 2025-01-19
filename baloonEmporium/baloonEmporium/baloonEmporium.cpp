#include <iostream>
using namespace std;

int main() {


	//declare variables

	float latexPrice = 0.00;
	float mylarPrice = 0.00;
	int latexQuantity = 0;
	int mylarQuantity = 0;
	float totalLatexPrice = 0.00;
	float totalMylarPrice = 0.00;
	float costWithoutTax = 0.00;
	float salesTaxRate = 0.00;
	float totalCost = 0.00;

	//process

	cout << "Hello. Enter the price of one latex baloon. : ";
	cin >> latexPrice;

	cout << "Okay, and now the price of one mylar baloon. : ";
	cin >> mylarPrice;

	cout << "How many latex balloons are being purchased? : ";
	cin >> latexQuantity;

	cout << "How many mylar baloons are being purchased? : ";
	cin >> mylarQuantity;

	cout << "What's your tax rate? (enter in 0.00 format) : ";
	cin >> salesTaxRate;

	totalLatexPrice = latexPrice * latexQuantity;
	totalMylarPrice = mylarPrice * mylarQuantity;

	costWithoutTax = totalLatexPrice + totalMylarPrice;

	totalCost = (costWithoutTax * salesTaxRate) + costWithoutTax;
	
	cout << "Your total purchase price will be $" << totalCost << ". Thank you.";

	return 0;
}