namespace _05.OrdersByRegionAndPeriod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _01.NorthwindContext;

    public class Program
    {
        public static void Main()
        {
            var query = SelectOrdersByRegionAndDate("NM", new DateTime(1996, 01, 01), new DateTime(1997, 01, 01));
            foreach (var res in query)
            {
                Console.WriteLine(res);
            }
        }

        private static ICollection<string> SelectOrdersByRegionAndDate(string region, DateTime start, DateTime end)
        {
            using (var baseConn = new NorthwindEntities())
            {
                var result = baseConn.Orders.Where(
                                                x => x.ShipRegion == region && x.OrderDate >= start && x.OrderDate <= end).Select(
                                                c => c.Customer.CompanyName + " " + c.ShipAddress + " " + c.ShipCountry).ToList();


                return result;
            }
        }
    }
}
