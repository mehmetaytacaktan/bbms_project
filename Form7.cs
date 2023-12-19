using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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

        private void btnARM_Click(object sender, EventArgs e)//add tour
        {
            tourMenu.Show();
            this.Hide();
        }

        private void btnIquiry_Click(object sender, EventArgs e)
        {
            client.Show();
            this.Hide();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            discount.Show();
            this.Hide();
        }

        private void btnCampaign_Click(object sender, EventArgs e)
        {
            campaign.Show();
            this.Hide();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
