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
        string[] removedCities = new string[2];//0 to, 1 from
        Form2 BuyingScreen;

        public Form1()
        {
            InitializeComponent();
            //We send this form instance to the form2 so we can enable it from here
            BuyingScreen = new Form2(this);
            BuyingScreen.Hide();
            this.Show();//(already shown)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            removedCities[0] = ("");
            removedCities[1] = ("");

            //DateTimePicker
            DateTimePicker.MinDate = DateTimeLimits.Min();
            DateTimePicker.MaxDate = DateTimeLimits.Max();
            //Combo Boxes (SEXob obmoc)
            ComboBoxFrom.Items.Clear();
            ComboBoxTo.Items.Clear();
            AddCities();
        }

        void AddCities()
        {
            List<string> cities = new List<string>();

            //******************TODO: get these from database
            cities.Add("Japonya");
            cities.Add("Fransa");
            cities.Add("Çin");
            cities.Add("Kazakistan");

            foreach (var city in cities)
            {
                ComboBoxFrom.Items.Add(city);
                ComboBoxTo.Items.Add(city);
            }
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            DateTimePicker.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)//btnTomorrow
        {
            DateTimePicker.Value = DateTime.Now.AddDays(1);
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            Debug.Print(ComboBoxTo.SelectedValue.ToString());

            if(ComboBoxTo.SelectedValue != null)
            {
                this.Hide();
                BuyingScreen.Show();
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            BuyingScreen.Close();
            //we are already closed
        }

        //Login
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //******************TODO: Login as admin
            MessageBox.Show("Login work in progress");
        }
    }
}
