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
        Form7 form1 = null;
        public Form11(Form7 form1)
        {
            this.form1 = form1;
            this.Show();
            form1.Hide();
            InitializeComponent();
            
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        { 
            form1.Show();
            this.Close();
        }

        private void Form11_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
