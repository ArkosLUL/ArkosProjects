using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureClass figure = new FigureClass(new PointClass(1, 0, "A"), new PointClass(2, 2, "B"), new PointClass(3, 0, "C"));
            figure.Show();
            Console.ReadKey();
        }
    }
}
