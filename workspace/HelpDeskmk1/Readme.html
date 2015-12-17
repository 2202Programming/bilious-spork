<div style="text-align: center; background-color: #336600; color: white;">

# COSC 2010 / 2100 Data Structures

## Fall 2014

## Homework Assignment #3 : Help Desk, Help Thyself

</div>

<div>Due: Wednesday, September 17th, Noon CDT  
Submit: Turn in your HelpDesk.java source file (and any other helper Java source files you devise) using the <tt>turnin</tt> command on <tt>morbius.mscs.mu.edu</tt>.  
Do **not** turnin the <tt>HelpDeskRunner</tt> class, or any of the [Stack Demonstration Code](http://www.mscs.mu.edu/~brylow/cosc2100/Fall2014/Demos/StackDemo/). These files will be ignored by TA-bot.  
Work may be completed in teams of two.  
Be certain to include both partner's names in your file. Try to avoid both partners submitting code -- we have to grade that twice, and only the lower grade will be kept.  
You may submit multiple times, but only the last turnin will be kept. The automatic submission system will not accept work after the deadline.</div>

<div style="text-align: center; background-color: #336600; color: white;">

### Stacks

</div>

<div>

This assignment uses several _Stacks_ to simulate a HelpDesk for computer science students. Use the [Stack Demonstration Code](http://www.mscs.mu.edu/~brylow/cosc2100/Fall2014/Demos/StackDemo/) from class to implement your solution.

The <tt>DSLinkedStack</tt> class bears close resemblance to the Stack classes in Chapter 3 of your textbook, and has the following API:

*   <tt>void push(T element)</tt>  
    Adds a fresh element onto the Stack.
*   <tt>void pop() throws StackUnderflowException</tt>  
    Removes the top element from the Stack.
*   <tt>T top() throws StackUnderflowException</tt>  
    Returns the top element from the Stack without removing it.
*   <tt>boolean isEmpty()</tt>  
    Checks whether the Stack is empty.

Note that this is a _generic_ Java data structure, and can be instantiated with any Java class in place of type "<tt>T</tt>".

</div>

<div style="text-align: center; background-color: #336600; color: white;">

### Help Desk Simulation

</div>

<div>

Your task is to simulate a Help Desk for computer science students seeking assistance with their homework. This rudimentary Help Desk will only be able to help one student at a time, although others may sit in a nearby stack of chairs while they wait.

Because the Help Desk is aimed primarily at helping students in the introductory classes, a draconian priority policy has been set in place: If a student arrives at the help desk from a lower numbered course than the student who is currently being helped, the current student will be moved to the stack of waiting chairs until the new student has been helped. If a student arrives from a higher (or equal) course than the student currently being helped, the new student will be turned away.

The HelpDesk tutor also keeps track of who is coming and going, using a pile of notecards. When the shift is over, the notecards are read back and logged in reverse order.

Your <tt>HelpDesk</tt> class will be tested for the following API:

*   <tt>public void step()</tt>  
    Advance the simulation one minute.
*   <tt>public void addStudent(String name, int course, int workload)</tt>  
    Add an arriving student with the indicate name, course number, and minutes of workload. If the current student has a lower or equal course number, the arriving student is turned away. If the current student has a higher course number, the current student is preempted while the new student is helped.
*   <tt>public int getTime()</tt>  
    Get the current simulation time in minutes.
*   <tt>public String toString()</tt>  
    Return the status of the simulation. This produces strings like, "<tt>Time 2, Helping Jack from COSC1010</tt>", or "<tt>Time 9, IDLE</tt>".
*   <tt>public String getLog()</tt>  
    Return the entire HelpDesk session log.

</div>

<div style="text-align: center; background-color: #336600; color: white;">

### Input

</div>

<div>

Input to the <tt>HelpDesk</tt> simulator will consist of an initial line with a number of minutes for the simulation to run.

Each subsequent line of input will consist of an arrival time (in minutes), a name, a course number (we assume all courses are COSC, and therefore the letter code is not included,) and a workload time in minutes. If only students arrived at the Help Desk in the real world labeled with precisely how many minutes it would take to help them...

Input arrival times will occur strictly in order -- so each student's arrival will be strictly greater than or equal to the previous student's. You may assume that workload times will be strictly positive, non-zero integers.

Here are some example inputs and outputs.

## Example Run #1

Ten minute simulation, three students arrive for help at non-overlapping times.  
Input:  

```
10
2 Jack 1010 2  
5 Jill 1020 2  
8 Robin 2010 1  
```

Output:  
```
Time 0, IDLE  
Time 1, IDLE  
Time 2, Helping Jack from COSC1010  
Time 3, Helping Jack from COSC1010  
Time 4, IDLE  
Time 5, Helping Jill from COSC1020  
Time 6, Helping Jill from COSC1020  
Time 7, IDLE  
Time 8, Helping Robin from COSC2010  
Time 9, IDLE  

LOG:  
Time 9, Finished helping Robin from COSC2010  
Time 8, Started helping Robin from COSC2010  
Time 7, Finished helping Jill from COSC1020  
Time 5, Started helping Jill from COSC1020  
Time 4, Finished helping Jack from COSC1010  
Time 2, Started helping Jack from COSC1010  
```

## Example Run #2

Twenty minute simulation, three students arrive for help at overlapping times in reverse priority order.  
Input:  

```20
2 Robin 2010 8  
5 Jill 1020 6  
7 Jack 1010 2  
```
Output:  

```Time 0, IDLE  
Time 1, IDLE  
Time 2, Helping Robin from COSC2010  
Time 3, Helping Robin from COSC2010  
Time 4, Helping Robin from COSC2010  
Time 5, Helping Jill from COSC1020  
Time 6, Helping Jill from COSC1020  
Time 7, Helping Jack from COSC1010  
Time 8, Helping Jack from COSC1010  
Time 9, Helping Jill from COSC1020  
Time 10, Helping Jill from COSC1020  
Time 11, Helping Jill from COSC1020  
Time 12, Helping Jill from COSC1020  
Time 13, Helping Robin from COSC2010  
Time 14, Helping Robin from COSC2010  
Time 15, Helping Robin from COSC2010  
Time 16, Helping Robin from COSC2010  
Time 17, Helping Robin from COSC2010  
Time 18, IDLE  
Time 19, IDLE  

LOG:  
Time 18, Finished helping Robin from COSC2010  
Time 13, Finished helping Jill from COSC1020  
Time 9, Finished helping Jack from COSC1010  
Time 7, Started helping Jack from COSC1010  
Time 5, Started helping Jill from COSC1020  
Time 2, Started helping Robin from COSC2010  
```
## Example Run #3

Twenty minute simulation, third student is turned away.  
#####Input:  

````20  
2 Robin 2010 8  
5 Jill 1020 6  
7 Jack 3100 2  
```
#####Output:  

```Time 0, IDLE  
Time 1, IDLE  
Time 2, Helping Robin from COSC2010  
Time 3, Helping Robin from COSC2010  
Time 4, Helping Robin from COSC2010  
Time 5, Helping Jill from COSC1020  
Time 6, Helping Jill from COSC1020  
Time 7, Helping Jill from COSC1020  
Time 8, Helping Jill from COSC1020  
Time 9, Helping Jill from COSC1020  
Time 10, Helping Jill from COSC1020  
Time 11, Helping Robin from COSC2010  
Time 12, Helping Robin from COSC2010  
Time 13, Helping Robin from COSC2010  
Time 14, Helping Robin from COSC2010  
Time 15, Helping Robin from COSC2010  
Time 16, IDLE  
Time 17, IDLE  
Time 18, IDLE  
Time 19, IDLE  

LOG:  
Time 16, Finished helping Robin from COSC2010  
Time 11, Finished helping Jill from COSC1020  
Time 7, Turned away Jack from COSC3100  
Time 5, Started helping Jill from COSC1020  
Time 2, Started helping Robin from COSC2010  
```
For your convenience, we provide the [HelpDeskRunner.java](HelpDeskRunner.java) file we are using for parsing input and running the simulation.

</div>

* * *

[Revised 2014 Sep 15 22:22 DWB]