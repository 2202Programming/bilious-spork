#pragma once
#include "stdafx.h"
using namespace std;


struct node {
	node* parent;

	int start;
	string name;
	int course;
	int work;

	node() {

	}

	node(int s, string n, int c, int w) {
		start = s;
		name = n;
		course = c;
		work = w;
	}
};

class nstack
{
private:
	node* root;

public:
	nstack();
	~nstack();

	void push(int s, string ne, int c, int w);
	node pop();
	node* top();

	bool isEmpty();
};

