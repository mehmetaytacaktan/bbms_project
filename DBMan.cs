using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.[Cities]", conn))
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
        /*  public static List<string> UserPnlli()
        {
            List <string> list = new List<string>();
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.[Users]", conn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        
                    }
                }
            }

            return list;
        } */
        

        
    }
}
