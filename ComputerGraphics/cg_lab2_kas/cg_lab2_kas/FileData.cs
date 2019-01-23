using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_lab2_kas
{
   static class FileData
    {
        public static List<Point3D> _3DPoints = new List<Point3D>();
        public static int[,] edgeMatrix;

        public static List<Point3D> DeepCopy()
        {
            List<Point3D> points = new List<Point3D>(_3DPoints.Count);
            for (int i = 0; i < points.Count; i++)
            { 

            
            
                points.Add(new Point3D(_3DPoints[i].x, _3DPoints[i].y, _3DPoints[i].z));
            }
            return points;
        }
    }
}
