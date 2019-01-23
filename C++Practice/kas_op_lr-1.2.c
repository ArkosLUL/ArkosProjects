#include <stdio.h>

int main(void)
{
float x,y,u;
u=0;
printf("Vvedite x \n");
scanf("%f", & x);
printf("Vvedite y \n");
scanf("%f", & y);
if  ((x*x+y*y<=4) &&  (y>0) && (y*y+x*x>=1))
{
u=0;
printf ("Tochka prinadlezhit D \n");
}
else 
{
u=x;
printf ("Tochka ne prinadlezhit D \n");

}
printf("u= %f \n", u);
return 0;
}
