// kas_op_lr_3.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>


using namespace std;

	int main()
	{
		int i, a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0, h = 0, j = 0, k = 0, n;
		char * stmp;
		cout << "Input size of text\n";
		cin >> n;
		char * m1 = new char[n];
		cout << "Input text\n";
		cin.ignore(1);
		cin.getline(m1, n, '\n');
		stmp = strtok(m1, " .,:;!?");
		while (stmp != NULL)
		{
			switch (strlen(stmp))
			{
			case 1:
			{
				a++;
				stmp = strtok(NULL, " .,:;!?");
				break;
			}
			case 2:
			{
				b++;
				stmp = strtok(NULL, " .,:;!?");
				break;
			}
			case 3:
			{
				c++;
				stmp = strtok(NULL, " .,:;!?");
				break;
			}
			case 4:
			{
				d++;
				stmp = strtok(NULL, " .,:;!?");
				break;
			}
			case 5:
			{
				e++;
				stmp = strtok(NULL, " .,:;!?");
				break;
			}
			case 6:
			{
				f++;
				stmp = strtok(NULL, " .,:;!?");
				break;
			}
			case 7:
			{
				g++;
				stmp = strtok(NULL, " .,:;!?");
				break;
			}
			case 8:
			{
				h++;
				stmp = strtok(NULL, " .,:;!?");
				break;
			}
			case 9:
			{
				j++;
				stmp = strtok(NULL, " .,:;!?");
				break;
			}
			case 10:
			{
				k++;
				stmp = strtok(NULL, " .,:;!?");
				break;
			}
			default:
			{
				stmp = strtok(NULL, " .,:;!?");
			}
			}
		}
		
			cout << "Quantity of worlds in length 1 symbol = " << a << endl << "Quantity of worlds in length 2 symbols = " << b << endl << "Quantity of worlds in length 3 symbols = " << c << endl << "Quantity of worlds in length 4 symbols = " << d << endl << "Quantity of worlds in length 5 symbols = " << e << endl << "Quantity of worlds in length 6 symbols =  " << f << endl << "Quantity of worlds in length 7 symbols = " << g << endl << "Quantity of worlds in length 8 symbols = " << h << endl << "Quantity of worlds in length 9 symbols = " << j << endl << "Quantity of worlds in length 10 symbols = " << k << endl;
			
		delete m1;
		system("pause");
			return 0;
	}

