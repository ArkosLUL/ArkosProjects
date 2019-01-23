#include <stdio.h>
float func1(int n, float* v)
{
          float min=v[0];
          int i;
          for(i=0;i<n;i++)
                          {
                                if(v[i]<min)
                                            min=v[i];
                          }
          return min;
}

int main()
{
	float v1[30], v2[30], v3[30], a[3];
        float min;
	int i,n,m,z,j,c;
        c=0;
        printf("Vvedite razmernost' v1:\n");
	scanf("%i", &n);
        printf("Vvedite koordinati v1:\n");
        for(i=0;i<n;i++)
                        {
                                   scanf("%f", &v1[i]);
                        }
        a[0]=func1(n, v1);
        printf("Vvedite razmernost' v2:\n");
	scanf("%i", &m);
        printf("Vvedite koordinati v2:\n");
	for(i=0; i<m; i++)
		{
			scanf("%f", &v2[i]);
		}
        a[1]=func1(m, v2);
        printf("Vvedite razmernost' v3:\n");
	scanf("%i", &z);
        printf("Vvedite koordinati v3:\n");
	for(i=0; i<z; i++)
	         {
		      scanf("%f", &v3[i]);
		 }
        a[2]=func1(z, v3);
        printf("\n\nMinimal'naya koordinata kajdogo vektora:\n");
        for(i=0;i<3;i++)
                        printf("\t\t\t\t\t%f\t\n", a[i]);
        min=func1(3, a);
        for(i=0;i<3;i++)
                        {
                                         c=i;
                                       if(a[i]==min)
                                                    {

                                                               printf("v%i= ",c+1);
                                                                            printf("\t%f\n", a[i]);

                                                    }
                        }
}

