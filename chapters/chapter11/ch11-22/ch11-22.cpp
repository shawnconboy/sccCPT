//Introductory22.cpp - displays the average number of pounds ordered
//Created/revised by <your name> on <current date>

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double pounds[6] = { 10, 15.5, 17, 18.5, 11, 12.5 };
	double average = 0.0;
	int counter = 0;
	double totalPounds = 0.0;

	while (counter < 6) {
		totalPounds += pounds[counter];
		counter++;
	}

	average = totalPounds / 6;

	//average = getAvg();
	cout << fixed << setprecision(2);
	cout << "Average number of pounds ordered: " << average << endl;
	return 0;
}	//end of main function