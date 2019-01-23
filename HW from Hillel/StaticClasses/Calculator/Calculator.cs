using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class Calculator
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Subtraction(double a, double b)
        {
            if (a > b)
                return a - b;
            else
                return b - a;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            if (a > b)
                return a / b;
            else
                return b / a;
        }

        public static double Pow(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
