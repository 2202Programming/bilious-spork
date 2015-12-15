#Intro to C++
## Runable 1

This is the first hands on c++ our class is going to be able to do it contains multiple projects for students to work on

	- Create A program that Converts the Celcius to Farenheight
	- Create A program based off of davids Switcher Class
	- Create an advanced Class the when given the command makeTable(...) Generates a talbe of values starting at one and advanceing to an endpoint at certain interval

### Source If you want to use it is also availble to copy on the server

```c++
double ftoC(double f){
	//TODO
}

class CelcciusTable
{
public:
	CelcciusTable();
	virtual ~CelcciusTable();
	void makeTable(double sVal, double eVal, double iVal);

private:
	double getFarenHeight(double i);
	double getKelvin(double i);
	void printRow(double celcius, double faren, double kelvin);
};

void CelcciusTable::makeTable(double sVal, double eVal, double iVal)
{
	std::cout << "Celcius" << "	" << "Faren" << "	" << "Kelvin" << std::endl;
	//TODO
}

double CelcciusTable::getFarenHeight(double i)
{
	//TODO
}

double CelcciusTable::getKelvin(double i)
{
	//TODO
}

void CelcciusTable::printRow(double celcius, double faren, double kelvin)
{
	std::cout << celcius << "	"<< faren << "	" << kelvin << std::endl;
}

void switcher(int * a, int * b) {
	//TODO
}

void switchRunner(){
	//TODO
}

void tableRunner(){
	//TODO
}

void converterRunner(){
	//TODO
}


int main(){
	//Uncomment one to test each individual program
	//swichRunner();
	//tableRunner();
	//convertorRunner()
}


```


