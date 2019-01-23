using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_lab2_kas
{
    class Point3D
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public static double phi = 0;
        public static int timercount = 0;

        public static List<Point3D> pointsDefault = FileData._3DPoints;
        public static List<Point3D> points = new List<Point3D>();
        public static List<Point3D> pointsToDraw = new List<Point3D>();
        //public static List<Point3D> PointMatrix2D = new List<Point3D>();

        public static void DeepCopy()
        {
            for (int i = 0; i < pointsDefault.Count; i++)
            {
                points.Add(new Point3D(pointsDefault[i].x, pointsDefault[i].y, pointsDefault[i].z));
            }
        }

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Point3D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static void From3DTo2D(double z0)
        {

            //int i = 0;
            int i = 0;
            foreach (var point in pointsToDraw)
            {
                pointsToDraw[i].x = point.x / (1 - point.z / z0);
                pointsToDraw[i].y = point.y / (1 - point.z / z0);

                i++;
                if (i == pointsToDraw.Count)
                {
                    break;
                }
            }

        }

        public static void AngleRotationX(double angle)
        {
            pointsToDraw.Clear();
            double angleInRadians = angle * Math.PI / 180;

            int i = 0;
            foreach (var point in points)
            {
                double x = point.x;
                double y = point.y * Math.Cos(angleInRadians) - point.z * Math.Sin(angleInRadians);
                double z = point.y * Math.Sin(angleInRadians) + point.z * Math.Cos(angleInRadians);
                pointsToDraw.Add(new Point3D(x, y, z));
                points[i].x = x;
                points[i].y = y;
                points[i].z = z;
                i++;
                if (i == points.Count)
                {
                    break;
                }
            }
        }

        public static void AngleRotationY(double angle)
        {
            pointsToDraw.Clear();
            double angleInRadians = angle * Math.PI / 180;

            int i = 0;
            foreach (var point in points)
            {
                double x = point.x * Math.Cos(angleInRadians) - point.z * Math.Sin(angleInRadians);
                double y = point.y;
                double z = point.x * Math.Sin(angleInRadians) + point.z * Math.Cos(angleInRadians);
                pointsToDraw.Add(new Point3D(x, y, z));
                points[i].x = x;
                points[i].y = y;
                points[i].z = z;
                i++;
                if (i == points.Count)
                {
                    break;
                }
            }
        }

        public static void AngleRotationZ(double angle)
        {
            pointsToDraw.Clear();
            double angleInRadians = angle * Math.PI / 180;

            int i = 0;
            foreach (var point in points)
            {
                double x = point.x * Math.Cos(angleInRadians) - point.y * Math.Sin(angleInRadians);
                double y = point.x * Math.Sin(angleInRadians) + point.y * Math.Cos(angleInRadians);
                double z = point.z;
                pointsToDraw.Add(new Point3D(x, y, z));
                points[i].x = x;
                points[i].y = y;
                points[i].z = z;
                i++;
                if (i == points.Count)
                {
                    break;
                }
            }
        }

        public static void XScaling(double scale)
        {
            pointsToDraw.Clear();

            int i = 0;
            foreach (var point in points)
            {
                double x = point.x * scale;
                double y = point.y;
                double z = point.z;
                pointsToDraw.Add(new Point3D(x, y, z));
                points[i].x = x;
                points[i].y = y;
                points[i].z = z;
                i++;
                if (i == points.Count)
                {
                    break;
                }
            }
        }

        public static void YScaling(double scale)
        {
            pointsToDraw.Clear();

            int i = 0;
            foreach (var point in points)
            {
                double x = point.x;
                double y = point.y * scale;
                double z = point.z;
                pointsToDraw.Add(new Point3D(x, y, z));
                points[i].x = x;
                points[i].y = y;
                points[i].z = z;
                i++;
                if (i == points.Count)
                {
                    break;
                }
            }
        }

        public static void ZScaling(double scale)
        {
            pointsToDraw.Clear();

            int i = 0;
            foreach (var point in points)
            {
                double x = point.x;
                double y = point.y;
                double z = point.z * scale;
                pointsToDraw.Add(new Point3D(x, y, z));
                points[i].x = x;
                points[i].y = y;
                points[i].z = z;
                i++;
                if (i == points.Count)
                {
                    break;
                }
            }
        }

        public static void OxReflection()
        {
            pointsToDraw.Clear();

            int i = 0;
            foreach (var point in points)
            {
                double x = point.x;
                double y = (-1) * point.y;
                double z = point.z;
                pointsToDraw.Add(new Point3D(x, y, z));
                points[i].x = x;
                points[i].y = y;
                points[i].z = z;
                i++;
                if (i == points.Count)
                {
                    break;
                }
            }
        }

        public static void OyReflection()
        {
            pointsToDraw.Clear();

            int i = 0;
            foreach (var point in points)
            {
                double x = (-1) * point.x;
                double y = point.y;
                double z = point.z;
                pointsToDraw.Add(new Point3D(x, y, z));
                points[i].x = x;
                points[i].y = y;
                points[i].z = z;
                i++;
                if (i == points.Count)
                {
                    break;
                }
            }
        }

        public static void OzReflection()
        {
            pointsToDraw.Clear();

            int i = 0;
            foreach (var point in points)
            {
                double x = point.x;
                double y = point.y;
                double z = (-1) * point.z;
                pointsToDraw.Add(new Point3D(x, y, z));
                points[i].x = x;
                points[i].y = y;
                points[i].z = z;
                i++;
                if (i == points.Count)
                {
                    break;
                }
            }
        }

        public static void OXTransposition(double transposition)
        {

            pointsToDraw.Clear();

            int i = 0;
            foreach (var point in points)
            {
                double x = point.x + transposition;
                double y = point.y;
                double z = point.z;
                pointsToDraw.Add(new Point3D(x, y, z));
                points[i].x = x;
                points[i].y = y;
                points[i].z = z;
                i++;
                if (i == points.Count)
                {
                    break;
                }
            }
        }

        public static void OYTransposition(double transposition)
        {

            pointsToDraw.Clear();

            int i = 0;
            foreach (var point in points)
            {
                double x = point.x;
                double y = point.y + transposition;
                double z = point.z;
                pointsToDraw.Add(new Point3D(x, y, z));
                points[i].x = x;
                points[i].y = y;
                points[i].z = z;
                i++;
                if (i == points.Count)
                {
                    break;
                }
            }
        }

        public static void OZTransposition(double transposition)
        {

            pointsToDraw.Clear();

            int i = 0;
            foreach (var point in points)
            {
                double x = point.x;
                double y = point.y;
                double z = point.z + transposition;
                pointsToDraw.Add(new Point3D(x, y, z));
                points[i].x = x;
                points[i].y = y;
                points[i].z = z;
                i++;
                if (i == points.Count)
                {
                    break;
                }
            }
        }

        public static void CurveMovement()
        {
            pointsToDraw.Clear();
            timercount++;
            float ForMotionX = (float)(Math.Sin(phi * Math.PI / 180));
            float ForMotionY = (float)(Math.Cos(phi * Math.PI / 180));
            for (int j = 0; j < points.Count;  j++)
            {
                points[j].x = points[j].x + ForMotionX;


                if (timercount < 100)
                {
                    points[j].y = points[j].y + (float)(ForMotionY * Math.Sin(phi * Math.PI / 180));
                }
                else points[j].y = points[j].y - (float)(ForMotionY * Math.Cos(phi * Math.PI / 180));


                pointsToDraw.Add(new Point3D(points[j].x, points[j].y, points[j].z));
            }
            if (timercount > 200)
                timercount = 0;
            phi += 1;
            if (phi == 720)
                phi = 0;

        }
    }
}
