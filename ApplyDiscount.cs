using System;
using System.Windows.Forms;

namespace BMSAdminPanel
{
    public partial class ApplyDiscount : Form
    {
        AdminPanel adminPanel = null;
        public ApplyDiscount(AdminPanel adminPanel)
        {
            this.adminPanel = adminPanel;
            InitializeComponent();
        }

        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            adminPanel.Show();
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            //******************************************Database
            DateTime tmp1 = dateTimePicker3.Value;
            DateTime tmp2 = dateTimePicker1.Value;
        }

        private void btnDisableDiscount_Click(object sender, EventArgs e)
        {
            //******************************************Database
            DateTime tmp1 = dateTimePicker3.Value;
            DateTime tmp2 = dateTimePicker1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string output = "";

            foreach (char ch in textBox1.Text)
            {
                if (char.IsNumber(ch))
                {
                    output += ch;
                }
            }

            textBox1.Text = output;
        }
    }
}