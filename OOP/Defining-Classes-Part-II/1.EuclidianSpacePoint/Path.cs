using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidianSpacePoint
{
    public class Path
    {
        public readonly List<Point3D> SequenceOfPoints = new List<Point3D>();

        public void AddPointToSequnce(Point3D point)
        {
            this.SequenceOfPoints.Add(point);
        }

        public void ClearSequence()
        {
            this.SequenceOfPoints.Clear();
        }
    }
}
