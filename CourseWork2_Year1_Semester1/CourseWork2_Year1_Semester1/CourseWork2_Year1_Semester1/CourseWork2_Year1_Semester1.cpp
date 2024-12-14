#include <iostream>
#include <fstream>
#include <vector>
#include <string>
#include <iomanip>

using namespace std;

struct Student {
    string name;
    string facultyNumber;
    string egn; // Добавено поле за ЕГН
    double grades[10];
    double average;
};

void createFile() {
    ofstream outFile("students.txt");
    if (!outFile) {
        cerr << "Cannot create the file!" << endl;
        return;
    }
    outFile.close();
    cout << "File created successfully!" << endl;
}

void recordNewStudents() {
    vector<Student> students;
    int numStudents;
    cout << "Enter the number of students to record: ";
    cin >> numStudents;
    students.resize(numStudents);

    for (int i = 0; i < numStudents; ++i) {
        cout << "Enter the name of student " << i + 1 << ": ";
        cin >> students[i].name;
        cout << "Enter the Faculty Number of student " << i + 1 << ": ";
        cin >> students[i].facultyNumber;
        cout << "Enter the EGN of student " << i + 1 << ": "; // Въведете ЕГН
        cin >> students[i].egn;

        cout << "Enter the grades for 10 subjects: ";
        double sum = 0;
        for (int j = 0; j < 10; ++j) {
            cin >> students[i].grades[j];
            sum += students[i].grades[j];
        }
        students[i].average = sum / 10;
    }

    ofstream outFile("students.txt", ios::app);
    if (!outFile) {
        cerr << "Cannot open the file for writing!" << endl;
        return;
    }

    for (const auto& student : students) {
        outFile << student.name << " "
            << student.facultyNumber << " "
            << student.egn << " " // Записване на ЕГН
            << student.average << endl;
    }

    outFile.close();
    cout << "Students recorded successfully!" << endl;
}

void displayFemaleStudents() {
    ifstream inFile("students.txt");
    if (!inFile) {
        cerr << "Cannot open the file!" << endl;
        return;
    }

    string name, facultyNumber, egn; // Добавено поле за ЕГН
    double average;
    cout << fixed << setprecision(2);
    while (inFile >> name >> facultyNumber >> egn >> average) { // Четене на ЕГН
        if (name.back() == 'a' || name.back() == 'e') { // Прост проверка за женски имена
            
        }
        cout << "Faculty Number: " << facultyNumber
            << ", EGN: " << egn // Извеждане на ЕГН
            << ", Average Grade: " << average << endl;
    }

    inFile.close();
}

int main() {
    int choice;
    do {
        cout << "\nMenu:\n";
        cout << "1. Create file\n";
        cout << "2. Record new students\n";
        cout << "3. Display female students' faculty numbers, EGN, and average grades\n";
        cout << "4. Exit\n";
        cout << "Enter your choice: ";
        cin >> choice;

        switch (choice) {
        case 1:
            createFile();
            break;
        case 2:
            recordNewStudents();
            break;
        case 3:
            displayFemaleStudents();
            break;
        case 4:
            cout << "Exiting the program." << endl;
            break;
        default:
            cout << "Invalid choice! Please try again." << endl;
        }
    } while (choice != 4);

    return 0;
}