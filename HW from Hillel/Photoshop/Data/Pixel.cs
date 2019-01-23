using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Data
{
    public class Pixel
    {
        private double r;
        private double g;
        private double b;

        public double R { get { return r; } set { r = Check(value); } }
        public double G { get { return g; } set { g = Check(value); } }
        public double B { get { return b; } set { b = Check(value); } }

        private double Check(double value)
        {
            if (value >= 0 || value <= 1)
                return value;
            throw new ArgumentOutOfRangeException(string.Format($"Wrong channel value {value} (the value must be between 0 and 1"));
        }

        public static double Trim(double value)
        {
            if (value > 1)
                return 1;
            if (value < 0)
                return 0;
            return value;
        }

        public static int ToChannel(double val)
        {
            if (val < 0 || val > 1)
                throw new Exception(string.Format("Wrong channel value {0} (the value must be between 0 and 1", val));
            return (int)(val * 255);
        }
    }
}
