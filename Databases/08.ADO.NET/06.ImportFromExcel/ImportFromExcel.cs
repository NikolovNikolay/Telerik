namespace ImportFromExcel
{
    using System;
    using System.Data.OleDb;
    using System.Linq;

    public class ImportFromExcel
    {
        public static void Main()
        {
            // in case you do not have Ace.OleDB 12 like i did ... download http://www.microsoft.com/en-us/download/details.aspx?id=23734. It should work
            // after installing it

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""../../sampleFile.xlsx"";Extended Properties=Excel 12.0;");

            connection.Open();
            OleDbCommand command = new OleDbCommand("Select Name, Score FROM  [Sheet1$]", connection);

            OleDbDataReader reader = command.ExecuteReader();

            using (connection)
            {
                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    double score = (double)reader["Score"];
                    Console.WriteLine("Name: {0} | Score: {1}", name, score);
                }
            }
        }
    }
}
