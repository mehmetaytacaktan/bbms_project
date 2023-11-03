using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formProject
{
    public partial class Form3 : Form
    {
        Form1 MainMenu;
        bool login = true;

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
            //trying to login
            if(login)
            {
                if (UserExists(textBox1.Text, textBox2.Text))
                {
                    //deploys main menu.
                    MainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password are incorrect",
                        "False information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //trying to register
            else
            {
                //tried to register but username is in use
                if (UserExists(textBox1.Text))
                {
                    MessageBox.Show("Username is in use please try another username",
                        "Unavaliable username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //registered succesfully
                else
                {
                    CreateUser(textBox1.Text, textBox2.Text);

                    MainMenu.Show();
                    this.Hide();
                }
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            login = !login;

            //changes interface so that user knows that they are login'ing
            if (login)
            {
                BtnLogin.Text = "LOGIN";
                BtnLogin.Location = new Point(40, 216);
                BtnLogin.Size = new Size(169, 55);

                textBox2.PasswordChar = '*';

                label3.Location = new Point(74, 282);
                label3.Text = "Create account";
            }
            //changes interface so that user knows that they are register'ing
            else
            {
                BtnLogin.Text = "REGISTER";
                BtnLogin.Location = new Point(10, 216);
                BtnLogin.Size = new Size(227, 55);

                textBox2.PasswordChar = textBox1.PasswordChar;

                label3.Location = new Point(80, 282);
                label3.Text = "Click to login";
            }
        }

        //checks if user with that name exists
        bool UserExists(string username)//********************************DataBase
        {
            if(username == "admin" || username == "user")
                return true;
            else
                return false;
        }

        //checks if user with that name and password exists
        bool UserExists(string username, string password)
        {
            if(username == "user" && password == "user")//********************************DataBase
            {
                return true;
            }
            else if (username == "admin" && password == "admin")//********************************DataBase
            {
                return true;
            }
            else
            {
                MessageBox.Show("Username or password are incorrect",
                    "False information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //creates user
        void CreateUser(string username, string password)//********************************DataBase
        {

        }
    }
}
