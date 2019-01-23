#include <stdio.h>
#include <math.h>

int main(void)
{
	int a[20][20],i,j,m,n,s,i0,j0,fff,fff1;
	fff=-1;
	fff1=-1;
        s=0;
	i0=0;
	j0=0;
	i=0;
	j=0;
        printf("Vvedite razmernost' matrici\n");
        scanf("%i%i", &n,&m);
	printf("\nVvedite matricu\n");	
	for(i=0;i<n;i++)
		for(j=0;j<m;j++)
                {
                                printf("a[%i][%i]= ", i,j);
			scanf("%i", &a[i][j]);
                }
        printf("Ishodnaya matrica %ix%i:\n", n,m);
        for(i=0;i<n;i++)
        {
		for(j=0;j<m;j++)
                                printf("%i\t", a[i][j]);
        printf("\n");
        }
flag:
	for(i=0;i<n;i++)
		{
		for(j=0;j<m;j++)
			{
                                fff=-1;
				if(a[i][j]==0)
					fff=0;
				if(fff==-1)
					break;
			}
		if(fff==0)
			{
				i0=i;
				for(i=i0;i<n;i++)
				                 for(j=0;j<m;j++)
				                                a[i][j]=a[i+1][j];
                                n--;
				goto flag;
			}
		}
flag1:
	for(j=0;j<m;j++)
		{
		for(i=0;i<n;i++)
			{
                                fff1=-1;
				if(a[i][j]==0)
					fff1=0;
				if(fff1==-1)
					break;
			}
		if(fff1==0)
			{
				j0=j;
				for(j=j0;j<m;j++)
				                 for(i=0;i<n;i++)
				                                 a[i][j]=a[i][j+1];
                                m--;
				goto flag1;
			}
		}
        printf("1. Resul'tiruyushaya matrica [%i]x[%i]: \n", n,m);
	for(i=0;i<n;i++)
        {
		for(j=0;j<m;j++)		
			printf("%i\t", a[i][j]);
                        printf("\n");
        }
        printf("\n\n");
        printf("2. Nomer stroki s polozytel'numi elementami: ");
        for(i=0;i<n;i++)
        {
		for(j=0;j<m;j++)
                                if(a[i][j]>0)
                                {
                                printf("%i \n", i);
                                goto flag2;
                                }
        }
flag2:
	return 0;
}
