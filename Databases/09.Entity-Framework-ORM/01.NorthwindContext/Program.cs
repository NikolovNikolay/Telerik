namespace NorthwindContext
{
    using System;
    using System.Linq;
    using _01.NorthwindContext;

    public class Program
    {
        public static void Main()
        {
            using (var db = new NorthwindEntities())
            {
                foreach (var item in db.Products)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
        }
    }
}
