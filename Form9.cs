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
    public partial class Form9 : Form
    {
        Form7 adminPanel = null;
        public Form9(Form7 adminPanel)
        {
            this.adminPanel = adminPanel;
            InitializeComponent();
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
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
