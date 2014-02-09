namespace NameDescriptionOfCategories
{
    using System;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;

    public class NameDescriptionOfCategories
    {
        public static void Main()
        {
            SqlConnection conn = new SqlConnection(
                "Server =.\\; " +
                "Database=Northwind; " +
                "Integrated Security=true");

            conn.Open();
            using (conn)
            {
                SqlCommand retrieveNameDescription = new SqlCommand("Select CategoryName, Description from Categories", conn);

                SqlDataReader reader = retrieveNameDescription.ExecuteReader();
                var result = new StringBuilder();

                using (reader)
                {
                    while (reader.Read())
                    {
                        result.AppendLine(string.Format((string)reader["CategoryName"] + " --> " + (string)reader["Description"]));
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
