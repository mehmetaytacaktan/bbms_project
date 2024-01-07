using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMSAdminPanel
{
    public partial class CheckClient : Form
    {
        AdminPanel adminPanel = null;
        public CheckClient(AdminPanel adminPanel)
        {
            this.adminPanel = adminPanel;
            InitializeComponent();
            String[] userColumns = { "User ID", "First Name", "Last Name", "User Name", "Password", "E-Mail", "Phone Number" };
            foreach (String column in userColumns)
            {
                listview1.Columns.Add(column);
            }

            String connectionString = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=BUS_BOOK_MAN_SYS_;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            sql = "SELECT * FROM Users";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                cmbboxClientIDs.Items.Add(dataReader["Pass_Id"]);

                ListViewItem li = new ListViewItem(dataReader["Pass_Id"].ToString());
                li.SubItems.Add(dataReader["First_Name"].ToString());
                li.SubItems.Add(dataReader["Last_Name"].ToString());
                li.SubItems.Add(dataReader["Us_Name"].ToString());
                li.SubItems.Add(dataReader["Pass_Word"].ToString());
                li.SubItems.Add(dataReader["E_mail"].ToString());
                li.SubItems.Add(dataReader["Phone_Num"].ToString());

                listview1.Items.Add(li);
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            adminPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listview1.Items.Clear();
            String SelectedUserID = cmbboxClientIDs.SelectedItem.ToString();

            String connectionString1 = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=BUS_BOOK_MAN_SYS_;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn1 = new SqlConnection(connectionString1);

            cnn1.Open();
            SqlCommand command1;
            SqlDataReader dataReader1;
            String sql1;


            sql1 = "SELECT * FROM Users WHERE Pass_Id = '" + SelectedUserID + "'";
            command1 = new SqlCommand(sql1, cnn1);
            dataReader1 = command1.ExecuteReader();

            while (dataReader1.Read())
            {
                ListViewItem li = new ListViewItem(dataReader1["Pass_Id"].ToString());
                li.SubItems.Add(dataReader1["First_Name"].ToString());
                li.SubItems.Add(dataReader1["Last_Name"].ToString());
                li.SubItems.Add(dataReader1["Us_Name"].ToString());
                li.SubItems.Add(dataReader1["Pass_Word"].ToString());
                li.SubItems.Add(dataReader1["E_mail"].ToString());
                li.SubItems.Add(dataReader1["Phone_Num"].ToString());

                listview1.Items.Add(li);
            }
            dataReader1.Close();
            command1.Dispose();
            cnn1.Close();

            String connectionString2 = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=BUS_BOOK_MAN_SYS_;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn2 = new SqlConnection(connectionString2);

            cnn2.Open();
            SqlCommand command2;
            SqlDataReader dataReader2;
            String sql2;

            sql2 = "SELECT * FROM Users WHERE Pass_Id <> '" + SelectedUserID + "'";
            command2 = new SqlCommand(sql2, cnn2);
            dataReader2 = command2.ExecuteReader();
            while (dataReader2.Read())
            {
                ListViewItem li = new ListViewItem(dataReader2["Pass_Id"].ToString());
                li.SubItems.Add(dataReader2["First_Name"].ToString());
                li.SubItems.Add(dataReader2["Last_Name"].ToString());
                li.SubItems.Add(dataReader2["Us_Name"].ToString());
                li.SubItems.Add(dataReader2["Pass_Word"].ToString());
                li.SubItems.Add(dataReader2["E_mail"].ToString());
                li.SubItems.Add(dataReader2["Phone_Num"].ToString());

                listview1.Items.Add(li);
            }

            dataReader2.Close();
            command2.Dispose();
            cnn2.Close();
        }
    }
}