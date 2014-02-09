namespace CategoryNameAndContainingProducts
{
    using System;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;

    public class CategoryNameAndContainingProducts
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
                SqlCommand command = new SqlCommand(@"SELECT p.ProductName, c.CategoryName 
                                                        FROM Products p 
                                                        JOIN Categories c 
                                                        ON p.CategoryID = c.CategoryID", conn);

                SqlDataReader reader = command.ExecuteReader();
                var result = new StringBuilder();

                using (reader)
                {
                    while (reader.Read())
                    {
                        result.AppendLine(string.Format((string)reader["ProductName"] + "   -->   " + (string)reader["CategoryName"]));
                    }

                }

                Console.WriteLine(result);
            }
        }
    }
}
