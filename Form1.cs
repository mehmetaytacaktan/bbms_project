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
    public partial class Form1 : Form
    {
        readonly string[] removedCities = new string[2];//0 to, 1 from
        readonly Form2 BuyingScreen;
        readonly Form3 LoginScreen;

        public Form1(Form3 LoginScreen)
        {
            InitializeComponent();
            //We send this form instance to the form2 so we can enable it from here
            BuyingScreen = new Form2(this);
            BuyingScreen.Hide();
            this.Show();//(already shown)
            this.LoginScreen = LoginScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //I hold these so that I can delete a selected city
            //from the other comboBox
            removedCities[0] = ("");
            removedCities[1] = ("");

            //DateTimePicker
            DateTimePicker1.MinDate = DateTimeLimits.Min();
            DateTimePicker1.MaxDate = DateTimeLimits.Max();
            //Combo Boxes
            ComboBoxFrom.Items.Clear();
            ComboBoxTo.Items.Clear();
            AddCities();
        }

        void AddCities()
        {
            List<string> cities = new List<string>
            {
                //********************************DataBase 
                "Japonya",
                "Fransa",
                "Çin",
                "Kazakistan"
            };

            foreach (var city in cities)
            {
                ComboBoxFrom.Items.Add(city);
                ComboBoxTo.Items.Add(city);
            }
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            DateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)//btnTomorrow
        {
            DateTimePicker1.Value = DateTime.Now.AddDays(1);
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            if(removedCities[0] != "" && removedCities[1] != "")
            {
                this.Hide();
                BuyingScreen.Show();
                BuyingScreen.ReWriteDate(DateTimePicker1.Value);
            }
            else
            {
                MessageBox.Show("You need to select \"FROM\" and \"TO\" places",
                    "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ComboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (removedCities[1] != "")
            {
                ComboBoxFrom.Items.Add(removedCities[1]);
            }
            removedCities[1] = ComboBoxTo.SelectedItem.ToString();
            ComboBoxFrom.Items.Remove(ComboBoxTo.SelectedItem);
        }

        private void ComboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (removedCities[0] != "")
            {
                ComboBoxTo.Items.Add(removedCities[0]);
            }
            removedCities[0] = ComboBoxFrom.SelectedItem.ToString();
            ComboBoxTo.Items.Remove(ComboBoxFrom.SelectedItem);
        }

        //Login
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //******************TODO: Login as admin
            MessageBox.Show("Login work in progress");
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        //back
        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginScreen.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
