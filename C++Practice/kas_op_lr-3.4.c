#include <stdio.h>
#include <math.h>

int main(void)
{
	float a[20],max1,max,min,s1,s2,b[20];
	int n,i,t,c,j;
	i=0;
	s1=0;
	s2=0;
	t=-1;
	c=0;
	printf("Vvedite n \n");
	scanf("%i", &n);
	printf("Vvedite massiv chisel \n");
	for (i=0; i<n; i++)
	{
		scanf("%f", &a[i]);
	}
	printf("Massiv: \n");
	for (i=0; i<n; i++)
	{
		printf("%f \n", a[i]);
	}
	printf("\n\n");
	min=a[0];
	max=a[0];
	max1=a[0];
	for (i=0; i<n;i++)
	{
		if(abs(a[i])>max)
		{
			max=a[i];
			
		}
	}
	for (i=0; i<n;i++)
	{
		if(a[i]>max)
		{
			max1=a[i];
			c=i;
		}
	}
	printf("1.\n \tmax = %f \t\n", max);
	for (i=0; i<n;i++)
	{
		if(abs(a[i])<min)
		{
			min=a[i];
		}
	}
	printf("\tmin = %f \t\n", min);
	s1=min+max;
	printf("\tSumma 1 = %f \n", s1);
	printf("\n\n");
	for (i=0; i<n;i++)
	{
		if(a[i]==0)
		{
			t = i;
			break;
		}
		
	}
	if(t!=-1)
	for (i =t;i < n;i++)
	{
		s2=abs(s2)+abs(a[i]);
	}
	else 
		{
			printf("2.\n \tSumma 2 = Not possible \n");

		}
	if(t!=-1)
	printf("2.\n \tSumma 2 = %f \n", s2);
	j=0;
	for(i=c+1; i<n; i++)
	{
		b[j]=a[i];
		j++;
	}
	for(i=c;i>=0;i--)
	{
		a[j+i]=a[i];
	}
	for(i=0;i<j;i++)
	{
		a[i]=b[i];
	}
	printf("\n \n");	
	printf("3.\n \tPreobrazovanniy massiv:\n");
	for(i=0; i<n-1; i++)
		printf("\t\t\t\ta[%i]= %f\n", i,a[i]);
	return 0;
}




