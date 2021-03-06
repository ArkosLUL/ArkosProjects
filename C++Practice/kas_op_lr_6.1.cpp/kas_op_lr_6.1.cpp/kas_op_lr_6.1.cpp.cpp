#include "stdlib.h"
#include "stdio.h"
#include "cmath"
#include "stdafx.h"
#include "iomanip"
float iter1 = 0;
float iter2 = 0;
float ftransform1(float x)
{
	return(1 + sin(x) - log(1 + x));
}
float ftransform2(float x)
{
	return(x*x*x + 2 * x*x + 2*x - 3);
}
float mpi1(float a, float b, float eps, float max, float ftr1(float))
{
	float x = 0;
	float y = b;
	while (abs(y - x) > eps)
	{
		x = y;
		y = ftr1(x);
		iter1++;
		if (iter1 > max)
			break;
	}
	return(x);
}
float mpi2(float a, float b, float eps, float max)
{
	float x = 0;
	float y = b;
	while (abs(y - x) > eps)
	{
		x = y;
		y = ftransform2(x);
		iter2++;
	}
	return(x);
}
int main()
{
	float a, b, eps, koren1, koren2, max;
	float (*ftr1) (float);
	float (*ftr2) (float);
	ftr1 = &ftransform1;
	ftr2 = &ftransform2;
	printf("Vvedite granizci promejutka, tochnost' priblijeniya, maksimal'noe kolichestvo iterazciy \n");
scanf("%f %f %f %f", &a, &b, &eps, &max);
	koren1 = mpi1(a, b, eps, max, ftr1);
	if (iter1 > max)
	{
		printf("Kolichestvo iteraciy prevusilo zadannoe znachenie");
	}
	koren2 = mpi2(a, b, eps, max);
	if (iter2 > max)
	{
		printf("Kolichestvo iteraciy prevusilo zadannoe znachenie");

	}
	printf("Koren' dlya pervogo uravnenia: %f\nKoren' dlya vtorogo uravnenia: %f\nKolichestvo iteraciy dlya pervogo uravnenia: %f\nKolichestvo iteraciy dlya vtorogo uravnenia: %f\n ", koren1, koren2, iter1,iter2);
	system("pause");
}
