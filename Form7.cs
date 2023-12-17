using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMSAdminPanel
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnARM_Click(object sender, EventArgs e)
        {
            Form8 form2 = new Form8(this);
        }

        private void btnIquiry_Click(object sender, EventArgs e)
        {
            Form9 form3 = new Form9(this);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            Form10 form4 = new Form10(this);
        }

        private void btnCampaign_Click(object sender, EventArgs e)
        {
            Form11 form5 = new Form11(this);
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
