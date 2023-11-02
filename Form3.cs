using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formProject
{
    public partial class Form3 : Form
    {
        Form1 MainMenu;

        public Form3()
        {
            InitializeComponent();
            MainMenu = new Form1(this);
            MainMenu.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu.Show();
            this.Hide();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu.Close();
            //we are already closed and Form1 closes Form2
        }
    }
}
