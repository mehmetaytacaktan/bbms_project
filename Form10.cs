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
        Form7 form1 = null;
        public Form10(Form7 form1)
        {
            this.form1 = form1;
            this.Show();
            form1.Hide();
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {

        }

        private void btnDisableDiscount_Click(object sender, EventArgs e)
        {

        }
    }
}
