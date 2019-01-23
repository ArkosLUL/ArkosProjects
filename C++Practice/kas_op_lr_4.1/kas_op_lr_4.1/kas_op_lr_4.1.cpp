// kas_op_lr_4.1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <fstream>

using namespace std;


int main()
{
	struct Match
	{
		char name1[20];
		int o1;
		int o2;
		char name2[20];

	}m1[16];
	ifstream f1;
	f1.open("chempionat1.txt");
	for (int i = 0; i < 16; i++)
	{
		while (!f1.eof())
		{
			f1.get(m1[i].name1, 20, ' ');
			f1 >> m1[i].o1 >> m1[i].o2;
			f1.get(m1[i].name2, 20, ' ');
		}
	}
    return 0;
}

