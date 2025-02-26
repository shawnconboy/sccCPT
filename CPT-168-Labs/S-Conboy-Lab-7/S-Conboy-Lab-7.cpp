#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

int main()
{
	system("clear");

	// display my info
	cout << "\n\t\t****************************************" << endl;
	cout << "\t\t*                                      *" << endl;
	cout << "\t\t*         Square-Cube-Program          *" << endl;
	cout << "\t\t*                                      *" << endl;
	cout << "\t\t****************************************" << endl;

	// declare variables
	int userNum = 0;
	double numSquared = 0;

	// output input
	cout << "Please enter a number to square, cube, and raise to the 4th power : ";
	cin >> userNum;

	// process

	//toSquare
	numSquared = pow(userNum, 2.0);

	cout << numSquared << endl;



	for (int i = 1; i < 11; i++)
	{
		cout << numSquared;
	}

	// final output

	return 0;
}