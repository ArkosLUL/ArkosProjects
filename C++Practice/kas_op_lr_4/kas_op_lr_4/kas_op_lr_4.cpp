// kas_op_lr_4.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <fstream>
#include <string>
#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");
	ifstream tablica("chempionat.txt");
	ofstream tab1("vuigrala_proigrala.txt");
	ofstream tab2("proigrala_vuigrala.txt");
	string n[100];
	char n1[1000];
	char pt;
	char Comand[500];
	char *ComandName[100];
	char *Rezultati[400][400];
	char *stmp;
	char buff[400];
	while(tablica >> pt)
		for(int i =0; i<100; i++)
	n[i]+= pt;
	cout << n;
	cout <<endl<< n1;
	stmp = strtok(n1, "\t");
	//stmp = strtok(NULL, ";");
	int i = 0;
	while (stmp != NULL)
	{
		ComandName[i] = strcpy(Comand, stmp);
		stmp = strtok(NULL, "\t");
		
		i++;

	}
	i = 0;
	int j = 0;
	while (!tablica.eof())
	{
		tablica.getline(buff, 400);
		stmp = strtok(buff, "\t");
		while (stmp != NULL)
		{
			stmp = strtok(NULL, ";");

			Rezultati[i][j] = stmp;
			j++;
		}
		i++;
		j = 0;
	}
	tablica.close();
	tab1.close();
	tab2.close();
	system("pause");
    return 0;
}

