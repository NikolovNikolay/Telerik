namespace RefactorSizeClassTask
{
    using System;
    using System.Linq;

    public class Program
    {
        private static void Main(string[] args)
        {
        }

        public class Size
        {
            private double width;
            private double height;

            public Size(double inputWidth, double inputHeight)
            {
                this.Width = inputWidth;
                this.Height = inputHeight;
            }

            public double Width
            {
                get
                {
                    return this.width;
                }

                private set
                {
                    this.width = value;
                }
            }

            public double Height
            {
                get
                {
                    return this.height;
                }

                private set
                {
                    this.height = value;
                }
            }

            public static Size GetRotatedSize(Size sizeInstance, double angleOfTheFigureThatWillBeRotated)
            {
                double cosinusOfAngleThatWillBeRotated = Math.Cos(angleOfTheFigureThatWillBeRotated);
                double positiveValueOftheCosinus = Math.Abs(cosinusOfAngleThatWillBeRotated);

                double sinusOfTheAngleThatWillBeRotated = Math.Sin(angleOfTheFigureThatWillBeRotated);
                double positiveValueOftheSinus = Math.Abs(sinusOfTheAngleThatWillBeRotated);

                return new Size(
                                (positiveValueOftheSinus * sizeInstance.Height) + 
                                (positiveValueOftheCosinus * sizeInstance.Width),
                                (positiveValueOftheSinus * sizeInstance.Width) +
                                (positiveValueOftheCosinus * sizeInstance.Height));
            }
        }
    }
}
