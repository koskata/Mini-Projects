#pragma once
#include <string>
#include <iostream>
#include "Plant.h"
using namespace std;
class FloweringPlant : public Plant {
protected:
	int floweringPeriod;
public:
	FloweringPlant(string n, string c, int period) : Plant(n, c),
		floweringPeriod(period) {}
	void printInfo() override {
		cout << "Flowering Plant - Name: " << name << ", Color: " <<
			color
			<< ", Flowering Period: " << floweringPeriod << " days" <<
			endl;
	}
	void bloom() {
		cout << name << " is blooming!" << endl;
	}
};

