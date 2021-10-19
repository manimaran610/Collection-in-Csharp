using System;
using System.Data.SqlClient;
namespace TestApp
{
    public class SQLMainPage
    {
        public static void HomePage()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Do work here.  

            }
        }
    }

}
