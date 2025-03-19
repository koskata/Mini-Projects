#pragma once
#include <string>
#include <iostream>
#include "NonFloweringPlant.h"
using namespace std;
class Moss : public NonFloweringPlant {
protected:
	int area;
public:
	Moss(string n, string c, string h, int area) :
		NonFloweringPlant(n, c, h), area(area) {}
	void printInfo() override {
		cout << "Moss - Name: " << name << ", Color: " << color
			<< ", Habitat: " << habitat << ", Area of moss: " << area
			<< " square meters" << endl;
	}
};