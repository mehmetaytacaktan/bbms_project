using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }

        public void listVuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DB pull

            const string str = "Server=EVA01\\SQLEXPRESS;Database=asd;Trusted_Connection=True;";

            List<string> list = new List<string>();
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.[Users]", conn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            ListViewItem li = new ListViewItem(dr["Pass_Id"].ToString());
                            li.SubItems.Add(dr["First_Name"].ToString());
                            li.SubItems.Add(dr["Last_Name"].ToString());
                            li.SubItems.Add(dr["Us_Name"].ToString());
                            li.SubItems.Add(dr["Phone_Num"].ToString());
                            li.SubItems.Add(dr["E_mail"].ToString());

                        }
                    }
                }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
