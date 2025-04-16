#include <iostream>
#include <string>
#include <fstream>

using namespace std;

int main() {

	ifstream inSales;
	inSales.open("names.txt");

	if (inSales.is_open()) {
		cout << "names.txt opened successfully." << endl;
	}
	else {
		cout << "names.txt not found." << endl;
	}

	return 0;
}