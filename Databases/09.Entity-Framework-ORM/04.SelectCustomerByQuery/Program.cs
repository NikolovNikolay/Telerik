namespace _04.SelectCustomerByQuery
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
                var customers = baseConn.Database.SqlQuery<string>(@"SELECT DISTINCT c.CustomerID 
                                                                     FROM Customers c JOIN Orders o 
                                                                     ON c.CustomerID = o.CustomerID 
                                                                     WHERE o.ShipCountry ='Canada' AND o.OrderDate like '%1997%'");

                foreach (var item in customers)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
