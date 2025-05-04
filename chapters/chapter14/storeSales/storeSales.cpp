// storeSales.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <fstream>
#include <iomanip>

using namespace std;


int main()
{

	// declare variables
	string itemName = "";
	string itemCost = "";
	string itemPrice = "";
	string itemQuantity = "";

	// fstream declarations

	ifstream inInventory;

	inInventory.open("inventory.txt");

	if (inInventory.is_open()) {
		cout << "inventory.txt opened successfully\n\n";
	}
	else {
		cout << "inventory.txt failed to open\n\n";
	}

	cout << left << setw(15) << "Item" <<
		setw(8) << "Cost" <<
		setw(8) << "Price" << endl << endl;

	while (getline(inInventory, itemName, '#') && getline(inInventory, itemCost, '#') && getline(inInventory, itemPrice)) {


		cout << left << setw(15) << itemName <<
			setw(8) << itemCost <<
			setw(8) << itemPrice << endl;
	}

	cout << endl;

	inInventory.close();

	if (inInventory.is_open()) {
		cout << "inventory.txt failed to close\n\n";
	}
	else {
		cout << "inventory.txt closed successfully\n\n";
	}

	system("pause");

	cout << endl;

	ifstream inPurchases;

	inPurchases.open("purchases.txt");

	if (inPurchases.is_open()) {
		cout << "purchases.txt opened successfully\n\n";
	}
	else {
		cout << "purchases.txt failed to open\n\n";
	}

	cout << left << setw(15) << "Item Name" <<
		setw(8) << "Quantity" << endl;

	while (getline(inPurchases, itemName, '#') && getline(inPurchases, itemQuantity)) {
		cout << left << setw(15) << itemName <<
			setw(8) << itemQuantity << endl;
	}

	system("pause");

	return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
