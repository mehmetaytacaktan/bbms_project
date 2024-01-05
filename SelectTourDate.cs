using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace formProject
{
    public partial class SelectTourDate : Form
    {
        readonly string[] removedCities = new string[2];//0 to, 1 from
        readonly SelectTour BuyingScreen;
        readonly RegisterNLogin LoginScreen;
        Profile profile;

        public SelectTourDate(RegisterNLogin LoginScreen)
        {
            InitializeComponent();
            //We send this form instance to the form2 so we can enable it from here
            BuyingScreen = new SelectTour(this);
            profile = new Profile(this);
            BuyingScreen.Hide();
            this.Show();//(already shown)
            this.LoginScreen = LoginScreen;

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
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
            AddCities(ComboBoxFrom, ComboBoxTo);
        }

        static public void AddCities(ComboBox ComboBoxFrom, ComboBox ComboBoxTo)
        {
            List<string> cities = new List<string>();
            cities.Add("Akkeçili");
            cities.Add("Manhattan");
            cities.Add("İzmir");
            cities.Add("Lodz");

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

        private void BtnToday_Click_1(object sender, EventArgs e)
        {
            BtnToday_Click(sender, e);
        }

        private void BtnTomorrow_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void BtnBuy_Click_1(object sender, EventArgs e)
        {
            BtnBuy_Click(sender, e);
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            button1_Click_1(sender, e);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            profile.Show();
            this.Hide();
        }
    }
}