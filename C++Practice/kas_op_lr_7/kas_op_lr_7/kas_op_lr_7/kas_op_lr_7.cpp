
#include "stdafx.h"
#include <stdio.h>
#include <math.h>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

void sposob1(int** a1,  int &n,  int &m)
{
	int counter1 = 0;
	int counter2 = 0;
	int i, j,i0,j0,k=0,l=0, fff=-1,fff1=-1;
	

	for (i = 0; i < n; i++)
	{
		
		for (j = 0; j < m; j++)
		{
			if (a1[i][j] != 0)
			{
				
				counter1++;
				break;
			}
		}
		
	}
	for (j = 0; j < m; j++)
	{

		
		for (i = 0; i < n; i++)
		{
			if (a1[i][j] != 0)
			{
				
				counter2++;
				break;
			}
		}
		
	}
	int **a11 = new int*[n];
	for (i = 0; i<n; i++)
		a11[i] = new int[m];
	for (i = 0; i<n; i++)
	{
		
		fff = -1;
		for (j = 0; j<m; j++)
		{
			if (a1[i][j] != 0)
			{
				fff = 0;
				
				break;
			}
		}

		if (fff == 0)
		{
			printf("Nomer stroki s polozjhitel'nim elementom: %i\n", i);
			for (i = 0; i < n; i++)
			{
				l = 0;
			for (j = 0; j < m; j++)
			{
				a11[k][l] = a1[i][j];

				l++;
			}
			k++;
				}
			if (counter1 == n)
				break;
			
		}
		
	}

	l = 0;
	k = 0;
	for (j = 0; j<m; j++)
	{
		
		fff1 = -1;
		for (i = 0; i<n; i++)
		{
			if (a1[i][j] != 0)
			{
				fff1 = 0;

				break;
			}
		}
		counter2++;
		if (fff1 == 0)
		{
			
			for (j = 0; j < m; j++)
			{
				k = 0;
				for (i = 0; i < n; i++)
				{
					a11[k][l] = a1[i][j];
					k++;

				}
				l++;
			}
			if (counter2 == m)
				break;
		}
		
	}
	for (k = 0; k < n; k++)
	{
		for (l = 0; l < m; l++)
			printf("%i\t", a11[k][l]);
		printf("\n");
	}
	for (i = 0; i < n; i++)
		delete[] a11[i];
	delete[]a11;
}
int main(void)
{
	int i, j, m, n, s, i0, j0, fff, fff1;
	fff = -1;
	fff1 = -1;
	s = 0;
	i0 = 0;
	j0 = 0;
	i = 0;
	j = 0;
	
	/*int **a1 = (int **)malloc(i * sizeof(int *));;*/
	printf("Vvedite razmernost' matrici\n");
	scanf("%i%i", &n, &m);
	int **a1 = new int* [n];
	for (i = 0; i<n; i++)
		a1[i] = new int [n];
		/*a1[i] = (int *)malloc(m * sizeof(int));*/
		
		printf("\nVvedite matricu\n");
		for (i = 0; i<n; i++)
			for (j = 0; j<m; j++)
			{
				printf("a[%i][%i]= ", i, j);
				scanf("%i", &a1[i][j]);
			}
	printf("1. Resul'tiruyushaya matrica [%i]x[%i]: \n", n, m);
	
		sposob1(a1, n, m);
	for (i = 0; i < n; i++)
		delete [] a1[i];
	delete[]a1;


	system("pause");
	/*printf("\n\n");
	printf("2. Nomer stroki s polozytel'numi elementami: ");
	for (i = 0; i<n; i++)
	{
		for (j = 0; j<m; j++)
			if (a[i][j]>0)
			{
				printf("%i \n", i);

	
	printf("Vvedite razmernost' matrici\n");
	scanf("%i%i", &n, &m);
	printf("\nVvedite matricu\n");
	for (i = 0; i<n; i++)
		for (j = 0; j<m; j++)
		{
			printf("a[%i][%i]= ", i, j);
			scanf("%i", &a[i][j]);
		}
	printf("Ishodnaya matrica %ix%i:\n", n, m);
	for (i = 0; i<n; i++)
	{
		for (j = 0; j<m; j++)

			printf("%i\t", a1[i][j]);
		printf("\n");
	}
flag:
	for (i = 0; i<n; i++)
	{
		fff = -1;
		for (j = 0; j<m; j++)
		{
			if (a[i][j] != 0)
			{
				fff = 0;

				break;
			}
		}
		if (fff == -1)
		{
			i0 = i;
			for (i = i0; i<n; i++)
				for (j = 0; j<m; j++)
					a[i][j] = a[i + 1][j];
			n--;
			goto flag;
		}
	}
flag1:
	for (j = 0; j<m; j++)
	{
		fff1 = -1;
		for (i = 0; i<n; i++)
		{
			if (a[i][j] != 0)
			{
				fff1 = 0;

				break;
			}
		}
		if (fff1 == -1)
		{
			j0 = j;
			for (j = j0; j<m; j++)
				for (i = 0; i<n; i++)
					a[i][j] = a[i][j + 1];
			m--;
			goto flag1;
		}
	}
	printf("1. Resul'tiruyushaya matrica [%i]x[%i]: \n", n, m);
	for (i = 0; i<n; i++)
	{
		for (j = 0; j<m; j++)
			printf("%i\t", a[i][j]);
		printf("\n");
	}
	printf("\n\n");
	printf("2. Nomer stroki s polozytel'numi elementami: ");
	for (i = 0; i<n; i++)
	{
		for (j = 0; j<m; j++)
			if (a[i][j]>0)
			{
				printf("%i \n", i);*/
				return 0;
			}

