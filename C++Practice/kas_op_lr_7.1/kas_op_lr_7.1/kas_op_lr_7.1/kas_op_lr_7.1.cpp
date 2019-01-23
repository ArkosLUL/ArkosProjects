
#include "stdafx.h"
#include <stdio.h>
#include <math.h>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

void sposob1(int** a1, int n, int m)
{
	int counter1 = 0;
	int counter2 = 0;
	int i, j, i0, j0, k = 0, l = 0, fff = -1, fff1 = -1;

	
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
		if (counter1 == n)
			break;
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

		if (counter2 == m)
			break;
	}
	for (int ij = 0; ij < (m > n ? m : n); ij++)
	{
		for (i = 0; i < n; i++)
		{
			fff = -1;
			for (j = 0; j < m; j++)
			{
				if (a1[i][j] != 0)
				{
					fff = 0;

					break;
				}
			}
			if (i == n-1)
				break;
			if (fff == -1)
			{
				
					for (j = 0; j < m; j++)
					{
						a1[i][j] = a1[i + 1][j];						
					}
					
			}
		}
		

		for (j = 0; j < m; j++)
		{
			fff1 = -1;
			for (i = 0; i < n; i++)
			{
				if (a1[i][j] != 0)
				{
					fff1 = 0;

					break;
				}
			}
			if (j == m - 1)
				break;
			if (fff1 == -1)
			{
				
					for (i = 0; i < n; i++)
					{
						a1[i][j] = a1[i][j + 1];

					}
				
			}

		}
	}
	
	for (i = 0; i < counter1; i++)
	{
		for (j = 0; j < counter2; j++)
			printf("%i\t", a1[i][j]);
		printf("\n");
	}
	printf("\n");
	printf("2. Nomer stroki s polozytel'numi elementami: ");
	for (i = 0; i < counter1; i++)
	{
		fff = -1;
		for (j = 0; j < counter2; j++)
		{
			if (a1[i][j] > 0)
			{
				fff = 0;

				
			}
			if (fff == 0)
			{

				printf("\n %i\n", i);
				break;
			}
			
		}
		if (fff == 0)
		{
			break;
		}
	}
}
void sposob2(int* a2, int n, int m)
{
	int counter1 = 0;
	int counter2 = 0;
	int i, j, i0, j0, k = 0, l = 0, fff = -1, fff1 = -1;


	for (i = 0; i < n; i++)
	{

		for (j = 0; j < m; j++)
		{
			if (a2[i*m+j] != 0)
			{

				counter1++;
				break;
			}
		}
		if (counter1 == n)
			break;
	}
	for (j = 0; j < m; j++)
	{


		for (i = 0; i < n; i++)
		{
			if (a2[i*m + j] != 0)
			{

				counter2++;
				break;
			}
		}

		if (counter2 == m)
			break;
	}
	for (int ij = 0; ij < (m > n ? m : n); ij++)
	{
		for (i = 0; i < n; i++)
		{
			fff = -1;
			for (j = 0; j < m; j++)
			{
				if (a2[i*m + j] != 0)
				{
					fff = 0;

					break;
				}
			}
			if (i == n - 1);
			{
				break;
			}
			if (fff == -1)
			{
				
					for (j = 0; j < m; j++)
						a2[i*m + j] = a2[(i + 1)*m + j];

			}
		}
	}
	for (j = 0; j < m; j++)
	{
		fff1 = -1;
		for (i = 0; i < n; i++)
		{
			if (a2[i*m + j] != 0)
			{
				fff1 = 0;

				break;
			}
		}
		if (j == m - 1)
		{
			break;
		}
		if (fff1 == -1)
		{
			
			for (i = 0; i < n; i++)
			{
				a2[i*m + j] = a2[i*m + (j + 1)];
			}

		}
	}

	for (i = 0; i < counter1; i++)
	{
		for (j = 0; j < counter2; j++)
			printf("%i\t", a2[i*m + j]);
		printf("\n");
	}
	printf("\n");
	printf("2. Nomer stroki s polozytel'numi elementami: ");
	for (i = 0; i < counter1; i++)
	{
		fff = -1;
		for (j = 0; j < counter2; j++)
		{
			if (a2[i*m+j] > 0)
			{
				fff = 0;


			}
			if (fff == 0)
			{

				printf("\n %i\n", i);
				break;
			}

		}
		if (fff == 0)
		{
			break;
		}
	}
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

	
	printf("Vvedite razmernost' matrici\n");
	scanf("%i%i", &n, &m);
	int **a1 = new int*[n];
	for (i = 0; i<n; i++)
		a1[i] = new int[m];
	int *a2 = (int *)malloc(n*m * sizeof(int *));


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
		delete[] a1[i];
	delete[]a1;
	printf("Vvedite razmernost' matrici\n");
	scanf("%i%i", &n, &m);
	printf("\nVvedite matricu\n");
	for (i = 0; i<n; i++)
		for (j = 0; j<m; j++)
		{
			printf("a[%i][%i]= ", i, j);
			scanf("%i", &a2[i*m + j]);
		}
	printf("1. Resul'tiruyushaya matrica [%i]x[%i]: \n", n, m);
	sposob2(a2, n, m);
	delete[]a2;
	system("pause");
	return(0);
}

