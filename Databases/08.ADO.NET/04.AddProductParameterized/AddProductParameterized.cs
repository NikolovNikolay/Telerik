namespace AddProductParameterized
{
    using System;
    using System.Data.SqlClient;
    using System.Linq;

    public class AddProductParameterized
    {
        public static void Main()
        {
            SqlConnection conn = new SqlConnection(
                "Server=.\\; " +
                "Database=Northwind; " +
                "Integrated Security=true");

            conn.Open();
            using (conn)
            {
                SqlCommand command = new SqlCommand(@"INSERT INTO Products
                                                      (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,
                                                        UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued)
                                                        VALUES(@name, @supplier, @category, @quantity, @price,@inStock,@onOrder,
                                                            @reorderLevel, @discontinued)", conn);

                command.Parameters.AddWithValue("@name", "Dimitrovgradski susheni slivi");
                command.Parameters.AddWithValue("@supplier", 1);
                command.Parameters.AddWithValue("@category", 7);
                command.Parameters.AddWithValue("@quantity", "1 kg pkg.");
                command.Parameters.AddWithValue("@price", 5m);
                command.Parameters.AddWithValue("@inStock", 100);
                command.Parameters.AddWithValue("@onOrder", 1);
                command.Parameters.AddWithValue("@reorderLevel", 10);
                command.Parameters.AddWithValue("@discontinued", 1);
                command.ExecuteNonQuery();
            }

            Console.WriteLine("ready");
        }        
    }
}
