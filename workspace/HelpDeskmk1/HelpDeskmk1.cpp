// HelpDeskmk1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

//INTERVAL
using namespace std;

int main()
{
	nstack stack = nstack();

	int maxTime;

	int start;
	string name;
	int course;
	int work;

	cin >> maxTime;
	while (cin) {
		cin >> start >> name >> course >> work;
		stack.push(start, name, course, work);
	}
	string log = "";

	bool helping = false;
	node* current = new node();
	
	for (int i = 0; i < maxTime; i++) {
		if (!helping && stack.top()->start == i) {
			current = &stack.pop();
			helping = true;
			string logEntry = "Time " + i;
			logEntry += ", Started helping " + current->name + " from COSC";
			logEntry += current->course + "\n";

			log = logEntry + log;
		}
		else if (helping && stack.top()->start == i) {

		}
	}

	while (true){}
    return 0;
}

