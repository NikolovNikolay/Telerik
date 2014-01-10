namespace RefactoreStatements
{
    using System;
    using System.Linq;
    using RefactoreStatements.Matrix;
    using RefactoreStatements.Potatoes;    

    public class Program
    {
        public static void Main()
        {
            Chef chefNiko = new Chef();
            chefNiko.Cook();

            BoundsValidator someTestMatrix = new BoundsValidator();
            someTestMatrix.GoToCell(1, 1, false);
        }
    }
}
