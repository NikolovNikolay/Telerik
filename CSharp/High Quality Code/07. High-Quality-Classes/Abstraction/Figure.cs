namespace Abstraction
{
    using System;

    public abstract class Figure
    {
        public string Type { get; set; }

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();

        public override string ToString()
        {
            string resultToOutput = string.Format(
                "I am a {0}. My perimeter is {1:f2}. My surface is {2:f2}.",
                this.Type,
                this.CalcPerimeter(),
                this.CalcSurface());

            return resultToOutput;
        }
    }
}
