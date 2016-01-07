#pragma once
#include "stdafx.h"
using namespace std;

class Princess
{
public:
	Princess();
	~Princess();

	void switcher(int x);
	void displayPathToPrincess(int n, vector <string> grid);
};

