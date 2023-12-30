using System;
using System.Windows.Forms;

namespace BMSAdminPanel
{
    //NOT CONSTRUCTED YET
    public partial class Form11 : Form
    {
        Form7 adminPanel = null;
        public Form11(Form7 adminPanel)
        {
            this.adminPanel = adminPanel;
            InitializeComponent();
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

        }
    }
}