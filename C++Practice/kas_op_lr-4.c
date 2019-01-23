#include <stdio.h>
#include <math.h>

int main(void)
{
	int a[20][20],i,j,m,n,s,i0,j0;
	i0=0;
	j0=0;
	i=0;
	j=0;
	printf("Vvedite razmernost' matrici\n");
	scanf("%i%i\n", &n,m);
	printf("Vvedite matricu\n");	
	for(i=0;i<n;i++)
		for(j=0;j<m;j++)
			scanf("%i", &a[i][j]);
flag;
	for(i=0;i<m;i++)
		{
		for(j=0;j<n;j++)
			{
				s=s+a[i][j];
				j++;
			}
		if(s==0)
			{
				i=i0;
				for(i=i0;i<m;i++)
				for(j=0;j<n;j++)
				a[i][j]=a[i+1][j];
				go to flag;
			}
		}
	for(i=0;i<n;i++)
		for(j=0;j<m;j++)		
			printf("%i", a[i][j]);
	return 0;
}
