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

            String[] tickets = { "Ticket_Id", "User_FId", "Bus_FId", "Trip_FId", "Dep_Loc", "Arr_Loc", "Departure_Time_Date", "Arrival_Time_Date", "Price", "Is_Discount", "Price_Disc" };
            foreach (String ticketsItem in tickets)
            {
                listviewTickets.Columns.Add(ticketsItem);
            }

            String connectionString = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=BUS_BOOK_MAN_SYS_;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            sql = "SELECT * FROM Tickets ORDER BY Ticket_Id DESC";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ListViewItem li = new ListViewItem(dataReader["Ticket_Id"].ToString());
                li.SubItems.Add(dataReader["User_FId"].ToString());
                li.SubItems.Add(dataReader["Bus_FId"].ToString());
                li.SubItems.Add(dataReader["Trip_FId"].ToString());
                li.SubItems.Add(dataReader["Dep_Loc"].ToString());
                li.SubItems.Add(dataReader["Arr_Loc"].ToString());
                li.SubItems.Add(dataReader["Departure_Time_Date"].ToString());
                li.SubItems.Add(dataReader["Arrival_Time_Date"].ToString());
                li.SubItems.Add(dataReader["Price"].ToString());
                li.SubItems.Add(dataReader["Is_Discount"].ToString());
                li.SubItems.Add(dataReader["Price_Disc"].ToString());

                listviewTickets.Items.Add(li);
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            //*********************************Database
            //Profile.addTicketToListView("1A8P5E", "Bandırma", "Lodz", "8:00", "8200", listviewTickets);
            //Profile.addTicketToListView("37AXM6", "'Merica", "GERMAN REICH", "4:00", "7", listviewTickets);
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
            string pnr = textBox1.Text.ToString();
            listviewTickets.Items.Clear();

            String connectionString = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=BUS_BOOK_MAN_SYS_;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            sql = "SELECT * FROM Tickets WHERE Ticket_Id = '" + pnr + "'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            if (dataReader.Read())
            {
                ListViewItem li = new ListViewItem(dataReader["Ticket_Id"].ToString());
                li.SubItems.Add(dataReader["User_FId"].ToString());
                li.SubItems.Add(dataReader["Bus_FId"].ToString());
                li.SubItems.Add(dataReader["Trip_FId"].ToString());
                li.SubItems.Add(dataReader["Dep_Loc"].ToString());
                li.SubItems.Add(dataReader["Arr_Loc"].ToString());
                li.SubItems.Add(dataReader["Departure_Time_Date"].ToString());
                li.SubItems.Add(dataReader["Arrival_Time_Date"].ToString());
                li.SubItems.Add(dataReader["Price"].ToString());
                li.SubItems.Add(dataReader["Is_Discount"].ToString());
                li.SubItems.Add(dataReader["Price_Disc"].ToString());

                listviewTickets.Items.Add(li);
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            cnn.Open();
            SqlCommand command1;
            SqlDataReader dataReader1;
            String sql1;

            sql1 = "SELECT * FROM Tickets WHERE Ticket_Id != '" + pnr + "' ORDER BY Ticket_Id DESC";
            command1 = new SqlCommand(sql1, cnn);
            dataReader1 = command1.ExecuteReader();

            while (dataReader1.Read())
            {
                ListViewItem li = new ListViewItem(dataReader1["Ticket_Id"].ToString());
                li.SubItems.Add(dataReader1["User_FId"].ToString());
                li.SubItems.Add(dataReader1["Bus_FId"].ToString());
                li.SubItems.Add(dataReader1["Trip_FId"].ToString());
                li.SubItems.Add(dataReader1["Dep_Loc"].ToString());
                li.SubItems.Add(dataReader1["Arr_Loc"].ToString());
                li.SubItems.Add(dataReader1["Departure_Time_Date"].ToString());
                li.SubItems.Add(dataReader1["Arrival_Time_Date"].ToString());
                li.SubItems.Add(dataReader1["Price"].ToString());
                li.SubItems.Add(dataReader1["Is_Discount"].ToString());
                li.SubItems.Add(dataReader1["Price_Disc"].ToString());

                listviewTickets.Items.Add(li);
            }
            dataReader1.Close();
            command1.Dispose();
            cnn.Close();
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
            DateTime tmp1 = dateTimePicker1.Value;
            DateTime tmp2 = dateTimePicker2.Value;

            int ticketCount = 0;
            int sum = 0;


            String connectionString = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=BUS_BOOK_MAN_SYS_;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            String query = "SELECT Price FROM dbo.Tickets WHERE (Departure_Time_Date BETWEEN @Departure_Time_Date AND @Arrival_Time_Date) " +
                "AND (Arrival_Time_Date BETWEEN @Departure_Time_Date AND @Arrival_Time_Date)";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@Departure_Time_Date", System.Data.SqlDbType.DateTime).Value = tmp1;
                cmd.Parameters.Add("@Arrival_Time_Date", System.Data.SqlDbType.DateTime).Value = tmp2;

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