namespace _02.TableFunctionality
{
    using System;
    using System.Linq;

    public static class Operations
    {
        public static void AddCustomer(string id, string companyName, string contactName, string contactTitle, string address, string city,
            string region, string postalCode, string country, string phone, string fax)
        {
            using (var baseConn = new NorthwindEntities())
            {
                bool success = false;
                try
                {
                    Customer newCustomer = new Customer
                            {
                                CustomerID = id,
                                CompanyName = companyName,
                                ContactName = contactName,
                                ContactTitle = contactTitle,
                                Address = address,
                                City = city,
                                Region = region,
                                PostalCode = postalCode,
                                Country = country,
                                Phone = phone,
                                Fax = fax
                            };

                    if (baseConn.Customers.Find(newCustomer.CustomerID) == null && newCustomer.CustomerID != null)
                    {
                        baseConn.Customers.Add(newCustomer);
                        baseConn.SaveChanges();
                        success = true;
                    }
                }
                finally
                {
                    if (success)
                    {
                        Console.WriteLine("Custumer added");
                    }
                    else
                    {
                        Console.WriteLine("Custumer not added");
                    }
                }
            }
        }

        public static void RemoveCustomer(string id)
        {
            using (var baseConn = new NorthwindEntities())
            {
                bool success = false;

                try
                {
                    var element = baseConn.Customers.Find(id);
                    baseConn.Customers.Remove(element);
                    baseConn.SaveChanges();
                    success = true;
                }
                finally
                {
                    if (success)
                    {
                        Console.WriteLine("Custumer deleted");
                    }
                    else
                    {
                        Console.WriteLine("Custumer could not be deleted");
                    }
                }
            }
        }

        public static void EditCustumer(string id, string companyName, string contactName)
        {
            using (var baseConn = new NorthwindEntities())
            {
                bool successs = false;
                try
                {
                    Customer custumerToEdit = baseConn.Customers.Find(id);

                    custumerToEdit.CompanyName = companyName;
                    custumerToEdit.ContactName = contactName;

                    baseConn.SaveChanges();
                    successs = true;
                }
                finally
                {
                    if (successs)
                    {
                        Console.WriteLine("Custumer modified");
                    }
                    else
                    {
                        Console.WriteLine("Custumer could not be modified");
                    }
                }
            }
        }

        public static Customer GetCustomerByCriterion(string criterion, string searchValue)
        {
            Customer result = null;

            using (var baseConn = new NorthwindEntities())
            {
                foreach (var item in baseConn.Customers)
                {
                    var itemProp = item.GetType().GetProperty(criterion);
                    if (itemProp.GetValue(item, null).ToString() == searchValue)
                    {
                        result = item;
                        break;
                    }
                    
                } 
            }

            return result;
        }
    }
}
