using System;
using System.Windows.Forms;

namespace BMSAdminPanel
{
    public partial class Form7 : Form
    {
        Form9 client;
        Form10 discount;
        Form11 campaign;
        Form12 tourMenu;

        public Form7()
        {
            InitializeComponent();
            client = new Form9(this);
            discount = new Form10(this);
            campaign = new Form11(this);
            tourMenu = new Form12(this);
        }

        //1
        private void btnARM_Click(object sender, EventArgs e)//add tour
        {
            tourMenu.Show();
            this.Hide();
        }

        //2
        private void btnIquiry_Click(object sender, EventArgs e)
        {
            client.Show();
            this.Hide();
        }

        //3
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            discount.Show();
            this.Hide();
        }

        //4
        private void btnCampaign_Click(object sender, EventArgs e)
        {
            campaign.Show();
            this.Hide();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}