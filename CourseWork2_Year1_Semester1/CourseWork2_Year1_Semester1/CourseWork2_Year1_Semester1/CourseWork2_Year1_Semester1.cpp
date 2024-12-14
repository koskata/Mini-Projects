#include <stdio.h>
#include <string.h>
#include <stdlib.h>

const int MAX_STUDENTS = 100;
const int DISCIPLINES = 10;

struct Student {
    char name[50];
    char EGN[11];
    int facNumber;
    float grades[DISCIPLINES];
    float averageGrade;
};

void createStudentFile(Student students[], int* count) {
    printf("Enter number of students: ");
    scanf_s("%d", count);

    FILE* file;
    fopen_s(&file, "students.txt", "w");
    if (!file) {
        printf("Error creating file!\n");
        return;
    }

    for (int i = 0; i < *count; i++) {
        printf("Enter name for student %d: ", i + 1);
        scanf_s(" %[^\n]s", students[i].name, (unsigned)sizeof(students[i].name));

        printf("Enter EGN for student %d: ", i + 1);
        scanf_s("%s", students[i].EGN, (unsigned)sizeof(students[i].EGN));

        printf("Enter faculty number for student %d: ", i + 1);
        scanf_s("%d", &students[i].facNumber);

        printf("Enter grades for %d disciplines for student %d:\n", DISCIPLINES, i + 1);
        for (int j = 0; j < DISCIPLINES; j++) {
            printf("Grade %d: ", j + 1);
            scanf_s("%f", &students[i].grades[j]);
        }

        fprintf(file, "%s %s %d ", students[i].name, students[i].EGN, students[i].facNumber);
        for (int j = 0; j < DISCIPLINES; j++) {
            fprintf(file, "%.2f ", students[i].grades[j]);
        }
        fprintf(file, "\n");
    }
    fclose(file);
    printf("File 'students.txt' created successfully.\n");
}


void calculateAverageGrade(Student students[], int count) {
    for (int i = 0; i < count; i++) {
        float sum = 0;
        for (int j = 0; j < DISCIPLINES; j++) {
            sum += students[i].grades[j];
        }
        students[i].averageGrade = sum / DISCIPLINES;
    }

    printf("\nAverage grades for all students:\n");
    for (int i = 0; i < count; i++) {
        printf("Name: %s, Average Grade: %.2f\n", students[i].name, students[i].averageGrade);
    }
}

void displayFemaleStudents(Student students[], int count) {
    printf("\nFemale students:\n");
    bool found = false;

    for (int i = 0; i < count; i++) {
        int genderDigit = students[i].EGN[8] - '0';

        if (genderDigit % 2 != 0) {
            printf("Name: %s, Faculty Number: %d, Average Grade: %.2f\n",
                students[i].name, students[i].facNumber, students[i].averageGrade);
            found = true;
        }
    }

    if (!found) {
        printf("No female students found.\n");
    }
}

// Основната програма
void main() {
    Student students[MAX_STUDENTS];
    int count = 0;
    int choice;

    do {
        printf("\nMenu:\n");
        printf("1. Create student file\n");
        printf("2. Calculate and display average grades\n");
        printf("3. Display women students\n");
        printf("4. Exit\n");
        printf("Enter your choice: ");
        scanf_s("%d", &choice);

        switch (choice) {
        case 1:
            createStudentFile(students, &count);
            break;
        case 2:
            if (count > 0) {
                calculateAverageGrade(students, count);
            }
            else {
                printf("No students available. Please create a student file first.\n");
            }
            break;
        case 3:
            if (count > 0) {
                calculateAverageGrade(students, count);
                displayFemaleStudents(students, count);
            }
            else {
                printf("No students available. Please create a student file first.\n");
            }
            break;
        case 4:
            printf("Exiting program.\n");
            break;
        default:
            printf("Invalid choice. Please try again.\n");
        }
    } while (choice != 4);
}