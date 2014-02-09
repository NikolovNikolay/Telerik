namespace _03.SelectCustomersFrom1997
{
    using System;
    using System.Linq;
    using _01.NorthwindContext;

    public class Program
    {
        public static void Main()
        {
            using (var baseConn = new NorthwindEntities())
            {
                var customers = baseConn.Customers.Where(x => x.Orders.Where(o => o.OrderDate.Value.Year == 1997 && o.ShipCountry == "Canada").Any());

                foreach (var item in customers)
                {
                    Console.WriteLine(item.CustomerID);
                }
            }
        }
    }
}
