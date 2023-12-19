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
        Form7 form7 = null;
        public Form8(Form7 form7)
        {
            this.form7 = form7;
            this.Show();
            form7.Hide();
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
            form7.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form12 form6 = new Form12(this);
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
