namespace _02.TableFunctionality
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            Operations.AddCustomer("WOWO", "tra la la ", "pesho", "tupoto", "ul. 101 voivodi N106", "Sliven", "North Bulgaria", "5800", "BG", "+359888", "+359899");
            
            Operations.EditCustumer("WOWO", "La la la", "Gosho");            

            var cust = Operations.GetCustomerByCriterion("CustomerID", "WOLZA");

            Console.WriteLine(cust.CompanyName);

            Operations.RemoveCustomer("WOWO");
        }
    }
}
