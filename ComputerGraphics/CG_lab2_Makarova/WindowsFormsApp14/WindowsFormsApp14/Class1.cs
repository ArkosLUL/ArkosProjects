using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class Points
    {
        public float X { get; set; }

        public float Y { get; set; }

        public float Z { get; set; }

        public float X2d { get; set; }

        public float Y2d { get; set; }

        public Points(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.X2d = x / (1 - z / 200);
            this.Y2d = y / (1 - z / 200);
        }

        public Points()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
    }
}
