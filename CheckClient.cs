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
            String[] userColumns = { "user_id", "first_name", "last_name", "username", "password", "email", "phone_number" };
            foreach (String column in userColumns)
            {
                listview1.Columns.Add(column);
            }

            String connectionString = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=busticketdb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            sql = "SELECT * FROM [User]";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                cmbboxClientIDs.Items.Add(dataReader["user_id"]);

                ListViewItem li = new ListViewItem(dataReader["user_id"].ToString());
                li.SubItems.Add(dataReader["first_name"].ToString());
                li.SubItems.Add(dataReader["last_name"].ToString());
                li.SubItems.Add(dataReader["username"].ToString());
                li.SubItems.Add(dataReader["password"].ToString());
                li.SubItems.Add(dataReader["email"].ToString());
                li.SubItems.Add(dataReader["phone_number"].ToString());

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

            String connectionString1 = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=busticketdb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn1 = new SqlConnection(connectionString1);

            cnn1.Open();
            SqlCommand command1;
            SqlDataReader dataReader1;
            String sql1;


            sql1 = "SELECT * FROM [User] WHERE user_id = '" + SelectedUserID + "'";
            command1 = new SqlCommand(sql1, cnn1);
            dataReader1 = command1.ExecuteReader();

            while (dataReader1.Read())
            {
                ListViewItem li = new ListViewItem(dataReader1["user_id"].ToString());
                li.SubItems.Add(dataReader1["first_name"].ToString());
                li.SubItems.Add(dataReader1["last_name"].ToString());
                li.SubItems.Add(dataReader1["username"].ToString());
                li.SubItems.Add(dataReader1["password"].ToString());
                li.SubItems.Add(dataReader1["email"].ToString());
                li.SubItems.Add(dataReader1["phone_number"].ToString());

                listview1.Items.Add(li);
            }
            dataReader1.Close();
            command1.Dispose();
            cnn1.Close();

            String connectionString2 = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=busticketdb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn2 = new SqlConnection(connectionString2);

            cnn2.Open();
            SqlCommand command2;
            SqlDataReader dataReader2;
            String sql2;

            sql2 = "SELECT * FROM [User] WHERE user_id <> '" + SelectedUserID + "'";
            command2 = new SqlCommand(sql2, cnn2);
            dataReader2 = command2.ExecuteReader();
            while (dataReader2.Read())
            {
                ListViewItem li = new ListViewItem(dataReader2["user_id"].ToString());
                li.SubItems.Add(dataReader2["first_name"].ToString());
                li.SubItems.Add(dataReader2["last_name"].ToString());
                li.SubItems.Add(dataReader2["username"].ToString());
                li.SubItems.Add(dataReader2["password"].ToString());
                li.SubItems.Add(dataReader2["email"].ToString());
                li.SubItems.Add(dataReader2["phone_number"].ToString());

                listview1.Items.Add(li);
            }

            dataReader2.Close();
            command2.Dispose();
            cnn2.Close();
        }
    }
}