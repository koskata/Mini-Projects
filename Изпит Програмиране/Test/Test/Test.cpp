#include <stdio.h>
#include <string.h>
#include <stdlib.h>

struct STOKA {
	char ime[31];
	char kod[21];
	int kolichestvo;
	float tsena;
};

FILE* fl;
char imefl[20];
STOKA stoka;

void readStoka(STOKA* stoka) {
	printf("Wсгсагдасгдс: ");
	gets(stoka->ime);
	//...
}

void writeStoka(STOKA stoka) {
	printf("Ime: %-20s, Kod: %-10s ....");
}

int exist(char* fileime) {
	FILE* newFile = fopen(fileime, "r");
	return newFile != NULL;
}

void szdPrz() {
	char ch;
	if (exist(imefl))
	{
		printf("Файлът вече съществува! Искате ли да го презапишете? (y/n): ");
		ch = getchar();
		if (ch == 'n')
		{
			return;
		}
	}
	fl = fopen(imefl, "w");
	fclose(fl);
	printf("Успешно създаден файл!");
}

void dobaviane() {
	char ch;
	if (!exist(imefl))
	{
		printf("...."); 
		return;
	}
	fl = fopen(imefl, "a+b");
	do
	{
		readStoka(&stoka);
		fwrite(&stoka, sizeof(stoka), 1, fl);
		printf("Iskate li da produljite dobavianeto: (y/n)");
		ch = getchar();
	} while (ch != 'n');
	fclose(fl);
}

void iztrivane() {
	FILE* delFl;
	char kod[20];
	char ch;

	if (!exist(imefl))
	{
		printf("...");
		return;
	}

	fl = fopen(imefl, "rb");
	delFl = fopen(imefl, "wb");
	fread(&stoka, sizeof(stoka), 1, fl);

	printf("Wywedete kod: ");
	gets(kod);

	while (!feof(fl))
	{
		if (strcmp(stoka.kod, kod) != 0)
		{
			fwrite(&stoka, sizeof(stoka), 1, delFl);
		}
		else
		{
			printf("Uspeshno iztrita stoka s kod %s", kod);
		}
		fread(&stoka, sizeof(stoka), 1, fl);
	}

	fclose(fl);
	fclose(delFl);
	remove(imefl);
	rename("delFl", imefl);
}


void zamiana() {
	char kod[20];

	if (!exist(imefl))
	{
		printf("...");
		return;
	}

	fl = fopen(imefl, "r+b");
	fread(&stoka, sizeof(stoka), 1, fl);
	printf("Wywedete koda na stokata za zamiana: ");
	gets(kod);

	while (!feof(fl))
	{
		if (strcmp(stoka.kod, kod) == 0)
		{
			printf("Въведете новите данни за стоката: ");
			readStoka(&stoka);
			fseek(fl, -(long)sizeof(stoka), SEEK_CUR);
			fwrite(&stoka, sizeof(stoka), 1, fl);
		}
	}
	fclose(fl);
}

