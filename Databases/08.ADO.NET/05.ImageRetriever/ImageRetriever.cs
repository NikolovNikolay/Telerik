namespace ImageRetriever
{
    using System;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            SqlConnection connection = new SqlConnection(
                "Server=.\\; Database=Northwind; Integrated Security=true");

            connection.Open();

            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT CategoryName, Picture FROM Categories ", connection);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    byte[] picture = null;
                    string pictureName = null;

                    while (reader.Read())
                    {
                        picture = (byte[])reader["Picture"];
                        pictureName = (string)reader["CategoryName"] + ".jpg";

                        if (pictureName.IndexOf('/') >= 0 || pictureName.IndexOf('\\') >= 0)
                        {
                            pictureName = pictureName.Replace('/', '-');
                            pictureName = pictureName.Replace('\\', '-');
                        }

                        FileStream stream = new FileStream(pictureName, FileMode.Create);

                        using (stream)
                        {
                            stream.Write(picture, 78, picture.Length - 78);
                        }                        
                    } 
                }
            }
        }
    }
}
