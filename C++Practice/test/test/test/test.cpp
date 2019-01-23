// test.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "stdio.h"
#include "stdlib.h"
#include <iostream>
void funk(int **arr)
{
	int i, j;
	int **arr1 = new int*[2];
	for (i = 0; i < 3; i++)
	{
		arr1[i] = new int[2];
	}
	for (i = 0; i < 3; i++)
	{
		for (j = 0; j < 3; j++)
		{
			arr1[i][j] = arr[i][j];
			printf("%i\t", arr1[i][j]);
			printf("\n");
		}
	}

}
int main()
{
	int i, j;
	int **arr = new int*[2];
	for (i = 0; i < 3; i++)
	{
		arr[i] = new int[2];
	}
	for (i = 0; i < 3; i++)
	{
		for (j = 0; j < 3; j++)
			scanf("%i", &arr[i][j]);
	}
	funk(arr);
	system("pause");
    return 0;
}

