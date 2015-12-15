// HexDump.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

using namespace std;
int main()
{
	string line;
	ifstream mfile;
	mfile.open("HexDump.cpp");
	if (mfile.is_open()) {
		cout << "File Opened" << endl;
		while ( getline(mfile, line)) {
			cout << line << endl;
		}
		mfile.close();
	}
	else cout << "File Not Found " << endl;
	while (true);
    return 0;
}

