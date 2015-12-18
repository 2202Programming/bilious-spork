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

void nstack::push(string val)
{
	node *n = new node();   // create new Node
	n->value = val;             // set value
	n->parent = root;         // make the node point to the next node.
							//  If the list is empty, this is NULL, so the end of the list --> OK
	root = n;
}

node nstack::pop()
{
	node *n = root;
	node ret = *n;

	root = root->parent;
	delete n;
	return ret;

}

node * nstack::top()
{
	return root;
}

bool nstack::isEmpty() {
	if (root == NULL) {
		return true;
	}
	return false;
}