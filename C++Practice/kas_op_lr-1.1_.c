#include <stdio.h>

int main(void)
{
float x,y;
y=0;
printf("Vvedite znachenie x \n");
scanf("%f", & x);
if (x<0)
y=0;
else if (x<=2)
y=x*x+4*x+5;
else y=1/(x*x+4*x+5);
printf("Result y=%f \n",y);
return 0;
}

