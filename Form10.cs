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
    public partial class Form10 : Form
    {
        Form7 adminPanel = null;
        public Form10(Form7 adminPanel)
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
    }
}
