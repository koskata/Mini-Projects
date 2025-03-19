#include <iostream>
#include <vector>
#include <string>
#include "Plant.h"
#include "Rose.h"
#include "Moss.h"
using namespace std;
int main() {
	vector<Plant*> plants;
	plants.push_back(new Rose("Red Rose", "Red", 30, 50));
	plants.push_back(new Rose("White Rose", "White", 20, 40));
	plants.push_back(new Moss("Green Moss", "Green", "Forest", 2));
	plants.push_back(new Moss("Brown Moss", "Brown", "Rock", 5));
	for (Plant* plant : plants) {
		plant->printInfo();
	}
	return 0;
}