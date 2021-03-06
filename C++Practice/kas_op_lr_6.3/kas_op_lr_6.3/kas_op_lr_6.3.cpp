#include "stdlib.h"
#include "stdio.h"
#include "cmath"
#include "stdafx.h"
#include "iomanip"
using namespace std;

float ftransform1(float x)
{
	return(1 + sin(x) - log(1 + x));
}
float ftransform2(float x)
{
	return(pow(2 * pow(x, 2) - x + 3, 1. / 3));
}

float mpi(float a, float b, float eps, float max, float (*ftr)(float), int (&ptr))
{
	float x = a;
	float y = b;
	while (abs(y - x) > eps)
	{
		x = y;
		y = ftr(x);
		ptr++;

		
		if (ptr > max)
			break;
	}
	return(x);

}
int main()
{
	float a, b, eps, koren1, koren2;
	int max;
	int iter = 0;
	int *ptr= &iter;
	float(*ftr1)(float) = NULL;
	float z = 0;
	ftr1 = &ftransform1;
	
	printf("Vvedite granizci promejutka, tochnost' priblijeniya, maksimal'noe kolichestvo iterazciy \n");
	scanf("%f %f %f %f", &a, &b, &eps, &max);

	koren1 = mpi(a, b, eps, max,ftr1,iter);
	
	printf("Koren' dlya pervogo uravnenia: %f\nKolichestvo iteraciy dlya pervogo uravnenia: %i\n ", koren1, iter);
	z = (1 - koren1 + sin(koren1) - log(1 + koren1));
	printf("%f\n", z);
	printf("Vvedite granizci promejutka, tochnost' priblijeniya, maksimal'noe kolichestvo iterazciy \n");
	scanf("%f %f %f %f", &a, &b, &eps, &max);
	
	ftr1 = &ftransform2;
	koren2= mpi(a, b, eps, max, ftr1, iter);
	printf("Koren' dlya vtorogo uravnenia: %f\nKolichestvo iteraciy dlya vtorogo uravnenia: %i\n ", koren2, iter);
	z = (pow(koren2, 3) - 2 *pow (koren2, 2) + koren2 - 3);
	printf("%f\n", z);
	system("pause");
}

