#pragma once
#include "stdafx.h"
using namespace std;


struct node {
	int value;
	node* parent;

	node(int val) {
		value = val;
	}
};

class nstack
{
private:
	node* root;

public:
	nstack();
	~nstack();

	void push(node* n);
	node* pop();
	node* top();
};

