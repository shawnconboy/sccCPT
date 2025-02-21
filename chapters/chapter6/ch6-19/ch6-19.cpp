#include <iostream>
#include <iomanip>
using namespace std;

int main() {

	cout << "\t\t*********************************************" << endl;
	cout << "\t\t*                                           *" << endl;
	cout << "\t\t*                                           *" << endl;
	cout << "\t\t*               Shawn Conboy                *" << endl;
	cout << "\t\t*             Sophia's Pizzeria             *" << endl;
	cout << "\t\t*                                           *" << endl;
	cout << "\t\t*                                           *" << endl;
	cout << "\t\t*********************************************" << endl;


	// declare variables

	const double mediumPizza = 9.99;
	const double largePizza = 12.99;
	const double coupon = 2.00;
	const double bulkOrder = 0.10;
	double totalCost = 0.0;

	int mediumPizzasOrdered = 0;
	int largePizzasOrdered = 0;
	char hasCoupon = ' ';

	// output input

	cout << "\n\nHello. Please enter number of large pizzas you'd like : ";
	cin >> largePizzasOrdered;

	cout << "Please enter number of medium pizzas you'd like : ";
	cin >> mediumPizzasOrdered;


	// process

	if (mediumPizzasOrdered >= 0 && largePizzasOrdered >= 0) {


		totalCost = mediumPizza * mediumPizzasOrdered;
		totalCost += (largePizza * largePizzasOrdered);

		cout << "Current Total : $" << fixed << setprecision(2) << totalCost << endl;
		
		if (largePizzasOrdered + mediumPizzasOrdered > 4) {
			totalCost = totalCost * (1 - bulkOrder);
			cout << "You qualify for our bulk order discount! " << endl;
			cout << "Current Total : $" << fixed << setprecision(2) << totalCost << endl;

		}

		if (largePizzasOrdered >= 1) {
			cout << "Do you have a $2 off 1 Large Pizza Coupon?(Y or N) : ";
			cin >> hasCoupon;
			hasCoupon = toupper(hasCoupon);

			if (hasCoupon == 'Y') {
				totalCost -= coupon;
				cout << "I'll apply that discount." << endl;
			}
			else if (hasCoupon == 'N') {
				cout << "Okay. No coupon used." << endl;
			}
			else {
				cout << "Invalid letter entered." << endl;
			}
		}

		// final ouput
			
		cout << "\n\n\t\t*******************************************" << endl;
		cout << "\t\t*                                         *" << endl;
		cout << "\t\t*                                         *" << endl;
		cout << "\t\t*             Order Summary               *" << endl;
		cout << "\t\t*       Medium Pizzas          " << mediumPizzasOrdered << "          *" << endl;
		cout << "\t\t*       Large  Pizzas          " << largePizzasOrdered <<  "          *" << endl;
		cout << "\t\t*                                         *" << endl;
		cout << "\t\t*                                         *" << endl;
		cout << "\t\t*                                         *" << endl;
		cout << "\t\t*       Your final total is $" << fixed << setprecision(2) << totalCost << "        *" << endl;
		cout << "\t\t*                                         *" << endl;
		cout << "\t\t*                                         *" << endl;

		cout << "\t\t*******************************************\n\n\n\n" << endl;
	}


	system("pause");

	return 0;
}
