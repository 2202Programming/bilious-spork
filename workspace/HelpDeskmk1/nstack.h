#pragma once
#include "stdafx.h"
using namespace std;


struct node {
	string value;
	node* parent;

	node(int val) {
		value = val;
	}
	node() {
		value = "-999";
	}
};

class nstack
{
private:
	node* root;

public:
	nstack();
	~nstack();

	void push(string val);
	node pop();
	node* top();

	bool isEmpty();
};

