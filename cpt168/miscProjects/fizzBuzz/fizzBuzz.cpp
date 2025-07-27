#include <iostream>;
using namespace std;

int main() {

	// declare variables
	int num = 0;

	// output input
	cout << "Please enter a number : ";
	cin >> num;

	// process

	for (int i = 1; i <= num; i++) {
		if (i % 3 == 0 && i % 5 == 0) {
			cout << "Fizz Buzz (" << i << ")" << endl;
		}
		else if (i % 3 == 0) {
			cout << "Fizz" << endl;
		}
		else if (i % 5 == 0) {
			cout << "Buzz" << endl;
		} else {
			cout << i << endl;
		}
	}



	return 0;
}