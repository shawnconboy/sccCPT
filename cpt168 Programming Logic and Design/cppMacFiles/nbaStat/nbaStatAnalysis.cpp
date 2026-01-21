#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	system("clear");
	cout << "\n**********************" << endl;
	cout << "*                    *" << endl;
	cout << "*  NBA Stat Tracker  *" << endl;
	cout << "*                    *" << endl;
	cout << "**********************" << endl
		 << endl;

	// declare variables
	int points = 0;
	int pointsCounter = 0;
	double pointsAverage = 0.0;
	int pointsTotal = 0;

	int rebounds = 0;
	int reboundsCounter = 0;
	double reboundsAverage = 0.0;
	int reboundsTotal = 0;

	int assists = 0;
	int assistsCounter = 0;
	double assistsAverage = 0.0;
	int assistsTotal = 0;

	// output input

	for (int i = 1; i < 6; i++)
	{
		cout << "Please enter number of points : ";
		cin >> points;
		pointsCounter += 1;
		pointsTotal += points;
	}
	pointsAverage = static_cast<double>(pointsTotal) / pointsCounter;

	cout << "Points have been entered." << endl
		 << endl;
	// system("clear");

	for (int i = 1; i < 6; i++)
	{
		cout << "Please enter number of rebounds : ";
		cin >> rebounds;
		reboundsCounter += 1;
		reboundsTotal += rebounds;
	}
	reboundsAverage = static_cast<double>(reboundsTotal) / reboundsCounter;

	cout << "Rebounds have been entered." << endl
		 << endl;
	// system("clear");

	for (int i = 1; i < 6; i++)
	{
		cout << "Please enter number of assists : ";
		cin >> assists;
		assistsCounter += 1;
		assistsTotal += assists;
	}
	assistsAverage = static_cast<double>(assistsTotal) / assistsCounter;

	cout << "Assists have been entered." << endl
		 << endl;
	// system("clear");

	cout << "\n\nAverage Points   : " << setw(15) << pointsAverage << endl;
	cout << "Average Rebounds : " << setw(15) << reboundsAverage << endl;
	cout << "Average Assists  : " << setw(15) << assistsAverage << endl;

	cout << "Points + Rebounds + Assists : " << setw(4) << pointsAverage + reboundsAverage + assistsAverage << endl
		 << endl;

	return 0;
}