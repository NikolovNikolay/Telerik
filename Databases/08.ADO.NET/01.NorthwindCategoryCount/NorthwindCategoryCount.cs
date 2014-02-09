namespace NorthwindCategoryCount
{
    using System;
    using System.Data.SqlClient;
    using System.Linq;

    public class NorthwindCategoryCount
    {
        public static void Main()
        {
            SqlConnection conn = new SqlConnection(
                "Server= .\\; " +
                "Database=Northwind; " +
                "Integrated Security=true");

            conn.Open();
            using (conn)
            {
                SqlCommand command = new SqlCommand("Select count(*) from Categories", conn);

                int numberOfCategories = (int)command.ExecuteScalar();
                Console.WriteLine(numberOfCategories);
            }
        }
    }
}
