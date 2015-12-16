#pragma once
#include "stdafx.h"

#define WHITE 0 //If the node has never been visited
#define GREEN 1 //Node has been visited but is not finished
#define BLACK 2 //Done with this node no more reason to visit

using namespace std;

struct node {
	struct node* leftChild;
	struct node* rightChild;
	struct node* parent;
	int visits = WHITE;
	int key;
	int value;

	node(int k, int val) {
		key = k;
		value = val;
	}

	node(node* dady, int k, int val) {
		node(k, val);
		parent = dady;
	}
};

class bsTree
{
private:
	node* root();

public:
	bsTree(bool debug = false);
	~bsTree();

	void huffman(string filename);

	//Generic Utils
	node* getNode(int key);
	void setUnvisited();
	void reorder();

	//Tree Prints
	void printInOrder();
	void printBreadthFirst();
	void printDethFirst();

	//Insertion and Removal
	void insert();
	void remove(int key);
};

