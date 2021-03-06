#include "stdlib.h"
#include "stdio.h"
#include "cmath"
#include "stdafx.h"
#include "iomanip"

float iter2 = 0;

float ftransform2(float x)
{
	return(pow(2*(x,2)-x+3,1./3));
}

float mpi2(float a, float b, float eps, float max)
{
	float x = a;
	float y = b;
	while (abs(y - x) > eps)
	{
		x = y;
		y = ftransform2(x);
		iter2++;
		
		printf("a = %f\tb=%f\teps=%f\tmax=%f\titer=%f\ty=%f\n", a,b,eps,max, iter2,y);
		system("pause");
		if (iter2 > max)
			break;
	}
	return(x);
}
int main()
{
	float a, b, eps, koren1, koren2, max;
	
	float(*ftr2) (float);
	float z = 0;
	ftr2 = &ftransform2;
	printf("Vvedite granizci promejutka, tochnost' priblijeniya, maksimal'noe kolichestvo iterazciy \n");
	scanf("%f %f %f %f", &a, &b, &eps, &max);
	
	koren2 = mpi2(a, b, eps, max);
	if (iter2 > max)
	{
		printf("Kolichestvo iteraciy prevusilo zadannoe znachenie");

	}
	printf("Koren' dlya vtorogo uravnenia: %f\nKolichestvo iteraciy dlya vtorogo uravnenia: %f\n ", koren2, iter2);
	z = (pow(koren2, 3) - 2 * (koren2, 2) + koren2 - 3);
	printf("%f\n",z);
	system("pause");
}

