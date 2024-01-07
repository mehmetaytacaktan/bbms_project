using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BMSAdminPanel
{
    public partial class ApplyDiscount : Form
    {
        AdminPanel adminPanel = null;
        public ApplyDiscount(AdminPanel adminPanel)
        {
            this.adminPanel = adminPanel;
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm";


            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd hh:mm";
        }

        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            adminPanel.Show();
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            //******************************************Database
            DateTime tmp1 = dateTimePicker1.Value;
            DateTime tmp2 = dateTimePicker3.Value;

            Int32.TryParse(textBox1.Text, out int discount);
            if (discount >= 0 && discount <= 100)
            {
                String connectionString1 = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=busticketdb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
                String query = "UPDATE dbo.Ticket SET discounted_price = (Price)*(100 - @discount)/100, is_discounted = 1 WHERE (" +
                    "departure_time_date BETWEEN @departure_time_date AND @arrival_time_date) AND (" +
                    "arrival_time_date BETWEEN @departure_time_date AND @arrival_time_date)";
                using (SqlConnection con = new SqlConnection(connectionString1))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@discount", System.Data.SqlDbType.Int).Value = discount;
                    cmd.Parameters.Add("@departure_time_date", System.Data.SqlDbType.DateTime).Value = tmp1;
                    cmd.Parameters.Add("@arrival_time_date", System.Data.SqlDbType.DateTime).Value = tmp2;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Changes Succesfully Applied!");
                }
            }
            else
            {
                MessageBox.Show("Enter value between [0,100]");
            }
        }

        private void btnDisableDiscount_Click(object sender, EventArgs e)
        {
            //******************************************Database
            DateTime tmp1 = dateTimePicker1.Value;
            DateTime tmp2 = dateTimePicker3.Value;

            String connectionString1 = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=busticketdb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            String query = "UPDATE dbo.Ticket SET is_discounted = 0 WHERE (" +
                "departure_time_date BETWEEN @departure_time_date AND @arrival_time_date) AND (" +
                "arrival_time_date BETWEEN @departure_time_date AND @arrival_time_date)";
            using (SqlConnection con = new SqlConnection(connectionString1))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@departure_time_date", System.Data.SqlDbType.DateTime).Value = tmp1;
                cmd.Parameters.Add("@arrival_time_date", System.Data.SqlDbType.DateTime).Value = tmp2;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Changes Succesfully Applied!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string output = "";

            foreach (char ch in textBox1.Text)
            {
                if (char.IsNumber(ch))
                {
                    output += ch;
                }
            }

            textBox1.Text = output;
        }
    }
}