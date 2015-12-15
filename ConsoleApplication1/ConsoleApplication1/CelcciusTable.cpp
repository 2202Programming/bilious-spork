#include "stdafx.h"
#include "CelcciusTable.h"


CelcciusTable::CelcciusTable()
{

}


CelcciusTable::~CelcciusTable()
{
}

void CelcciusTable::makeTable(double sVal, double eVal, double iVal)
{
	std::cout << "Celcius" << "	" << "Faren" << "	" << "Kelvin" << std::endl;
	for (double i = sVal; i < eVal; i += iVal) {
		printRow(i, getFarenHeight(i), getKelvin(i));
	}
}

double CelcciusTable::getFarenHeight(double i)
{
	return (i - 32.0) * (5.0 / 9.0);
}

double CelcciusTable::getKelvin(double i)
{
	return i + 273.15;
}

void CelcciusTable::printRow(double celcius, double faren, double kelvin)
{
	std::cout << celcius << "	"<< faren << "	" << kelvin << std::endl;
}
