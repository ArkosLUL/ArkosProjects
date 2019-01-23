#include <iostream>
using namespace std;
int main(void)
{
double x,y;
y=0;
cout << "Vvedite x \n";
cin >> x;
if (x<0)
y=0;
else if (x<=2)
y=x*x+4*x+5;
else y=1/(x*x+4*x+5);
cout <<"y= " << y << endl;
return 0;
}

