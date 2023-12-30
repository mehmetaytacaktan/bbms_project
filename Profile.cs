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
        Form1 form1;

        public Profile(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            //******************Database
            addTicketToListView("1A8P5E", "Bandırma", "Lodz", "8:00", "8200");
            addTicketToListView("37AXM6", "'Merica", "GERMAN REICH", "4:00", "7");
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

        private void addTicketToListView(string PNR, string from, string to, string departure,
            string cost)
        {
            listview.Items.Add("PNR: " + PNR + " From: " + from + " To: " + to +
                " Departure time: " + departure + " cost:" + cost + "TL");
        }
    }
}
