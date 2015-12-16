#pragma once
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

