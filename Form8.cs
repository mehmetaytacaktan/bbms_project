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
    public partial class Form8 : Form
    {
        Form7 form1 = null;
        public Form8(Form7 form1)
        {
            this.form1 = form1;
            this.Show();
            form1.Hide();
            InitializeComponent();
            BringTheTable();
        }

        public static void BringTheTable()
        {
            //Quiry tuples + remove button + modify button
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form12 form6 = new Form12(this);
        }

        
    }
}
