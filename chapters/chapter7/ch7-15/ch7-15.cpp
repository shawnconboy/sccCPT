#include <iostream>
#include <iomanip>
using namespace std;


int main() {
	int age = 0;
	double averageAge = 0.0;
	int counter = 0;
	int totalAges = 0;


	for (int numUsers = 1; numUsers <= 5; numUsers += 1) {

		cout << "Please enter age : ";
		cin >> age;


		totalAges += age;

		counter += 1;
	}

	averageAge = static_cast<double>(totalAges) / counter;
	cout << "The average age is : " << fixed << setprecision(1) << averageAge << endl;
}

