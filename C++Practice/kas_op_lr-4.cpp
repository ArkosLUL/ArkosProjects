#include <stdio.h>
#include <math.h>

int main(void)
{
	int a[20][20],i,j,m,n,s,i0,j0;
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
				s=s+abs(a[i][j]);

			}
		if(s==0)
			{
				i0=i;
				for(i=i0;i<n;i++)
				                 for(j=0;j<m;j++)
				                                 a[i][j]=a[i+1][j];
                                n--;
                                s=0;
				goto flag;
			}
                s=0;
		}
       s=0;
flag1:
	for(j=0;j<m;j++)
		{
		for(i=0;i<n;i++)
			{
				s=s+abs(a[i][j]);

			}
		if(s==0)
			{
				j0=j;
				for(j=j0;j<m;j++)
				                 for(i=0;i<n;i++)
				                                 a[i][j]=a[i][j+1];
                                m--;
                                s=0;
				goto flag1;
			}
                s=0;
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
