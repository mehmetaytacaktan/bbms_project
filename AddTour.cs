using formProject;
using System;
using System.Collections.Generic;
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

            string EveryCity = "Akkeçili Adana Adıyaman Afyonkarahisar Ağrı " +
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
            }
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
            DateTime tmp4 = dtArrival.Value.Date;
            DateTime tmp5 = dtDeparture.Value.Date;
            //send these to //*********************************DataBase
        }
    }
}