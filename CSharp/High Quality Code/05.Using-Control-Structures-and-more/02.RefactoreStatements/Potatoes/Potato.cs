namespace RefactoreStatements.Potatoes
{
    using System;
    using System.Linq;

    public class Potato
    {
        public Potato()
        {
            this.HasNotBeenPeeled = true;
            this.IsRotten = false;
            this.IsCooked = false;
        }

        public bool HasNotBeenPeeled { get; set; }

        public bool IsRotten { get; set; }

        public bool IsCooked { get; set; }
    }
}
