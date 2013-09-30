using System;
using System.Linq;

namespace _1.AbstractShapeClass
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
            :base(height,width)
        {

        }
        public override double CalculateSurface()
        {
            return (double)(this.Width * this.Height);
        }
    }
}
