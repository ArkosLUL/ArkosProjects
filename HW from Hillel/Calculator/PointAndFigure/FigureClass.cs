using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//    Класс Point должен содержать два целочисленных поля и одно строковое поле.
//Создать три свойства с одним методом доступа get.
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
//аргументов.Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
//аргументов типа Point.
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
//стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
//многоугольника.
//Написать программу, которая выводит на экран название и периметр многоугольника.
namespace PointAndFigure
{
    class FigureClass
    {
        private PointClass a;
        private PointClass b;
        private PointClass c;
        private PointClass d;
        private PointClass e;
        private PointClass[] points;

        public PointClass A
        {
            get
            {
                return a;
            }
        }

        public PointClass B
        {
            get
            {
                return b;
            }
        }

        internal PointClass C
        {
            get
            {
                return c;
            }
        }

        internal PointClass D
        {
            get
            {
                return d;
            }
        }

        internal PointClass E
        {
            get
            {
                return e;
            }
        }

        internal PointClass[] Points
        {
            get
            {
                return points;
            }
        }

        public FigureClass(PointClass a, PointClass b, PointClass c, PointClass d = null, PointClass e = null)
        {
            Initalizer(a, b, c, d, e);
        }

        private void Initalizer(PointClass a, PointClass b, PointClass c, PointClass d, PointClass e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (d != null)
            {
                this.d = d;
            }
            if (e != null)
            {
                this.e = e;
            }
        }

        //private void Initalizer(PointClass a, PointClass b, PointClass c, PointClass d)
        //{
        //    this.a = a;
        //    this.b = b;
        //    this.c = c;
        //    this.d = d;
        //}

        //private void Initalizer(PointClass a, PointClass b, PointClass c, PointClass d, PointClass e)
        //{
        //    this.a = a;
        //    this.b = b;
        //    this.c = c;
        //    this.d = d;
        //    this.e = e;
        //}

        public double GetLenghtSide(PointClass a, PointClass b)
        {
            return Math.Sqrt(Math.Pow((b.XCoordinatePoint - a.XCoordinatePoint), 2) + Math.Pow((b.YCoordinatePoint - a.YCoordinatePoint), 2));
        }

        public double GetPerimeter()
        {
            int n;
            double perimeter = 0;
            if (GetPolygonType(out n).Contains("triangle") == true)
            {
                points = new PointClass[] { A, B, C };
            }
            else if (GetPolygonType(out n).Contains("quadrangle") == true)
            {
                points = new PointClass[] { A, B, C, D };
            }
            else if (GetPolygonType(out n).Contains("pentagon") == true)
            {
                points = new PointClass[] { A, B, C, D, E };
            }

            for (int i = 1; i < Points.Length; i++)
            {
                perimeter += GetLenghtSide(Points[i - 1], Points[i]);
            }
            perimeter += GetLenghtSide(Points[0], Points[Points.Length - 1]);
            return perimeter;
        }

        public string GetPolygonType(out int n)
        {
            if (d == null)
            {
                n = 2;
                return "It's a triangle";
            }
            else if (e == null)
            {
                n = 3;
                return "It's a quadrangle";
            }
            else
            {
                n = 4;
                return "It's a pentagon";
            }
        }

        public void Show()
        {
            int n;
            
            Console.Write("Polygon type: " + GetPolygonType(out n) + " perimeter = " + GetPerimeter());
            Console.Write(" polygon name: ");
            for (int i = 0; i < Points.Length; i++)
            {
                Console.Write(Points[i].PointName);
            }
            Console.WriteLine();
        }
    }
}
