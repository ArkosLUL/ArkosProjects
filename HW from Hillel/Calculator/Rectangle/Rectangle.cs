using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }

        public double Side1
        {
            get
            {
                return side1;
            }
        }

        public double Side2
        {
            get
            {
                return side2;
            }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return Side1 * Side2;
        }

        public double PerimeterCalculator()
        {
            return (2 * Side1 + 2 * Side2);
        }

        public void Show()
        {
            Console.WriteLine("Area of rectangle = " + Area);
            Console.WriteLine("Perimeter of rectangle = " + Perimeter);
        }

    }
}
