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
    public partial class Register2 : Form
    {
        RegisterNLogin LoginScreen;
        public string username;
        public string password;

        public Register2(RegisterNLogin loginScreen)
        {
            InitializeComponent();
            this.LoginScreen = loginScreen;

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            bool hasEmpty = false;

            if (textBox3.Text == string.Empty)
            {
                hasEmpty = true;
                MessageBox.Show("Legal name is empty",
                    "False information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!textBox3.Text.Contains(' '))
            {
                hasEmpty = true;
                MessageBox.Show("Please seperate your surname using space",
                    "False information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (textBox2.Text == string.Empty)
            {
                hasEmpty = true;
                MessageBox.Show("Phone number is empty",
                    "False information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!IsDigitsOnly(textBox2.Text))
            {
                hasEmpty = true;
                MessageBox.Show("Phone numbers should only have numbers from 0 to 9",
                    "False information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text.Length != 11)
            {
                hasEmpty = true;
                MessageBox.Show("Please enter a phone number",
                    "False information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (textBox1.Text == string.Empty)
            {
                hasEmpty = true;
                MessageBox.Show("TC no is empty",
                    "False information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!IsDigitsOnly(textBox1.Text))
            {
                hasEmpty = true;
                MessageBox.Show("TC should only have numbers from 0 to 9",
                    "False information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text.Length != 11)
            {
                hasEmpty = true;
                MessageBox.Show("Please enter a valid TC",
                    "False information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!hasEmpty)
            {
                //register **************************************Database
                LoginScreen.profiles.s.Add(new Profile(username, password));

                username = "";
                password = "";
                textBox3.Text = "";//legal name
                textBox2.Text = "";//phone
                textBox1.Text = "";//tc

                this.LoginScreen.ChangeLoginOrRegister();
                this.LoginScreen.Show();
                this.Hide();
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.LoginScreen.ChangeLoginOrRegister();
            this.LoginScreen.Show();
            this.Hide();
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
