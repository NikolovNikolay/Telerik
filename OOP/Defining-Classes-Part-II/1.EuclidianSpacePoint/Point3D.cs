using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidianSpacePoint
{
    public struct Point3D
    {
        private static readonly Point3D PointZero = new Point3D(0, 0, 0);

        public int coordX { get; set;}
        public int coordY { get; set; }
        public int coordZ { get; set; }

        public Point3D(int X, int Y, int Z) : this()
        {
            this.coordX = X;
            this.coordY = Y;
            this.coordZ = Z;
        }

        public static Point3D ZeroPoint
        {
            get { return PointZero; }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("..:: Euclidian Point Coordinates ::..");
            sb.AppendFormat("X coordinate = {0}; \n", this.coordX);
            sb.AppendFormat("Y coordinate = {0}; \n", this.coordY);
            sb.AppendFormat("Z coordinate = {0}; \n", this.coordZ);

            return sb.ToString();
        }
    }
}
