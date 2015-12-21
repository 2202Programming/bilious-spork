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
	nstack sideStack = nstack();
	int timeRemaining;
	
	for (int i = 0; i < maxTime; i++) {

		cout << "Time ", i, ", ";

		if (!helping && stack.top()->start == i) { /* Not Currently Helping Anyone*/
			current = &stack.pop();
			helping = true;
			string logEntry = "Time " + i;
			logEntry += ", Started helping " + current->name + " from COSC";
			logEntry += current->course + "\n";

			log = logEntry + log;
		}
		else if (helping && stack.top()->start == i) {
			if (stack.top()->course < current->course) {
				node* temp = current;
				current = &stack.pop();
				sideStack.push(temp);
				timeRemaining = current->work;
			}
			else {
				stack.pop();
			}
		}
		else if (helping) {
			timeRemaining--;
		}
		else if (true){}
		else {
			cout << "IDLE";
		}
	}

	while (true){}
    return 0;
}

