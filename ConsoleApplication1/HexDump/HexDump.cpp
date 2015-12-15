// HexDump.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

using namespace std;

/*IN	-> rNum = prints out the current element number it is at in the form 0x00000000
		-> s = The current string in each row should be size <= 16
		-> max = only used if the row is incomplete like their is only 5 elements left should == s.size - 1
  OUT	-> No direct output only displays the processed values to the screen in one central way
*/
void printRow(int rNum, string s, int max=16);
/*
IN	-> Any value T I think this should work for any non floaty number includeing chars
OUT -> the value of I returned in the Hexadecimal Base in the 0x00000000 form
*/
template<typename T>string int_to_hex(T i);
/*
IN	-> same as before but designed 
*/
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