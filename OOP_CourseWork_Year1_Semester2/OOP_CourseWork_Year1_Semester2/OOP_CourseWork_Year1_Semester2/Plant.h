#pragma once
#include <string>
using namespace std;
class Plant {
protected:
	string name;
	string color;
public:
	virtual void printInfo() = 0;
	Plant(string n, string c) : name(n), color(c) {}
	virtual ~Plant() {}
};