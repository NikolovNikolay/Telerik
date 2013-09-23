using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EuclidianSpacePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a new point and printing its coordinates
            Point3D pointOne = new Point3D(3, 4, 5);
            Point3D pointTwo = new Point3D(4, 7, 9);
            Console.WriteLine(pointOne.ToString());
            Console.WriteLine(pointTwo.ToString());

            // printing the static zero point's coordinates
            Console.WriteLine(Point3D.ZeroPoint.ToString());

            // Euclidian distance
            Console.WriteLine(DistanceBetweenPoints.GetDistanceBetweenPoints(pointOne, pointTwo));

            // creating new sequence of points; adding the created points to the sequence; saving the sequence to a file;
            // clearing  the sequence; reading the file and filling the initiated sequence again, after which printing their coordinates
            Path points = new Path();
            points.AddPointToSequnce(pointOne);
            points.AddPointToSequnce(pointTwo);
            points.AddPointToSequnce(Point3D.ZeroPoint);
            PathStorage.SavePathToFile(points);
            points.ClearSequence();

            points = PathStorage.LoadLastPathFromFile();
            foreach (var point in points.SequenceOfPoints)
            {
                Console.WriteLine(point.ToString());
            }
        }
    }
}
