using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndFigure
{
    
    class PointClass
    {
        private int xCoordinatePoint;
        private int yCoordinatePoint;
        private string pointName;

        public int XCoordinatePoint
        {
            get
            {
                return xCoordinatePoint;
            }
        }

        public int YCoordinatePoint
        {
            get
            {
                return yCoordinatePoint;
            }
        }

        public string PointName
        {
            get
            {
                return pointName;
            }
        }

        public PointClass(int xCoordinatePoint, int yCoordinatePoint, string pointName)
        {
            this.xCoordinatePoint = xCoordinatePoint;
            this.yCoordinatePoint = yCoordinatePoint;
            this.pointName = pointName;
        }
    }
}
