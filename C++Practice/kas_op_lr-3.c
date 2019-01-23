#include <stdio.h>
#include <math.h>

int main(void)
{
float a[20],max,min,s, suka;
int n,k,i;
i=0;
min=0;
max=0;
printf("Vvedite n \n");
scanf("%i", &n);
printf("Vvedite massiv chisel \n");
for (i=0; i<n; i++)
{
scanf("%f", &a[i]);
}
for (i=0; i<n; i++)
{
printf("%f \n", a[i]);
}
while (max<a[i])
{
max=a[i];
i++;
}
suka=abs(a[1]+a[3]);
printf("suka= %f \n", suka);
printf("%f \t", max);
while (min>a[i])
{
min=a[i];
i++;
}
printf("%f \t", min);
s=abs(min+max);
printf("Summa 1= %f \n", s);
return 0;
}




