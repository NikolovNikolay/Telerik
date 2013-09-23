using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidianSpacePoint
{
    public static class DistanceBetweenPoints
    {
        public static double GetDistanceBetweenPoints(Point3D first, Point3D second)
        {
            double distance = 0;
            distance = Math.Sqrt(((first.coordX - second.coordX) * (first.coordX - second.coordX)) +
                                    ((first.coordY - second.coordY) * (first.coordY - second.coordY)) +
                                    ((first.coordZ - second.coordZ) * (first.coordZ - second.coordZ)));

            return distance;
        }
    }
}
