// HexDump.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

using namespace std;

void printRow(int rNum, string s, int max=16);
template<typename T>string int_to_hex(T i);
string hexInt(int i);

int main()
{
	string line;
	string text;
	ifstream mfile;
	mfile.open("HexDump.cpp");
	if (mfile.is_open()) {
		while ( getline(mfile, line)) {
			text += line;
		}
		mfile.close();
		int i;
		for (i = 0; i < text.size()-16; i += 16) {
			string s = text.substr(i,16);
			printRow(i, s);
		}
		int temp = i;
		i = text.size() - i;
		if (i > 0) {
			string s = text.substr(temp, i);
			printRow(i, s, i);
		}
	}
	else cout << "File Not Found " << endl;
	while (true);
    return 0;
}

void printRow(int rNum,string s,int max) {
	//Generates Starting Number
	string num = int_to_hex(rNum);
	while (num.length() < 10) {
		num = "0" + num;
	}

	cout << num << "  ";
	//Generates Hex Values
	for (int i = 0; i < max ; i++) {
		int temp = s.at(i);
		string hex = hexInt(temp);
		cout << hex << " ";
		if (i == 7) {
			cout << " ";
		}
	}

	cout <<"|"<< s << "|";
	cout << endl;
}

template<typename T>string int_to_hex(T i){
	stringstream stream;
	stream << setfill('0') << setw(sizeof(T) * 2) << hex << i;
	return stream.str();
}
string hexInt(int i) {
	stringstream stream;
	stream << setfill('0')<< setw(2) << hex << i;
	return stream.str();
}