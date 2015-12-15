// HexDump.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

using namespace std;
int main()
{
	string line;
	string text;
	ifstream mfile;
	mfile.open("HexDump.cpp");
	if (mfile.is_open()) {
		while ( getline(mfile, line)) {
			text += line;
			text += '\n';
		}
		mfile.close();
	}
	else cout << "File Not Found " << endl;
	cout << text << endl;
	while (true);
    return 0;
}

