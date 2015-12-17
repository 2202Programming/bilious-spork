// HelpDeskmk1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

//INTERVAL
using namespace std;

int main()
{
	nstack stack = nstack();
	node* bob = &node(1);
	node* joe = &node(2);

	cout << bob->value << endl;

	stack.push(bob);
	stack.push(joe);


	cout << stack.pop()->value << stack.pop()->value << endl;


	while (true){}
    return 0;
}

