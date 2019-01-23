#include <iostream>
#include <math>
double fstart(double x)
{
	return(1-x+sin(x)-ln(1+x))
}
double ftransform(double x)
{ 
      return(1-sin(x)-ln(1+x));
}
double mpi(double a, double b, double eps, int max, double &ftransform, int &iter)
{
	double x = 0;
	iter = 0;
	double y = b;
	while (abs(y - x) > eps)
	{
		x = y;
		y = ftranform(x);
		iter++;
		if (iter > max)
			break;
	}

}
int main()
{
	int iter = 0;
    double a,b,eps,koren;
                  cin>>"Vvedite granizci promejutka,tochnost' priblijeniya, maksimal'noe kolichestvo iterazciy";
koren=mpi;
                  cout<<"Koren':"<<koren<< "kolichestvo iterazciy:"<<iter;
				  system("pause")
}
