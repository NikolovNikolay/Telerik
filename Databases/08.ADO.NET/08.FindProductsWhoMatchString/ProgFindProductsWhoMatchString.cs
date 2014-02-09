namespace FindProductsWhoMatchString
{
    using System;
    using System.Data.SqlClient;
    using System.Linq;

    public class ProgFindProductsWhoMatchString
    {
        public static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(
                "Server=.\\; Database=Northwind; Integrated Security=true");

            connection.Open();

            using (connection)
            {
                Console.Write("Input string to search: ");
                string searchString = Console.ReadLine();
                
                searchString = searchString.Replace("%", " ").Replace("\\", " ").Replace("_", " ").Replace("'", " ").Replace("\"", " ").Trim();
                string sqlComm = string.Format("Select ProductName from Products where ProductName like '%" + searchString + "%'");

                SqlCommand command = new SqlCommand(sqlComm,connection);
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("_____ R E S U L T S _____");
                while (reader.Read())
                {
                    Console.WriteLine((string)reader["ProductName"]);

                }
            }
        }
    }
}
