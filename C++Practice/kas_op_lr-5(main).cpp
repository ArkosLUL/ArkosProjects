#include <stdio.h>

int main()
{
	float v1[30], v2[30], v3[30], a[3]; 
	float min_v1=0;
	float min_v2=0;
	float min_v3=0;	
	float min=0;
	int i,n,m,z,k;
	k=0;
	scanf("%i%i%i", &n,&m,&z);
	for(i=0; i<n; i++)
		{
			scanf("%f", &v1[i]);
			if(v1[i]<min_v1)
				min_v1=v1[i];
		}
	a[0]=min_v1;
	for(i=0; i<m; i++)
		{
			scanf("%f", &v2[i]);
			if(v2[i]<min_v2)
				min_v2=v2[i];
		}
	a[1]=min_v2;
	for(i=0; i<z; i++)
			{
				scanf("%f", &v3[i]);
				if(v3[i]<min_v3)
					min_v3=v3[i];
			}
	a[2]=min_v3;
	for(i=0;i<3;i++)	
		{
			if(a[i]<=min)
				min=a[i];
				k++;
		}
	printf("Resul'tat: \t");
	for(i=0;i<k;i++)
		printf("%f\t", a[i]);
}
