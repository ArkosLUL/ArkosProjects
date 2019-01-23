using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_lab2_kas
{
    class Triangle
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public SolidBrush Col { get; set; }
        public float Z { get; set; }
        public Triangle(int a, int b, int c, string col)
        {
            A = a;
            B = b;
            C = c;
            switch (col)
            {
                case "green":
                    Col = new SolidBrush(Color.Green);
                    break;
                case "red":
                    Col = new SolidBrush(Color.Red);
                    break;
                case "blue":
                    Col = new SolidBrush(Color.Blue);
                    break;
                case "gray":
                    Col = new SolidBrush(Color.Gray);
                    break;
                case "yellow":
                    Col = new SolidBrush(Color.Yellow);
                    break;
                case "orange":
                    Col = new SolidBrush(Color.Orange);
                    break;
                case "brown":
                    Col = new SolidBrush(Color.Brown);
                    break;
                case "black":
                    Col = new SolidBrush(Color.Black);
                    break;
                case "purple":
                    Col = new SolidBrush(Color.Purple);
                    break;
                default:
                    throw new ArgumentException("Некорректный цвет");
            }
        }
    }
}
