#include <iostream>
#include <iomanip>
using namespace std;

int main() {

	int num = 0;
	char runAgain = 'Y';



	while (toupper(runAgain) == 'Y') {

		system("cls");

		cout << "Please enter a number : ";
		cin >> num;

		cout << "   1   2   3   4   5   6   7   8   9   10" << endl;
		cout << "-----------------------------------------" << endl;


		for (int y = 0; y < 10; y++) {
			cout << y + 1 << " | ";
			for (int i = 1; i < 11; i++) {
				cout << setw(2) << num * i << "  ";
			}
			num++;
			cout << endl;
		}


		cout << "\nPrint another table? (Y or N) : ";
		cin >> runAgain;
	}

	cout << "Program ended. Thank you." << endl;

	system("pause");

	return 0;
}