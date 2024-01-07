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
            UploadBoxes(cmbboxBusID);


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



            String tripId = generateTripId();// int döndürecek
            String connectionString = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=BUS_BOOK_MAN_SYS_;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            String query = "INSERT INTO dbo.Trips(Trip_Id, Dep_Loc, Arr_Loc, Bus_FId, Departure_Time_Date, Arrival_Time_Date)" +
                "VALUES(@Trip_Id, @Dep_Loc, @Arr_Loc, @Bus_FId, @Departure_Time_Date, @Arrival_Time_Date)";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@Trip_Id", System.Data.SqlDbType.VarChar).Value = tripId; // INT yapılacak
                cmd.Parameters.Add("@Dep_Loc", System.Data.SqlDbType.VarChar).Value = tmp1.SelectedItem.ToString();
                cmd.Parameters.Add("@Arr_Loc", System.Data.SqlDbType.VarChar).Value = tmp2.SelectedItem.ToString();
                cmd.Parameters.Add("@Bus_FId", System.Data.SqlDbType.VarChar).Value = tmp3.SelectedItem.ToString();
                cmd.Parameters.Add("@Departure_Time_Date", System.Data.SqlDbType.DateTime).Value = tmp4;
                cmd.Parameters.Add("@Arrival_Time_Date", System.Data.SqlDbType.DateTime).Value = tmp5;

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
            String connectionString = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=BUS_BOOK_MAN_SYS_;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            if (cmbb.Name == "cmbboxFrom")
            {
                sql = "SELECT DISTINCT(Dep_Loc) FROM Trips";
            }
            else if (cmbb.Name == "cmbboxTo")
            {
                sql = "SELECT DISTINCT(Arr_Loc) FROM Trips";
            }
            else
            {
                sql = "SELECT DISTINCT(Bus_FId) FROM Trips";
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

        public void deleteRecord()//ilgili delete butonuna koyulacak fonksiyon
        {
            ComboBox tmp1 = cmbboxFrom;
            ComboBox tmp2 = cmbboxTo;
            ComboBox tmp3 = cmbboxBusID;
            DateTime tmp5 = dtDeparture.Value;
            DateTime tmp4 = dtArrival.Value;

            String connectionString = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=BUS_BOOK_MAN_SYS_;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            String query = "DELETE From dbo.Trips WHERE Dep_Loc = @Dep_Loc AND Arr_Loc = @Arr_Loc AND Bus_FId = @Bus_FId AND " +
                "Departure_Time_Date = @Departure_Time_Date AND Arrival_Time_Date = @Arrival_Time_Date";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@Dep_Loc", System.Data.SqlDbType.VarChar).Value = tmp1.SelectedItem.ToString();
                cmd.Parameters.Add("@Arr_Loc", System.Data.SqlDbType.VarChar).Value = tmp2.SelectedItem.ToString();
                cmd.Parameters.Add("@Bus_FId", System.Data.SqlDbType.VarChar).Value = tmp3.SelectedItem.ToString();
                cmd.Parameters.Add("@Departure_Time_Date", System.Data.SqlDbType.VarChar).Value = tmp5;
                cmd.Parameters.Add("@Arrival_Time_Date", System.Data.SqlDbType.VarChar).Value = tmp4;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfully Deleted!");
            }
        }
        public string generateTripId() //int yapılacak
        {
            int maxTripId = 0;

            String connectionString = "Data Source=LAPTOP-PBSAV96D\\DEMODB;Initial Catalog=BUS_BOOK_MAN_SYS_;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            sql = "SELECT MAX(Trip_Id) FROM Trips GROUP BY Trip_Id";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                Int32.TryParse(dataReader.GetValue(0).ToString(), out maxTripId);
                maxTripId++;
            }

            //return maxTripId.ToString(); //string i int yapınca düzelicek!
            return 41.ToString();
        }
    }
}