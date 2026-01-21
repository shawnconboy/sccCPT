#include <iostream>
using namespace std;

int main() {

	int num = 0;
	int total = 0;

	cout << "Please enter a number (-1 to stop) : ";
	cin >> num;// priming read

	while (num != -1) {
		total = num + total;

		cout << "Your total is : " << total << endl;

		cout << "Please enter a number (-1 to stop) : ";
		cin >> num;// update read
	}


	/*

	4 things every loop needs

		priming read
		while or for
		condition
		update read

	*/



	return 0;
}