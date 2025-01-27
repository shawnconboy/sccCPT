#include <iostream>
using namespace std;

int main() {
	//declare variables
	int ordered = 0;
	char code = ' ';
	double price = 0.00;
	double discount = 0.00;

	//process
	if (ordered > 10 && toupper(code) == 'B') {
		price = ordered * 15.25;
		discount = 10;
	}
	else {
		price = ordered * 17.50;
		discount = 8.25;
	}
	return 0;
}