#include <iostream>
#include <fstream>

using namespace std;

int main()
{

    ofstream outAlbums;

    // open albums.txt

    outAlbums.open("albums.txt");

    if (outAlbums.is_open())
    {
        cout << "Success" << endl;
    }
}