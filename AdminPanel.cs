using System;
using System.Windows.Forms;

namespace BMSAdminPanel
{
    public partial class AdminPanel : Form
    {
        CheckClient client;
        ApplyDiscount discount;
        ShowDataNTicket campaign;
        AddTour tourMenu;

        public AdminPanel()
        {
            InitializeComponent();
            client = new CheckClient(this);
            discount = new ApplyDiscount(this);
            campaign = new ShowDataNTicket(this);
            tourMenu = new AddTour(this);
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