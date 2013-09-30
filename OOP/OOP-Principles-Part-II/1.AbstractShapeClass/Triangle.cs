using System;
using System.Linq;

namespace _1.AbstractShapeClass
{
    public class Triangle : Shape
    {
        public Triangle(double height, double width)
            : base(height, width)
        {
        }


        public override double CalculateSurface()
        {
            return (double)((this.Height * this.Width)/2);
        }
    }
}
