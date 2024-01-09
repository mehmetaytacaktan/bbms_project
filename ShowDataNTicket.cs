using formProject;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BMSAdminPanel
{
    //NOT CONSTRUCTED YET
    public partial class ShowDataNTicket : Form
    {
        AdminPanel adminPanel = null;
        public ShowDataNTicket(AdminPanel adminPanel)
        {
            this.adminPanel = adminPanel;
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd hh:mm";

            String[] tickets = { "ticket_id", "user_fid", "trip_fid", "bus_fid", "departure_location", "arrival_location", "departure_time_date", "arrival_time_date", "price", "is_discounted", "discounted_price" };
            foreach (String ticketsItem in tickets)
            {
                listviewTickets.Columns.Add(ticketsItem);
            }

            String connectionString = "Data Source=DESKTOP-5QOGEHT\\SQLEXPRESS;Initial Catalog=busticketdb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            sql = "SELECT * FROM Ticket ORDER BY ticket_id DESC";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ListViewItem li = new ListViewItem(dataReader["ticket_id"].ToString());
                li.SubItems.Add(dataReader["user_fid"].ToString());
                li.SubItems.Add(dataReader["trip_fid"].ToString());
                li.SubItems.Add(dataReader["bus_fid"].ToString());
                li.SubItems.Add(dataReader["departure_location"].ToString());
                li.SubItems.Add(dataReader["arrival_location"].ToString());
                li.SubItems.Add(dataReader["departure_time_date"].ToString());
                li.SubItems.Add(dataReader["arrival_time_date"].ToString());
                li.SubItems.Add(dataReader["price"].ToString());
                li.SubItems.Add(dataReader["is_discounted"].ToString());
                li.SubItems.Add(dataReader["discounted_price"].ToString());

                listviewTickets.Items.Add(li);
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void Form11_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click_1(object sender, EventArgs e)
        {
            adminPanel.Show();
            this.Hide();
        }

        private void lblDiscount_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pnr2 = textBox1.Text;
            if(pnr2.Length != 1)
            {
                MessageBox.Show("PNR has to be 1 character long.",
                    "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string pnr = textBox1.Text.ToString();
            listviewTickets.Items.Clear();

            String connectionString = "Data Source=DESKTOP-5QOGEHT\\SQLEXPRESS;Initial Catalog=busticketdb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            sql = "SELECT * FROM Ticket WHERE ticket_id = '" + pnr + "'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            if (dataReader.Read())
            {
                ListViewItem li = new ListViewItem(dataReader["ticket_id"].ToString());
                li.SubItems.Add(dataReader["user_fid"].ToString());
                li.SubItems.Add(dataReader["trip_fid"].ToString());
                li.SubItems.Add(dataReader["bus_fid"].ToString());
                li.SubItems.Add(dataReader["departure_location"].ToString());
                li.SubItems.Add(dataReader["arrival_location"].ToString());
                li.SubItems.Add(dataReader["departure_time_date"].ToString());
                li.SubItems.Add(dataReader["arrival_time_date"].ToString());
                li.SubItems.Add(dataReader["price"].ToString());
                li.SubItems.Add(dataReader["is_discounted"].ToString());
                li.SubItems.Add(dataReader["discounted_price"].ToString());

                listviewTickets.Items.Add(li);
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            cnn.Open();
            SqlCommand command1;
            SqlDataReader dataReader1;
            String sql1;

            sql1 = "SELECT * FROM Ticket WHERE ticket_id != '" + pnr + "' ORDER BY ticket_id DESC";
            command1 = new SqlCommand(sql1, cnn);
            dataReader1 = command1.ExecuteReader();

            while (dataReader1.Read())
            {
                ListViewItem li = new ListViewItem(dataReader1["ticket_id"].ToString());
                li.SubItems.Add(dataReader1["user_fid"].ToString());
                li.SubItems.Add(dataReader1["trip_fid"].ToString());
                li.SubItems.Add(dataReader1["bus_fid"].ToString());
                li.SubItems.Add(dataReader1["departure_location"].ToString());
                li.SubItems.Add(dataReader1["arrival_location"].ToString());
                li.SubItems.Add(dataReader1["departure_time_date"].ToString());
                li.SubItems.Add(dataReader1["arrival_time_date"].ToString());
                li.SubItems.Add(dataReader1["price"].ToString());
                li.SubItems.Add(dataReader1["is_discounted"].ToString());
                li.SubItems.Add(dataReader1["discounted_price"].ToString());

                listviewTickets.Items.Add(li);
            }
            dataReader1.Close();
            command1.Dispose();
            cnn.Close();
            //*************************************Database
            //Display the spesific ticket at top.
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ShowEarnings();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ShowEarnings();
        }

        void ShowEarnings()
        {
            DateTime dtStart;
            DateTime dtEnd;

            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                dtStart = dateTimePicker2.Value.Date;
                dtEnd = dateTimePicker1.Value.Date;
            }
            else if (dateTimePicker1.Value.Date < dateTimePicker2.Value.Date)
            {
                dtStart = dateTimePicker1.Value.Date;
                dtEnd = dateTimePicker2.Value.Date;
            }
            else//They are equal therefor check every sale
            {
                dtStart = new DateTime(2000, 1, 1, 1, 1, 1, 1);
                dtEnd = DateTime.Now.Date;
            }


            //******************************Database
            //show the statistics between dtStart and dtEnd on label3 and label4
            int ticketCount = 0;
            int sum = 0;


            String connectionString = "Data Source=DESKTOP-5QOGEHT\\SQLEXPRESS;Initial Catalog=busticketdb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            String query = "SELECT price FROM dbo.Ticket WHERE (departure_time_date BETWEEN @departure_time_date AND @arrival_time_date) " +
                "AND (arrival_time_date BETWEEN @departure_time_date AND @arrival_time_date)";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@departure_time_date", System.Data.SqlDbType.DateTime).Value = dtStart;
                cmd.Parameters.Add("@arrival_time_date", System.Data.SqlDbType.DateTime).Value = dtEnd;

                con.Open();
                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Int32.TryParse(dataReader.GetValue(0).ToString(), out int amount);
                    sum += amount;
                    ticketCount++;
                }
                con.Close();
                label3.Text = ticketCount.ToString();
                label4.Text = sum.ToString();
            }
        }
    }
}