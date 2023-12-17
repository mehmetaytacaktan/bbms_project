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
    public class DBMan
    {
        static string str = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        static public SqlConnection conn = new SqlConnection(str);
        static SqlCommand cmd = new SqlCommand("Select * FROM ");
        public static void OpenConnection()
        {
            conn.Open();
            MessageBox.Show("");
            conn.Close();
            

        }
        public static List<string> CloseConnection() 
        {
            List<string> list = new List<string>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr["City"].ToString());
            }

            return list;
        }

    }
}
