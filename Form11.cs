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
    }
}
