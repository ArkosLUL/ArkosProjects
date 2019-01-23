#include <stdio.h>
#include <math.h>


int main(void)
{
 float b,a1,a2;
 int i;

 printf("Vvedite b \n");
 scanf("%f", &b);
 i=2;
 a2=0;
 if (b>0)
    {
    a1=b;
    printf("a(i-1)\t\t a(i)\t\t i\n");
    while(a2>=0)
      {
      a2=a1-(1/pow(i,0.5));
      printf("%f\t %f\t %i \n", a1, a2, i);
      a1=a2;
      i++;
      }
    printf("\n i= %i a2= %f\n", i, a2);
    }
else
    printf("Otricatel'noe chislo \n");
return 0;
}
