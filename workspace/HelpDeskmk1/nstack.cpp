#include "stdafx.h"
#include "nstack.h"


nstack::nstack()
{
	if (root == NULL) {
		root = &node(-999);
	}
}


nstack::~nstack()
{
}

void nstack::push(node * n)
{
	root->parent = n;
	root = n;
	
}

node * nstack::pop()
{
	node* temp = root;
	root = root->parent;
	return temp;
}

node * nstack::top()
{
	return root;
}
