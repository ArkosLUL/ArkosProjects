#include <stdio.h>

int main()
{
	float v1[30], v2[30], v3[30], a[3]; 
	float min_v1;
	float min_v2;
	float min_v3;
	float min;
	int i,n,m,z,k;
	k=0;
        printf("Vvedite razmernost' v1:\n");
	scanf("%i", &n);
        printf("Vvedite koordinati v1:\n");
	for(i=0; i<n; i++)
		{
			scanf("%f", &v1[i]);
                        min_v1=v1[0];
			if(v1[i]<min_v1)
				min_v1=v1[i];
		}
	a[0]=min_v1;
        printf("Vvedite razmernost' v2:\n");
	scanf("%i", &m);
        printf("Vvedite koordinati v2:\n");
	for(i=0; i<m; i++)
		{
			scanf("%f", &v2[i]);
                        min_v2=v2[0];
			if(v2[i]<min_v2)
				min_v2=v2[i];
		}
	a[1]=min_v2;
        printf("Vvedite razmernost' v3:\n");
	scanf("%i", &z);
        printf("Vvedite koordinati v3:\n");
	for(i=0; i<z; i++)
	         {
		      scanf("%f", &v3[i]);
                      min_v2=v2[0];
		      if(v3[i]<min_v3)
		                      min_v3=v3[i];
		 }
	a[2]=min_v3;
        for(i=0;i<3;i++)
        printf("%f\t", a[i]);
        printf("\n\n");
	for(i=0;i<3;i++)	
		{
			if(a[i]<=min)
                                     {
				                   min=a[i];
				                   k++;
                                     }
                        a[i]=min;
                }
	printf("Resul'tat: \n");
	for(i=0;i<k-1;i++)
		printf("\t\t%f\n", a[i]);
}
