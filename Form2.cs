using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formProject
{
    public partial class Form2 : Form
    {
        Form1 MainMenu;

        public Form2(Form1 MainMenu)
        {
            InitializeComponent();
            this.MainMenu = MainMenu;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu.Show();
            //we are allready closed
        }

        private void BtnPrevDay_Click(object sender, EventArgs e)
        {
            if(!(DateTimePicker2.Value.AddDays(-1) < DateTimeLimits.Min()))
            {
                DateTimePicker2.Value = DateTimePicker2.Value.AddDays(-1);
            }
        }

        private void BtnNextDay_Click(object sender, EventArgs e)
        {
            if (!(DateTimePicker2.Value.AddDays(1) > DateTimeLimits.Max()))
            {
                DateTimePicker2.Value = DateTimePicker2.Value.AddDays(1);
            }
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}