
#include "stdafx.h"
#include <stdio.h>
#include <iostream>
#include <fstream>
#include <iomanip>


using namespace std;


struct Team {
	char team[20];
	int win_lose;
	int lose_win;
	int two_in_row;

};

int main()
{
	
	setlocale(LC_ALL,"Russian");
	
	fstream file1;
	file1.open("old.txt",ios::in | ios::out);

	ofstream file2;
	file2.open("result.txt");
	ofstream file3;
	file3.open("result2.txt");
	bool flag=false;
	
	///int i = 0;
	if(!file1.is_open())
		{
			cout<< "Что-то не так с входным файлом, скорее всего его не существует" << endl ;
			system("pause");
			exit(1);
	}

	if(!file2.is_open())
	{
		cout<< "Что-то не так с выходным файлом, скорее всего его не существует" << endl ;
		system("pause");
		exit(2);

	}
	if(!file3.is_open())
	{
		cout<< "Что-то не так с выходным файлом, скорее всего его не существует" << endl ;
		system("pause");
		exit(2);

	}
	cout << "Входные данные: " << endl;
	char *v1[20];
	int i = 0;
	char buf[1023];
	file1.getline(buf, 1023, '\n');
	char *pend;
	pend = strtok(buf,"\t");
	
	while ( pend != NULL)
	{

		v1[i] = new char [20];
		v1[i] = pend;
		pend = strtok(NULL,"\t");
		i++;
	}
	int arr[10][20];
	int n = 0;
	while(!file1.eof())
	{
		char str[20];
		file1.getline(str,20,'\t');
		cout << str << " " << i << endl;
		for(int m = 0; m < 2*i; m++)
		{
			if( ((m-n) <= (n+1)) && (m-n) > (n - 1))
				arr[n][m] = -1;
			else file1 >> arr[n][m];
			cout << arr[n][m] << '\t';
		}
		n++;
		cout << endl;
		file1.ignore();
	}
	int** arr2 = new int*[i];
	for (n = 0; n < i;n++)
		arr2[n] = new int[i];
	for ( n = 0; n < i; n++)
	{
		int m1 = 0;
		for(int m = 1; m < i*2; m+=2)
		{
			if( arr[n][m] == -1)
				{
					arr2[n][m1] = -10;
					m1++;
					continue;
			}
			else if(arr[n][m] > arr[n][m-1])
					arr2[n][m1] = 1;//win
				else if(arr[n][m] < arr[n][m-1])
					arr2[n][m1] = -1;//lose
				else arr2[n][m1] = 0;//draw
			m1++;

		}
	}

	for(int i1 = 0; i1 < i;i1++)
	{
		for(int j1 = 0; j1 < i ; j1++)
		{
			
			cout << setw(3) <<  arr2[i1][j1] << " ";
		}
		cout << endl;
	}


	int b = 0;
	
	cout <<"Выходные данные"<< endl;
	file2 << setw(20) << left << "Название команды " << setw(20) << "Количество win-lose " << endl;
	file3 << setw(20) << left << "Название команды " << setw(20) << "Количество lose-win " << endl;
	for(b = 0; b < i; b++)
	{	Team team1;
		strcpy(team1.team,v1[b]);
		team1.lose_win = 0;
		team1.win_lose = 0;
		team1.two_in_row = 0;

		for(int a = 0;a < i; a++)
		{
			if(arr2[b][a] == -10)
				continue;
			if(arr2[b][a] == arr2[a][b])
			{
					if(arr2[b][a] == -1)
					{
						team1.lose_win+=1;
							continue;
					}
					if(arr2[b][a] == 1)
					{
							team1.win_lose +=1;
							continue;
					}
					if(arr2[b][a] == 0)
						team1.two_in_row +=1;
			}else if(arr2[b][a] + arr2[a][b] == 0)
				team1.two_in_row+=1;
		}
		
		file2 << setw(20) << left << team1.team << setw(3) << team1.win_lose << setw(17) <<left << "пар матчей win-lose " << endl;
		cout << setw(20) << left << team1.team << setw(3) << team1.win_lose << setw(17) <<left << "пар матчей win-lose " << endl;
		file3 << setw(20) << left << team1.team << setw(3) << team1.lose_win << setw(17) <<left << "пар матчей lose-win " << endl;
		cout << setw(20) << left << team1.team << setw(3) << team1.lose_win << setw(17) << left << "пар матчей lose-win" << endl;
		cout << setw(20) << left << team1.team << setw(3)<< team1.two_in_row << setw(17) << left << "пар матчей 2 in row" << endl;
		
	}

	system("pause");

	return 0;
}