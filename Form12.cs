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
    public partial class Form12 : Form
    {
        Form7 adminPanel = null;
        public Form12(Form7 adminPanel)
        {
            this.adminPanel = adminPanel;
            InitializeComponent();
        }

        private void Form12_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminPanel.Show();
        }
    }
}
