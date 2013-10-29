using System;
using System.Linq;

namespace _1.AbstractShapeClass
{
    public abstract class Shape
    {
        // fields of the abstract class
        protected double? width;
        protected double? height;

        // constructors
        public Shape()
            : this(null, null)
        {
        }

        public Shape(double? width, double? height)
        {
            this.width = width;
            this.height = height;
        }

        // properties
        public double? Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double? Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        
        public abstract double CalculateSurface();
    }
}
