// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
using namespace std;

double ftoC(double f);
void tempRunner();
void switchRunner();
void switcher(int* a, int* b);
void tableRunner();

int main() {
	while (true) {
		tableRunner();
	}
	return 0;
}

void tableRunner() {
	CelcciusTable table;
	double x, y, z;
	cin >> x >> y >> z;
	table.makeTable(x, y, z);
}

void tempRunner() {
	double input = -999;
	char cont = 'y';
	while (cont == 'y' || cont == 'Y') {
		cout << "Enter Celcius Value :";
		cin >> input;
		ftoC(input);
		cout << "Continue (Y/N) : ";
		cin >> cont;
	}
}

double ftoC(double f) {
	double c = (f - 32.0) * (5.0 / 9.0);
	cout << f << " Degrees Farenheight = " << c << " Degress Celcius" << endl;
	return c;
}

void switchRunner() {
	int c, d;
	cin >> c >> d;
	int* pD = &d;
	int* pC = &c;
	cout << "c == " << c << " & d == " << d << endl;
	switcher(pC, pD);
	cout << "c == " << c << " & d == " << d << endl;
}

void switcher(int * a, int * b) {
	int temp;
	temp = *a;
	*a = *b;
	*b = temp;
}