//#include <stdio.h>
//#include <string.h>
//#include <stdlib.h>
//
//struct STOKA {
//    char ime[50];
//    char kod[20];
//    int kolichestvo;
//    float tsena;
//};
//
//FILE* fl;
//char imefl[30];
//struct STOKA stoka;
//
//void readStoka(struct STOKA* s) {
//    printf("Въведете име на стоката: ");
//    gets(s->ime);
//    printf("Въведете уникален код на стоката: ");
//    gets(s->kod);
//    printf("Въведете количество: ");
//    scanf("%d", &s->kolichestvo);
//    printf("Въведете цена за единица: ");
//    scanf("%f", &s->tsena);
//    getchar();  // Премахва новия ред след scanf
//}
//
//void writeStoka(struct STOKA s) {
//    printf("Име: %-20s Код: %-10s Количество: %-5d Цена: %.2f\n",
//        s.ime, s.kod, s.kolichestvo, s.tsena);
//}
//
//int fileExists(char* filename) {
//    FILE* f = fopen(filename, "r");
//    if (f != NULL) {
//        fclose(f);
//        return 1;
//    }
//    return 0;
//}
//
//void createFile() {
//    char ch;
//    if (fileExists(imefl)) {
//        printf("Файлът вече съществува! Да го презапиша ли? (y/n): ");
//        ch = getchar();
//        getchar();  // Премахва новия ред след getchar
//        if (ch == 'n') {
//            return;
//        }
//    }
//    fl = fopen(imefl, "w");
//    fclose(fl);
//    printf("Файлът е създаден успешно.\n");
//}
//
//void addStoka() {
//    char ch;
//    if (!fileExists(imefl)) {
//        printf("Файлът не е създаден!\n");
//        return;
//    }
//    fl = fopen(imefl, "a+b");
//    do {
//        readStoka(&stoka);
//        fwrite(&stoka, sizeof(stoka), 1, fl);
//        printf("Да продължа ли с добавянето? (y/n): ");
//        ch = getchar();
//        getchar();  // Премахва новия ред след getchar
//    } while (ch != 'n');
//    fclose(fl);
//}
//
//void deleteStoka() {
//    FILE* tempFl;
//    char kod[20];
//    int found = 0;
//
//    if (!fileExists(imefl)) {
//        printf("Файлът не е създаден!\n");
//        return;
//    }
//
//    printf("Въведете кода на стоката за изтриване: ");
//    gets(kod);
//
//    fl = fopen(imefl, "rb");
//    tempFl = fopen("tempFile", "wb");
//
//    fread(&stoka, sizeof(stoka), 1, fl);
//    while (!feof(fl)) {
//        if (strcmp(stoka.kod, kod) != 0) {
//            fwrite(&stoka, sizeof(stoka), 1, tempFl);
//        }
//        else {
//            found = 1;
//            printf("Стоката с код %s беше изтрита.\n", kod);
//        }
//        fread(&stoka, sizeof(stoka), 1, fl);
//    }
//    fclose(fl);
//    fclose(tempFl);
//
//    if (found) {
//        remove(imefl);
//        rename("tempFile", imefl);
//    }
//    else {
//        printf("Стока с код %s не беше намерена.\n", kod);
//        remove("tempFile");
//    }
//}
//
//void replaceStoka() {
//    char kod[20];
//    int found = 0;
//
//    if (!fileExists(imefl)) {
//        printf("Файлът не е създаден!\n");
//        return;
//    }
//
//    printf("Въведете кода на стоката за замяна: ");
//    gets(kod);
//
//    fl = fopen(imefl, "r+b");
//
//    fread(&stoka, sizeof(stoka), 1, fl);
//    while (!feof(fl)) {
//        if (strcmp(stoka.kod, kod) == 0) {
//            found = 1;
//            printf("Въведете новите данни за стоката:\n");
//            readStoka(&stoka);
//            fseek(fl, -(long)sizeof(stoka), SEEK_CUR);
//            fwrite(&stoka, sizeof(stoka), 1, fl);
//            printf("Данните за стоката с код %s бяха заменени успешно.\n", kod);
//            break;
//        }
//        fread(&stoka, sizeof(stoka), 1, fl);
//    }
//    fclose(fl);
//
//    if (!found) {
//        printf("Стока с код %s не беше намерена.\n", kod);
//    }
//}
//
//void listStokiAbovePrice() {
//    float price;
//    int found = 0;
//
//    if (!fileExists(imefl)) {
//        printf("Файлът не е създаден!\n");
//        return;
//    }
//
//    printf("Въведете минималната цена: ");
//    scanf("%f", &price);
//    getchar();  // Премахва новия ред след scanf
//
//    fl = fopen(imefl, "rb");
//    fread(&stoka, sizeof(stoka), 1, fl);
//    while (!feof(fl)) {
//        if (stoka.tsena > price) {
//            writeStoka(stoka);
//            found = 1;
//        }
//        fread(&stoka, sizeof(stoka), 1, fl);
//    }
//    fclose(fl);
//
//    if (!found) {
//        printf("Няма стоки с цена над %.2f.\n", price);
//    }
//}
//
//void listAllStoki() {
//    int found = 0;
//
//    if (!fileExists(imefl)) {
//        printf("Файлът не е създаден!\n");
//        return;
//    }
//
//    fl = fopen(imefl, "rb");
//    fread(&stoka, sizeof(stoka), 1, fl);
//    while (!feof(fl)) {
//        writeStoka(stoka);
//        found = 1;
//        fread(&stoka, sizeof(stoka), 1, fl);
//    }
//    fclose(fl);
//
//    if (!found) {
//        printf("Файлът е празен.\n");
//    }
//}
//
//void menu() {
//    int choice;
//    printf("Име на файла: ");
//    gets(imefl);
//
//    do {
//        printf("\n--- МЕНЮ ---\n");
//        printf("1. Създаване на нов файл\n");
//        printf("2. Добавяне на стоки\n");
//        printf("3. Изтриване на стока\n");
//        printf("4. Замяна на стока\n");
//        printf("5. Списък на стоки с цена над дадена стойност\n");
//        printf("6. Списък на всички стоки\n");
//        printf("0. Изход\n");
//        printf("Изберете операция: ");
//        scanf("%d", &choice);
//        getchar();  // Премахва новия ред след scanf
//
//        switch (choice) {
//        case 1: createFile(); break;
//        case 2: addStoka(); break;
//        case 3: deleteStoka(); break;
//        case 4: replaceStoka(); break;
//        case 5: listStokiAbovePrice(); break;
//        case 6: listAllStoki(); break;
//        }
//    } while (choice != 0);
//}
//
//int main() {
//    menu();
//    return 0;
//}
