#include <iostream>
#include <iomanip>
using namespace std;

int main() {
	system("color f0");

	cout << "\t***************************************" << endl;
	cout << "\t*                                     *" << endl;
	cout << "\t*           Sum of Intergers          *" << endl;
	cout << "\t*                                     *" << endl;
	cout << "\t***************************************" << endl;

	int num = 0;
	int total = 0;
	char showAverage = ' ';
	double average = 0;
	int counter = 0;

	cout << "\n\tPlease enter a number : ";
	cin >> num;
	cout << endl;

	while (num > -1) {
		total += num;
		counter += 1;
		cout << "\tPlease enter a new number : ";
		cin >> num;
		cout << endl;
	}

	cout << "\tFinal Total : " << total << endl << endl;

	cout << "\tWould you like to know the average? (Y or N) : ";
	cin >> showAverage;
	showAverage = toupper(showAverage);
	cout << endl;

	if (showAverage == 'Y') {
		average = static_cast<double>(total) / counter;
		cout << "\tThe average is : " << fixed << setprecision(2) << average << endl << endl;
	}

	system("pause");
	return 0;
}
