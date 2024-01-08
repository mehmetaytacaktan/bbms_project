using formProject;
using System;
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

            //*********************************Database
            ProfileMenu.addTicketToListView("1A8P5E", "Bandırma", "İstanbul", "8:00", "820", listviewTickets);
            ProfileMenu.addTicketToListView("37AXM6", "Akkeçili", "Bandırma", "4:00", "700", listviewTickets);
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
            string pnr = textBox1.Text;
            if(pnr.Length != 6)
            {
                MessageBox.Show("PNR's are 6 character long.",
                    "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
        }
    }
}