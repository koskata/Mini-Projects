#pragma once
#include <string>
#include <iostream>
#include "Plant.h"
using namespace std;
class NonFloweringPlant : public Plant {
protected:
	string habitat;
public:
	NonFloweringPlant(string n, string c, string h) : Plant(n, c),
		habitat(h) {}
	void printInfo() override {
		cout << "Non-Flowering Plant - Name: " << name << ", Color: " <<
			color
			<< ", Habitat: " << habitat << endl;
	}
	void photosynthesize() {
		cout << name << " is photosynthesizing." << endl;
	}
};

