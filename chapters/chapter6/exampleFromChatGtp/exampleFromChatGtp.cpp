#include <iostream>
#include <iomanip>
using namespace std;

int main() {
	
	int age = 0;
	int showtime = 0;
	double discount = 0.0;
	double ticketPrice = 10.00;


	//output input
	cout << "Please enter age : ";
	cin >> age;

	cout << "Please enter showtime : ";
	cin >> showtime;

	//process
	if (showtime < 16) {
		discount = 0.2;
	}

	if (age < 12) {
		discount += 0.5;
	}
	else if (age >= 60) {
		discount += 0.3;
	}

	ticketPrice = ticketPrice - (ticketPrice * discount);

	//final output
	cout << "Your final ticket price is $" << fixed << setprecision(2) << ticketPrice;

	return 0;
}