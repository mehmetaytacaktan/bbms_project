using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formProject
{
    public partial class Profile : Form
    {
        SelectTourDate form1;

        public Profile(SelectTourDate form1)
        {
            InitializeComponent();
            this.form1 = form1;


            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            listview.Parent = pictureBox1;

            //******************Database
            addTicketToListView("1A8P5E", "Bandırma", "Lodz", "8:00", "8200", listview);
            addTicketToListView("37AXM6", "'Merica", "GERMAN REICH", "4:00", "7", listview);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public static void addTicketToListView(string PNR, string from, string to, string departure,
                                               string cost, ListView listview)
        {
            listview.Items.Add("PNR: " + PNR + " From: " + from + " To: " + to +
                " Departure time: " + departure + " cost:" + cost + "TL");
        }
    }
}
