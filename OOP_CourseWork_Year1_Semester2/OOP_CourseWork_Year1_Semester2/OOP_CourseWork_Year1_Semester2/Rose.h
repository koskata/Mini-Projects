#pragma once
#include <string>
#include <iostream>
#include "FloweringPlant.h"
using namespace std;
class Rose : public FloweringPlant {
protected:
	int length;
public:
	Rose(string n, string c, int period, int length) :
		FloweringPlant(n, c, period), length(length) {}
	void printInfo() override {
		cout << "Rose - Name: " << name << ", Color: " << color
			<< ", Flowering Period: " << floweringPeriod
			<< " days" << ", Length: " << length << " cm" << endl;
	}
};