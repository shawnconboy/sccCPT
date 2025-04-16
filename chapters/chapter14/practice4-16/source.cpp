#include <iostream>
#include <fstream>

using namespace std;

int main() {

	string name = "";

	cout << "Please enter your name: ";
	cin >> name;

	ofstream file("names.txt");
	file << name;

	return 0;
}