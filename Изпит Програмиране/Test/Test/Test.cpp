//В таблица се съдържат данни за група лица, за всяко от
//тях име и ЕГН.Да се състави програма, която избира следните операции
//от меню :
//	- създава нов празен файл;
//	- добавя към файла компоненти с данни за лица;
//	- изтрива компоненти от файла;
//	- заменя компоненти от файла с нови
//	- извежда списък на лицата, родени през посочена година;
//	- извежда данните на всички лица, включени във файла.

#include <stdio.h>
#include <string.h>
#include <stdlib.h>

struct LICE {
	char ime[31];
	char EGN[11];
};

FILE* fl;
char imefl[30];
LICE lice;

void readLice(LICE* lc) {
	printf("%20sВъведете името: ", "");
	gets(lc->ime);
	printf("%20sВъведете ЕГН: ", "");
	gets(lc->EGN);
}

void writeLice(LICE lc) {
	printf("Име: %-21s ЕГН: %s\n", lc.ime, lc.EGN);
}

int exist(char* ime) {
	FILE* f = fopen(ime, "r");
	fclose(f);
	return f != NULL;
}

void szdPrz() {
	char ch;
	if (exist(imefl))
	{
		printf("Файлът съществува! ");
		printf("Да го презпиша ли?");
		ch = getchar();
		if (ch == 'n')
		{
			return;
		}
	}
	fl = fopen(imefl, "w");
	fclose(fl);
	printf("\n Файлът е създаден. \n");
}

void dobaviane() {
	char ch;
	if (!exist(imefl))
	{
		printf("Файлът не е създаден! \n");
		return;
	}
	fl = fopen(imefl, "a+b");
	do
	{
		readLice(&lice);
		fwrite(&lice, sizeof(lice), 1, fl);
		printf("Ще продължите ли въвеждането? ");
		ch = getchar(); getchar();
	} while (ch != 'n');
	fclose(fl);
}

void iztrivane() {
	FILE* delFl;
	char EGN[11];
	if (!exist(imefl))
	{
		printf("Файлът не е създаден! \n");
		return;
	}
	printf("Въведете ЕГН: "); gets(EGN);
	fl = fopen(imefl, "rb");
	delFl = fopen("Del", "wb");
	fread(&lice, sizeof(lice), 1, fl);
	while (!feof(fl))
	{
		if (strcmp(lice.EGN, EGN) != 0)
		{
			fwrite(&lice, sizeof(lice), 1, delFl);
		}
		else
		{
			printf("Данни ЕГН %s изтрити.\n", EGN);
		}
		fread(&lice, sizeof(lice), 1, fl);
	}
	fclose(fl);
	fclose(delFl);
	remove(imefl);
	rename("Del", imefl);
}

void zamiana() {
	char EGN[11];
	if (!exist(imefl))
	{
		printf("Файлът не е създаден!\n"); return;
	}
	printf("Въведете ЕГН: "); gets(EGN);
	fl = fopen(imefl, "r+b");
	fread(&lice, sizeof(lice), 1, fl);
	while (!feof(fl))
	{
		if (strcmp(lice.EGN, EGN) == 0)
		{
			readLice(&lice);
			fseek(fl, -(long)sizeof(lice), SEEK_CUR);
			fwrite(&lice, sizeof(lice), 1, fl);
			printf("Данни за ЕГН %s заменени.\n", EGN);
			break;
		}
		fread(&lice, sizeof(lice), 1, fl);
	}
	fclose(fl);
	printf("\n");
}

void spisGod() {
	int k, godTrs, godLice;
	char gg[3];

	if (!exist(imefl))
	{
		printf("Файлът не е създаден!\n"); return;
	}
	printf("Задайте година на раждане: ");
	scanf("%d", &godTrs); getChar();
	fl = fopen(imefl, "rb");
	k = 0;
	fread(&lice, sizeof(lice), 1, fl);
	while (!feof(fl))
	{
		strncpy(gg, lice.EGN, 2);
		gg[2] = 0;
		godLice = atoi(gg);
		if (lice.EGN[2] > '3')
		{
			godLice += 2000;
		}
		else
		{
			godLice += 1900;
		}
		if (godLice == godTrs)
		{
			k++;
			writeLice(lice);
		}
		fread(&lice, sizeof(lice), 1, fl);
	}
	if (k == 0)
	{
		printf("Няма лица, родени през %d г.\n", godTrs);
	}
	fclose(fl);
}

void obSpis() {
	int k;
	if (!exist(imefl))
	{
		printf("Файлът не е създаден!\n");
		return;
	}
	fl = fopen(imefl, "rb"); k = 0;
	fread(&lice, sizeof(lice), 1, fl);
	while (!feof(fl))
	{
		k++;
		writeLice(lice);
		fread(&lice, sizeof(lice), 1, fl);
	}
	if (k == 0)
	{
		printf("Файлът е празен\n");
	}
	fclose(fl);
}


void main() {
	int c;
	printf("Име на файл: "); gets(imefl);
	do {
		printf("%20sМЕНЮ НА ИЗПЪЛНЯВАНИТЕ ОПЕРАЦИИ:\n", "");
		printf("%26s1. Създаване на нов файл\n", "");
		printf("%26s2. Добавяне на компоненти\n", "");
		printf("%26s3. Изтриване на компоненти\n", "");
		printf("%26s4. Замяна на компонент\n", "");
		printf("%26s5. Родени през дадена година\n", "");
		printf("%26s6. Списък на всички\n", "");
		printf("%20sПосочете операция или 0 за край: ", "");
		scanf("%d", &c); getchar();
		switch (c)
		{
			case 1:szdPrz();
				break;
			case 2:dobaviane();
				break;
			case 3: iztrivane();
				break;
			case 4: zamiana();
				break;
			case 5: spisGod();
				break;
			case 6: obSpis();
				break;
		}
	} while (c != 0);
}
