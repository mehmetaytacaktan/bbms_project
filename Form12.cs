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
        Form8 form2 = null;
        public Form12(Form8 form2)
        {
            this.form2 = form2;
            this.Show();
            form2.Hide();
            InitializeComponent();
        }

        

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGoBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            form2.Show();
        }
    }
}
