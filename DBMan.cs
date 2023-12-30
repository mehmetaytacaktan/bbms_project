using System.Collections.Generic;
using System.Data.SqlClient;

namespace formProject
{
    //Data Base Manager **********************************************************************
    public class DBMan
    {
        // Define the connection string as a constant
        const string str = "Server=EVA01\\SQLEXPRESS;Database=asd;Trusted_Connection=True;";

        public static List<string> ReadCities()
        {
            List<string> list = new List<string>();
            // Create a local connection object using the connection string
            using (SqlConnection conn = new SqlConnection(str))
            {
                // Open the connection
                conn.Open();
                // Create a command object using the connection and the query
                using (SqlCommand cmd = new SqlCommand("Select * FROM Cities", conn))
                {
                    // Execute the reader using the command object
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Add both the city and the country elements to the list
                            list.Add(dr["City"].ToString() + ", " + dr["Country"].ToString());
                        }
                    }
                }
                // Close the connection
                conn.Close();
            }

            return list;
        }
    }
}