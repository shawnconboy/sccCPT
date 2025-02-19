#include <iostream>
using namespace std;

int main() {

	int code;
	double rate;

	cout << "please enter code : ";
	cin >> code;

	switch (code)
	{
	case 1:
		rate = 0.2;
		break;
	case 2:
	case 3:
	case 4: 
		rate = 0.5;
		break;
	case 5:
		rate = 0.1;
		break;
	case 6:
	case 7:
		rate = 0.15;
		break;
	default:
		rate = -1;
		break;
	}

	cout << "rate is : " << rate << endl;

	return 0;
}