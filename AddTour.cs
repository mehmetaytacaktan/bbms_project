using formProject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BMSAdminPanel
{
    public partial class AddTour : Form
    {
        AdminPanel adminPanel = null;
        public AddTour(AdminPanel adminPanel)
        {
            this.adminPanel = adminPanel;
            InitializeComponent();
            UploadBoxes(cmbboxFrom);
            UploadBoxes(cmbboxTo);
            UploadBusIDs(cmbboxBusID);

            dtDeparture.Format = DateTimePickerFormat.Custom;
            dtDeparture.CustomFormat = "yyyy-MM-dd hh:mm";

            dtArrival.Format = DateTimePickerFormat.Custom;
            dtArrival.CustomFormat = "yyyy-MM-dd hh:mm";

            /* string EveryCity = "Akkeçili Adana Adıyaman Afyonkarahisar Ağrı " +
                 "Aksaray Amasya Ankara Antalya Ardahan Artvin Aydın Balıkesir " +
                 "Bartın Batman Bayburt Bilecik Bingöl Bitlis Bolu Burdur Bursa " +
                 "Çanakkale Çankırı Çorum Denizli Diyarbakır Düzce Edirne Elazığ " +
                 "Erzincan Erzurum Eskişehir Gaziantep Giresun Gümüşhane Hakkâri " +
                 "Hatay Iğdır Isparta İstanbul İzmir Kahramanmaraş Karabük Karaman " +
                 "Kars Kastamonu Kayseri Kırıkkale Kırklareli Kırşehir Kilis Kocaeli " +
                 "Konya Kütahya Malatya Manisa Mardin Mersin Muğla Muş Nevşehir Niğde " +
                 "Ordu Osmaniye Rize Sakarya Samsun Siirt Sinop Sivas Şanlıurfa Şırnak " +
                 "Tekirdağ Tokat Trabzon Tunceli Uşak Van Yalova Yozgat Zonguldak";
             string[] Cities = EveryCity.Split(' ');
             foreach (var City in Cities)
             {
                 cmbboxFrom.Items.Add(City);
                 cmbboxTo.Items.Add(City);
             }

             List<string> BusIDs = new List<string>();
             //00000, 00001, 00002, 00003
             //*************************************************DataBase
             for (int i = 1; i <= 179; i++)
             {
                 string CurrentID = "";
                 int digits = (int)Math.Log10(i) + 1; // get the number of digits in i
                 CurrentID = ""; // reset the CurrentID
                 for (int j = 0; j < 5 - digits; j++)
                 {
                     CurrentID += "0"; // add zeros to the CurrentID
                 }

                 CurrentID += i;
                 BusIDs.Add(CurrentID);
             }
             foreach (var BusID in BusIDs)
             {
                 cmbboxBusID.Items.Add(BusID);
             }*/
        }

        private void Form12_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComboBox tmp1 = cmbboxFrom;
            ComboBox tmp2 = cmbboxTo;
            ComboBox tmp3 = cmbboxBusID;
            DateTime tmp4 = dtDeparture.Value;
            DateTime tmp5 = dtArrival.Value;
            Int32.TryParse(tmp3.SelectedItem.ToString(), out int p_bus_fid);


            int tripId = generateTripId();
            String connectionString = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=busticketdb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            String query = "INSERT INTO dbo.Trips(trip_id, bus_fid, departure_location, arrival_location, departure_time_date, arrival_time_date)" +
                "VALUES(@trip_id, @bus_fid, @departure_location, @arrival_location, @departure_time_date, @arrival_time_date)";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            { 
                cmd.Parameters.Add("@trip_id", System.Data.SqlDbType.Int).Value = tripId;
                cmd.Parameters.Add("@bus_fid", System.Data.SqlDbType.Int).Value = p_bus_fid;
                cmd.Parameters.Add("@departure_location", System.Data.SqlDbType.VarChar).Value = tmp1.SelectedItem.ToString();
                cmd.Parameters.Add("@arrival_location", System.Data.SqlDbType.VarChar).Value = tmp2.SelectedItem.ToString();
                cmd.Parameters.Add("@departure_time_date", System.Data.SqlDbType.DateTime).Value = tmp4;
                cmd.Parameters.Add("@arrival_time_date", System.Data.SqlDbType.DateTime).Value = tmp5;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfully Inserted!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteRecord();
        }

        public void UploadBoxes(ComboBox cmbb)
        {
            String connectionString = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=busticketdb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            if (cmbb.Name == "cmbboxFrom")
            {
                sql = "SELECT DISTINCT(departure_location) FROM Trips";
            }
            else
            {
                sql = "SELECT DISTINCT(arrival_location) FROM Trips";
            }

            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                cmbb.Items.Add(dataReader.GetString(0));
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();

        }

        public void UploadBusIDs(ComboBox cmbb)
        {
            String connectionString = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=busticketdb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            sql = "SELECT DISTINCT(bus_fid) FROM Trips";

            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {

                cmbb.Items.Add(dataReader["bus_fid"].ToString());//Düzelt
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        public void deleteRecord()
        {
            ComboBox tmp1 = cmbboxFrom;
            ComboBox tmp2 = cmbboxTo;
            ComboBox tmp3 = cmbboxBusID;
            DateTime tmp5 = dtDeparture.Value;
            DateTime tmp4 = dtArrival.Value;
            Int32.TryParse(tmp3.SelectedItem.ToString(), out int p_bus_fid);

            String connectionString = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=busticketdb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            String query = "DELETE From dbo.Trips WHERE departure_location = @departure_location AND arrival_location = @arrival_location AND bus_fid = @bus_fid AND " +
                "departure_time_date = @departure_time_date AND arrival_time_date = @arrival_time_date";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@departure_location", System.Data.SqlDbType.VarChar).Value = tmp1.SelectedItem.ToString();
                cmd.Parameters.Add("@arrival_location", System.Data.SqlDbType.VarChar).Value = tmp2.SelectedItem.ToString();
                cmd.Parameters.Add("@bus_fid", System.Data.SqlDbType.Int).Value = p_bus_fid;
                cmd.Parameters.Add("@departure_time_date", System.Data.SqlDbType.DateTime).Value = tmp5;
                cmd.Parameters.Add("@arrival_time_date", System.Data.SqlDbType.DateTime).Value = tmp4;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfully Deleted!");
            }
        }
        public int generateTripId()
        {
            int maxTripId = 0;

            String connectionString = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=busticketdb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            sql = "SELECT MAX(trip_id) FROM Trips";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            if (dataReader != null && dataReader.Read())
            {
                Int32.TryParse(dataReader.GetValue(0).ToString(), out maxTripId);
                maxTripId++;
                
            }
            return maxTripId;
        }
    }
}