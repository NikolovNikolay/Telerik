using System;
using System.Linq;

namespace _1.AbstractShapeClass
{
    public class Circle : Shape
    {
        public const double Pi = Math.PI;

        public Circle(double radius)
            : base(radius, radius)
        {
        }

        public override double CalculateSurface()
        {
            return (double)(Pi * this.height * this.width);
        }
    }
}
