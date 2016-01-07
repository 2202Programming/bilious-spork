#include "stdafx.h"
#include "Princess.h"
using namespace std;

Princess::Princess(){
	int m;
	vector <string> grid;
	cin >> m;

	for (int i = 0; i<m; i++) {
		string s;
		cin >> s;
		grid.push_back(s);
	}

	displayPathToPrincess(m, grid);
}

Princess::~Princess()
{
}

void Princess::displayPathToPrincess(int n, vector<string> grid)
{
}
